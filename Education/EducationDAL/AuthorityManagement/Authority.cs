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
    //权限工厂类
    public abstract class Authority
    {
        /// <summary>
        /// 用户
        /// </summary>
        /// <returns></returns>
        public abstract User User();

        /// <summary>
        /// 角色
        /// </summary>
        /// <returns></returns>
        public abstract Role Role();

        /// <summary>
        /// 用户角色
        /// </summary>
        /// <returns></returns>
        public abstract UserRoles UserRoles();

        /// <summary>
        /// 权限
        /// </summary>
        /// <returns></returns>
        public abstract Permission Permission();

        /// <summary>
        /// 角色权限
        /// </summary>
        /// <returns></returns>
        public abstract RolePermission RolePermission();


    }
}
