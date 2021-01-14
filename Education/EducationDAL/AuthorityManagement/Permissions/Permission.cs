using EducationMODEL.AuthorityManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.AuthorityManagement.Permissions
{
    //权限
    public abstract class Permission
    {
        //权限的树显示
        public abstract List<MenuMod> PermissionShow();
        //全部显示
        public abstract List<MenuMod> PermissionShowNT();
        //权限查询
        public abstract List<MenuMod> SelPermission(int id);
    }
}
