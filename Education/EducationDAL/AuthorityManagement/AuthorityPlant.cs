using EducationDAL.AuthorityManagement.Permissions;
using EducationDAL.AuthorityManagement.RolePermissions;
using EducationDAL.AuthorityManagement.Roles;
using EducationDAL.AuthorityManagement.UserRoleses;
using EducationDAL.AuthorityManagement.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.AuthorityManagement
{
    //权限工厂
    public class AuthorityPlant : Authority
    {
        //权限
        public override Permission Permission()
        {
            return new PermissionRealize();
        }

        //角色
        public override Role Role()
        {
            return new RoleRealize();
        }

        //角色权限
        public override RolePermission RolePermission()
        {
            return new RolePermissionRealize();
        }

        //用户
        public override User User()
        {
            return new UserRealize();
        }

        //用户角色
        public override UserRoles UserRoles()
        {
            return new UserRolesRealize();
        }
    }
}
