using EducationDAL.AuthorityManagement;
using EducationDAL.AuthorityManagement.Permissions;
using EducationDAL.AuthorityManagement.Users;
using EducationMODEL.AuthorityManagement;
using IEducation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationBLL
{
    //权限管理全部方法
    public class AuthorityManagementBll: IAuthorityManagement
    {
        Authority authoritys = new AuthorityPlant();

        //权限菜单的树显示
        public List<MenuMod> PermissionShow()
        {
            Permission permission = authoritys.Permission();
            return permission.PermissionShow();
        }
        //权限菜单显示
        public List<MenuMod> PermissionShowNT()
        {
            Permission permission = authoritys.Permission();
            return  permission.PermissionShowNT();
        }

        //查询权限
        public List<MenuMod> SelPermission(int id)
        {
            Permission permission = authoritys.Permission();
            return permission.SelPermission(id);
        }

        //用户的全部显示
        public List<ConsumerMod> UserShow()
        {
             
            throw new NotImplementedException();
        }
    }
}
