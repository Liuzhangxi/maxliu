using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace OUDAL
{
    public enum UserCheckResult { 验证通过, 用户密码错误, 用户不存在, 用户登录锁定 }
    public enum UserState { Enabled, Disabled }
    public class SystemUser
    {
        public static string LogClass = "系统用户";
        public int Id { get; set; }
        /// <summary>
        /// 0=正常 1=禁用
        /// </summary>
        public int State { get; set; }
        [Required]
        [DisplayName("登录名")]
        [MaxLength(50)]
        public string LoginName { get; set; }

        [DisplayName("密码")]
        [MaxLength(100)]
        public string Password { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayName("姓名")]
        public string Name { get; set; }
        [DisplayName("邮箱")]
        [MaxLength(50)]
        public string Email { get; set; }
        public SystemUser()
        {
            Name = ""; Email = "";
        }
        public bool CheckPassword(string password)
        {
            return Password == EncryptPassword(LoginName.ToLower(), password);
        }
        /// <summary>
        /// 修改密码或用户名时候调用。调用时password应该是加密前password
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public void Save(Context db, SystemUser newValue)
        {
            if (Id == 0)
            {
                db.SystemUsers.Add(this);
            }
            newValue.LoginName = newValue.LoginName.Trim();
            if (LoginName != newValue.LoginName || string.IsNullOrEmpty(newValue.Password) == false)
            {
                LoginName = newValue.LoginName;
                Password = EncryptPassword(LoginName.ToLower(), newValue.Password);
            }

            Name = newValue.Name;
            Email = newValue.Email;
            State = newValue.State;
            db.SaveChanges();
            //刷新缓存
            UserBLL.Users = null;
        }

        public void ChangePassword(Context db, string password)
        {
            Password = EncryptPassword(LoginName.ToLower(), password);
            db.SaveChanges();
        }
        public static string EncryptPassword(string pre, string password)
        {
            System.Security.Cryptography.SHA1 sha = System.Security.Cryptography.SHA1.Create();
            byte[] byteResult = sha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(pre + password));
            return BitConverter.ToString(byteResult);
        }
        static Dictionary<string, int> logonFailedList = new Dictionary<string, int>();
        public const int LOGON32_LOGON_INTERACTIVE = 2;

        public const int LOGON32_PROVIDER_DEFAULT = 0;



        [DllImport("advapi32.dll", CharSet = CharSet.Auto)]

        public static extern int LogonUser(String lpszUserName, String lpszDomain, String lpszPassword, int dwLogonType, int dwLogonProvider, ref IntPtr phToken);

        [DllImport("advapi32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto, SetLastError = true)]
        public extern static int DuplicateToken(IntPtr hToken, int impersonationLevel, ref IntPtr hNewToken);

        public static UserCheckResult CheckJMSUser(string name, string password,out JMSLXR jms)
        {
            jms = null;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password))
            {
                return UserCheckResult.用户密码错误;
            }
            using (Context context = new Context())
            {
                JMSLXR lxr = context.JMSLXR.FirstOrDefault(r => r.LxrName == name && r.LxrPwd == password);
                if (lxr == null)
                {
                    return UserCheckResult.用户不存在;
                }
                jms = lxr;
                return UserCheckResult.验证通过;
            }
        }

        static public UserCheckResult CheckUser(string name, string password, out SystemUser user, bool isDomain)
        {
            if (logonFailedList.ContainsKey(name))
            {
                if (logonFailedList[name] > 4)
                {
                    user = null;
                    return UserCheckResult.用户登录锁定;
                }
            }
            Context db = new Context();
            user =
                                (from o in db.SystemUsers where o.State == (int)UserState.Enabled && (name == o.LoginName) select o)
                                    .FirstOrDefault();
            if (user != null)
            {
                if (isDomain)
                {
                    bool domainchecked = false;
                    string domain = System.Configuration.ConfigurationManager.AppSettings["Domain"];
                    string aaa = System.Environment.UserDomainName;
                    string bbb = System.Environment.UserName;
                    WindowsImpersonationContext impersonationContext;
                    WindowsIdentity tempWindowsIdentity;
                    IntPtr token = IntPtr.Zero;
                    IntPtr tokenDuplicate = IntPtr.Zero;
                    if (LogonUser(name, domain, password, LOGON32_LOGON_INTERACTIVE, LOGON32_PROVIDER_DEFAULT, ref token) != 0)
                    {
                        if (DuplicateToken(token, 2, ref tokenDuplicate) != 0)
                        {
                            tempWindowsIdentity = new WindowsIdentity(tokenDuplicate);
                            impersonationContext = tempWindowsIdentity.Impersonate();
                            if (impersonationContext != null)
                            {
                                domainchecked = true;
                                return UserCheckResult.验证通过;
                            }
                        }
                    }
                    return UserCheckResult.用户密码错误;
                }
                else
                {

                    if (user.CheckPassword(password))
                    {
                        return UserCheckResult.验证通过;
                    }
                    else
                    {
                        if (logonFailedList.ContainsKey(name))
                        {
                            logonFailedList[name]++;
                        }
                        else
                        {
                            logonFailedList.Add(name, 1);
                        }
                        user = new SystemUser { Id = logonFailedList[name] };
                        return UserCheckResult.用户密码错误;
                    }
                }
            }
            else
            {
                return UserCheckResult.用户不存在;
            }



        }
    }
}
