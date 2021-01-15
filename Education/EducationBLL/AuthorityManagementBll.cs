﻿using EducationDAL.AuthorityManagement;
using EducationDAL.AuthorityManagement.Permissions;
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
        public List<UserPardMod> UserPartShow(int PageIndex=1, int PageSize=2)
        {
            UserRoles user = authoritys.UserRoles();
            return user.UserPartShow(PageIndex, PageSize);
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
