using EducationDAL.AuthorityManagement;
using EducationDAL.AuthorityManagement.Permissions;
using EducationDAL.AuthorityManagement.Roles;
using EducationDAL.AuthorityManagement.UserRoleses;
using EducationDAL.AuthorityManagement.Users;
using EducationMODEL;
using EducationMODEL.AuthorityManagement;
using EducationMODEL.linkModel;
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

        //全部角色
        public List<PartMod> PartShow()
        {
            Role permission = authoritys.Role();
            return permission.PartShow();
        }

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
        //登录
        public List<ConsumerMod> Register(string ConsumerIPhone, string ConsumerPwd)
        {
            return authoritys.User().Register(ConsumerIPhone, ConsumerPwd);
        }

        //查询权限
        public List<MenuMod> SelPermission(int id)
        {
            Permission permission = authoritys.Permission();
            return permission.SelPermission(id);
        }

        //权限状态的修改
        public void State(int id,int val)
        {
            UserRoles user = authoritys.UserRoles();
            user.State(id,val);
        }

        //用户角色添加
        public List<ConsumerMod> UserPartAdd()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 用户角色显示分页
        /// </summary>
        /// <returns></returns>
        public List<UserPardMod> UserPartShow(int PageIndex, int PageSize,string name, string Iphone, string PartName, string State, DateTime? StartTime, DateTime? EndTime)
        {
            UserRoles user = authoritys.UserRoles();
            return user.UserPartShow(PageIndex, PageSize, name, Iphone, PartName, State, StartTime, EndTime);
        }
        /// <summary>
        /// 用户角色总条数
        /// </summary>
        /// <returns></returns>
        public int UserPartShows()
        {
            UserRoles user = authoritys.UserRoles();
            return user.UserPartShows();
        }

        //用户的全部显示
        public List<ConsumerMod> UserShow()
        {
             
            throw new NotImplementedException();
        }
    }
}
