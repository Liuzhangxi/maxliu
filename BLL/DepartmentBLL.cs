﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.WebPages.Html;
using Common.Utilities;

namespace OUDAL
{

    public class DepartmentBLL
    {
        static Context db = new Context();
        static public List<Department> Departments;
        public static List<DepartmentUser> DepartmentUsers;
        public static DepartmentTree Root;
        static DepartmentBLL()
        {
            UpdateDepartments();
        }

        static void addDepartmentUser(ref List<int> userList, int  did)
        {
            List<DepartmentUser> subDeUsers = DepartmentUsers.Where(sub => sub.DepartmentId == did).ToList();

            foreach (var td in subDeUsers)
            {
                if (userList.All(s => s != td.UserId))
                {
                    userList.Add(td.UserId);
                }
            } 
        }
        /// <summary>
        /// 当前输入部门下所有子部门员工id获取
        /// </summary>
        /// <param name="userList"></param>
        /// <param name="did"></param>
        static void addSubDepartmentUser(ref List<int> userList, int did)
        {
            List<Department> departments = Departments.Where(dp => dp.PId == did).ToList();
            addDepartmentUser(ref userList, did);
            foreach (var dp in departments) 
            {
                addSubDepartmentUser(ref userList, dp.Id); 
            }
        }
        /// <summary>
        /// 获取当前用户的所有附属用户(包括自己)
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static List<int> GetSubSystemUsers(int userId)
        {
            List<int> retDepartmentUsers = new List<int>();
            List<DepartmentUser> departmentUsers = DepartmentUsers.Where(d => d.UserId == userId).ToList();
            departmentUsers.ForEach(d =>
            {
                if (!retDepartmentUsers.Any(s => s == d.UserId))
                {
                    retDepartmentUsers.Add(d.UserId);
                }
            });  
            departmentUsers.ForEach(d =>
            {
                if (d.IsManager == 1)
                {
                    //是经理
                    //db.SystemUsers 当前部门下用户
                    //addDepartmentUser(ref retDepartmentUsers, d.DepartmentId); 
                    //子部门下用户
                    addSubDepartmentUser(ref retDepartmentUsers, d.DepartmentId); 

                }
            }); 

            return retDepartmentUsers;
        }

        public static void UpdateDepartments()
        {
            Departments = (from o in db.Departments.AsNoTracking() select o).ToList();
            DepartmentUsers = (from o in db.DepartmentUsers.AsNoTracking() select o).ToList();
            foreach (var department in Departments)
            {
                if (department.PId == 0)
                {
                    Root = new DepartmentTree { Node = department };
                    AddChildren(Root);
                    break;
                }
            }
        }

        static void AddChildren(DepartmentTree node)
        {
            if (node.Children == null) node.Children = new List<DepartmentTree>();
            foreach (var department in Departments)
            {
                if (department.PId == node.Node.Id)
                {
                    var child = new DepartmentTree { Node = department };
                    node.Children.Add(child);
                    AddChildren(child);
                }
            }
        }
        public static Department GetById(int id)
        {
            return Departments.Find(o => o.Id == id);
        }
        public static Department GetByName(string dename)
        {
            return Departments.Find(o => o.Name == dename);
        }
        public static string GetNameById(int id)
        {
            Department d = GetById(id);
            if (d == null) return "";
            return d.Name;
        }
        static List<UserName> GetUserNames(int id)
        {
            var query = from o in db.SystemUsers.AsNoTracking()
                        join p in db.DepartmentUsers on o.Id equals p.UserId
                        where p.DepartmentId == id
                        select o;
            return (from o in query select new UserName { Department = GetNameById(id), id = o.Id, Name = o.Name }).ToList();
        }
        /// <summary>
        /// 当前节点下，不含子节点
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<IdName> GetUsers(int id)
        {
            var query = from o in db.SystemUsers.AsNoTracking()
                        join p in db.DepartmentUsers on o.Id equals p.UserId
                        where p.DepartmentId == id
                        select o;
            return (from o in query select new IdName() { Id = o.Id, Name = o.Name }).ToList();
        }
        static void GetManager(List<UserName> managers, int departmentId, int userid, string departmenttype)
        {

            var q1 = from o in DepartmentUsers
                     where o.DepartmentId == departmentId && o.UserId == userid && o.IsManager == 1
                     select o;
            if (q1.Count() > 0)//在本部门是经理
            {
                Department d = GetById(departmentId);
                if (d.PId == 0) return;
                GetManager(managers, d.PId, userid, departmenttype);
            }
            else
            {
                var query = from o in DepartmentUsers where o.DepartmentId == departmentId select o;
                bool found = false;
                foreach (var du in query)
                {
                    if (du.IsManager == 1)
                    {
                        managers.Add(new UserName { Department = GetNameById(du.DepartmentId), id = du.UserId, Name = UserBLL.GetNameById(du.UserId) });
                        found = true;
                    }
                }
                if (found == false)
                {
                    Department d = GetById(departmentId);
                    if (d.PId == 0) return;
                    GetManager(managers, d.PId, userid, "");
                }
            }
        }
        static public List<UserName> GetManagers(int userid)
        {
            List<UserName> managers = new List<UserName>();
            var query = from o in DepartmentUsers where o.UserId == userid select o;
            foreach (var departmentUser in query)
            {
                GetManager(managers, departmentUser.DepartmentId, userid, "");
            }
            return managers;
        }
        static public List<UserName> GetManagers(int userid, string departmenttype)
        {
            List<UserName> managers = new List<UserName>();
            var query = from o in DepartmentUsers where o.UserId == userid select o;
            foreach (var departmentUser in query)
            {
                GetManager(managers, departmentUser.DepartmentId, userid, departmenttype);
            }
            return managers;
        }
        static public List<string> GetUserDepartments(int userid)
        {
            List<string> list = new List<string>();
            DepartmentUsers.ForEach(o =>
                {
                    if (o.UserId == userid)
                    {
                        list.Add(GetNameById(o.DepartmentId));
                    }
                });
            return list;
        }
        static public List<string> GetUserDepartments(int userid, string departmenttype)
        {
            List<string> list = new List<string>();
            DepartmentUsers.ForEach(o =>
            {
                if (o.UserId == userid)
                {
                    Department dept = GetById(o.DepartmentId);
                    if (departmenttype == "" || dept.DepartmentType.Contains(departmenttype)) list.Add((dept.Name));
                }
            });
            return list;
        }
        public static string GetUserDepartmentString(int userid)
        {
            string s = "";
            GetUserDepartments(userid).ForEach(o => s += ("" + o));
            return s;
        }
        static void list_findchildren(List<SelectListItem> list, Department parent, int level, int selectValue)
        {
            string pre = "";
            for (int i = 0; i < level; i++) pre += "　";
            list.Add(new SelectListItem { Value = parent.Id.ToString(), Text = pre + parent.Name, Selected = (selectValue == parent.Id) });
            Departments.ForEach(o =>
            {
                if (o.PId == parent.Id) list_findchildren(list, o, level + 1, selectValue);
            });
        }
        static void _GetDeptString(List<int> list, int id)
        {
            Departments.ForEach(o =>
            {
                if (o.PId == id)
                {
                    list.Add(o.Id);
                    _GetDeptString(list, o.Id);
                }
            });
        }
        /// <summary>
        /// 获取部门及子部门，用,分开
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        static public string GetDeptString(int i)
        {
            List<int> list = new List<int>();
            _GetDeptString(list, i);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(i);
            list.ForEach(o => { sb.Append(","); sb.Append(o); });
            return sb.ToString();
        }
        static public bool IsParnet(int idp, int idc)
        {
            Department d = GetById(idc);
            if (d.PId == idp) return true;
            if (d.PId == 0) return false;
            return IsParnet(idp, d.PId);
        }

        static public List<int> GetUserManageDepartment(int userid)
        {
            List<int> departments = new List<int>();
            List<int> result = new List<int>();
            DepartmentUsers.ForEach(o =>
            {
                if (o.UserId == userid && o.IsManager == 1) departments.Add(o.DepartmentId);
            });
            foreach (int id in departments)
            {
                bool canadd = true;
                for (int i = 0; i < result.Count; i++)
                {
                    if (IsParnet(id, result[i]))//如果是父级节点则替换 
                    { result[i] = id; canadd = false; }
                    else
                    {
                        if (IsParnet(result[i], id))//有上下级关系
                        {
                            canadd = false;
                        }

                    }
                }
                if (canadd) result.Add(id);
            }
            return result;

        }
        static public List<SelectListItem> GetDepartmentList(int deptid)
        {
            List<SelectListItem> list = new List<SelectListItem>();

            Department root = null;
            if (deptid > 0)
            {
                root = (from o in Departments where o.Id == deptid select o).First();
            }
            else
            {
                root = Departments.First();
            }
            list_findchildren(list, root, 0, 0);
            return list;
        }
        static public List<SelectListItem> GetDepartmentList(List<int> deptids)
        {
            List<SelectListItem> list = new List<SelectListItem>();
            foreach (int deptid in deptids)
            {
                Department root = (from o in Departments where o.Id == deptid select o).First();
                list_findchildren(list, root, 0, 0);
            }
            return list;
        }
        static void list_findchildren(List<Department> list, Department parent)
        {
            list.Add(parent);
            Departments.ForEach(o =>
            {
                if (o.PId == parent.Id) list_findchildren(list, o);
            });
        }
        static public List<Department> GetDepartmentByParent(int deptid)
        {
            List<Department> list = new List<Department>();
            if (deptid == 0) deptid = 1;
            Department root = (from o in Departments where o.Id == deptid select o).First();
            list_findchildren(list, root);
            return list;
        }
        static public List<Department> GetDepartmentByParent(List<int> deptids)
        {
            List<Department> list = new List<Department>();
            foreach (int deptid in deptids)
            {
                Department root = (from o in Departments where o.Id == deptid select o).First();
                list_findchildren(list, root);
            }
            return list;
        }
        static public List<SelectListItem> GetDepartmentByType(int deptid)
        {
            List<Department> list = new List<Department>();
            string type = db.Departments.Find(deptid).DepartmentType;
            list = (from o in db.Departments where o.DepartmentType == type select o).ToList();
            List<SelectListItem> res = new List<SelectListItem>();
            foreach (Department d in list)
            {
                res.Add(new SelectListItem { Selected = (d.Id == deptid), Value = d.Id.ToString(), Text = d.Name });
            }
            return res;
        }


        static public List<SelectListItem> GetDepartmentByType(int pid, int deptid)
        {
            List<Department> list = new List<Department>();
            string type = db.Departments.Find(deptid).DepartmentType;
            list = (from o in db.Departments where o.DepartmentType == type && o.PId == pid select o).ToList();
            List<SelectListItem> res = new List<SelectListItem>();
            foreach (Department d in list)
            {
                res.Add(new SelectListItem { Selected = (d.Id == deptid), Value = d.Id.ToString(), Text = d.Name });
            }
            return res;
        }

        static public List<SelectListItem> GetDepartmentByType(string type)
        {
            List<Department> list = new List<Department>();
            list = (from o in db.Departments where o.DepartmentType == type select o).ToList();
            List<SelectListItem> res = new List<SelectListItem>();
            foreach (Department d in list)
            {
                res.Add(new SelectListItem { Selected = false, Value = d.Id.ToString(), Text = d.Name });
            }
            return res;
        }
        static public List<Department> GetDepartments(string type)
        {

            List<Department> list = new List<Department>();
            list = Departments.Where(d => d.DepartmentType == type).ToList();

            //string cacheKey = "GetDepartments"+type; 
            //List<Department> departments = NetCacheHelper.Get<List<Department>>(cacheKey);
            //if (departments != null)
            //    return departments; 
            //using (Context ct = new Context())
            //{
            //    list = (from o in ct.Departments where o.DepartmentType == type select o).ToList();
            //    NetCacheHelper.Add(cacheKey, list,DateTime.Now.AddMinutes(15));
              
            //}
            return list;
        }


        static public List<Department> GetGroupsByPid(int deptid)
        {
            List<Department> list = (from o in db.Departments where o.PId == deptid && o.DepartmentType == "小组" select o).ToList();
            return list;
        }

        static DepartmentTree FindNode(int deptid, DepartmentTree parent)
        {
            if (parent.Node.Id == deptid) return parent;
            foreach (var node in parent.Children)
            {
                var found = FindNode(deptid, node);
                if (found != null) return found;
            }
            return null;
        }

        static void InsertUsers(List<IdName> returnValue, DepartmentTree node)
        {
            foreach (var user in DepartmentUsers)
            {
                if (node.Node.Id == user.DepartmentId)
                {
                    bool found = false;
                    foreach (var idName in returnValue)
                    {
                        if (idName.Id == user.UserId) found = true;
                    }
                    if (!found) returnValue.Add(new IdName { Id = user.UserId, Name = UserBLL.GetNameById(user.UserId) });
                }
                foreach (var subNode in node.Children)
                {
                    InsertUsers(returnValue, subNode);
                }
            }
        }
        static public List<IdName> GetDepartmentUsersIdNames(int deptid)
        {
            List<IdName> list = new List<IdName>();
            DepartmentTree node = FindNode(deptid, Root);
            if (node != null)
            {
                InsertUsers(list, node);
            }
            return list;
        }
    }

    public class DepartmentTree
    {
        public Department Node { get; set; }
        public List<DepartmentTree> Children { get; set; }
    }
}