using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages.Html;
using Common.Utilities;

namespace OUDAL
{
    public class UserBLL
    {

        static public List<SystemUser> Users;
        static UserBLL()
        {
            UpdateUsers();
        }
        public static void UpdateUsers()
        {
            using (Context db = new Context())
            {
                Users = (from o in db.SystemUsers.AsNoTracking() where o.State != 1 select o).ToList();
            }
        }
        public static SystemUser GetById(int id)
        {
            return Users.Find(o => o.Id == id);
        }


        public static List<SystemUser> AllSystemUsers()
        {
            if (Users == null)
            {
                UpdateUsers();
            }
            return Users;
        }
         
        public static List<SystemUser> GetByRole(string rolename)
        {
            List<SystemUser> _users = new List<SystemUser>();
            //NetCacheHelper
            string cacheKey = "GetByRole_" + rolename;
            List<SystemUser> users = NetCacheHelper.Get<List<SystemUser>>(cacheKey);
            if (users == null)
            {
                using (Context db = new Context())
                {
                    _users = (from o in db.SystemUsers
                              join r in db.RoleUsers on o.Id equals r.UserId
                              join role in db.Roles on r.RoleId equals role.Id
                              where role.Name.Contains(rolename) && o.State != 1
                              select o).ToList();
                }
                NetCacheHelper.Add(cacheKey, _users, DateTime.Now.AddHours(10));
            }
            else
            {
                _users = users;
            }
            return _users;
        }
        public static List<SystemUser> GetByRole(string rolename, string area)
        {
            List<SystemUser> _users = new List<SystemUser>();
            //NetCacheHelper
            string cacheKey = "GetByRole_" + rolename + area;
            List<SystemUser> users = NetCacheHelper.Get<List<SystemUser>>(cacheKey);
            if (users == null)
            {
                using (Context db = new Context())
                {
                    _users = (from o in db.SystemUsers
                              join r in db.RoleUsers on o.Id equals r.UserId
                              join role in db.Roles on r.RoleId equals role.Id
                              where role.Name.Contains(rolename) && role.Name.Contains(area) && o.State != 1
                              select o).ToList();
                }
                NetCacheHelper.Add(cacheKey, _users, DateTime.Now.AddHours(10));
            }
            else
            {
                _users = users;
            }
            return _users;
        }
        public static string GetNameById(int? id)
        {
            if (id == null) return "";
            SystemUser u = GetById((int)id);
            if (u == null) return "";
            return u.Name;
        }
        public static List<SelectListItem> GetUsers(int? defaultValue)
        {
            List<SelectListItem> list = new List<SelectListItem>();
            using (Context db = new Context())
            {
                var query = (from o in db.SystemUsers orderby o.LoginName select new { o.Id, Name = o.Name });

                foreach (dynamic o in query)
                {
                    list.Add(new SelectListItem { Text = o.Name, Value = o.Id.ToString(), Selected = defaultValue == o.Id });
                }
                return list;
            }
        }

        public static List<IdName> GetSales(Context db, int projectid)
        {
            List<IdName> list = new List<IdName>();

            var query =
                db.Database.SqlQuery<IdName>(
                    @"select u.id,u.name from systemusers u join roleusers ru on ru.userid=u.id
join rolefunctions rf on rf.roleid=ru.roleid join functions f on f.id=rf.functionid where f.ParentName='客户管理' and f.name='销售员'")
                    .ToList();
            var projectUsers = DepartmentBLL.GetDepartmentUsersIdNames(projectid);
            foreach (var idName in query)
            {
                foreach (var projectUser in projectUsers)
                {
                    if (projectUser.Id == idName.Id)
                    {
                        list.Add(idName);
                    }
                }
            }
            return list;
        }
    }
}