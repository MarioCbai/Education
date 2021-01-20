using EducationDAL.AuthorityManagement;
using EducationDAL.AuthorityManagement.Permissions;
using EducationDAL.AuthorityManagement.RolePermissions;
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
        //添加角色
        public int AddPart(PartMod dt)
        {
            int permission = authoritys.Role().AddPart(dt);
            return permission;
        }

        //角色权限状态
        public void CPState(int id, int val)
        {
            Role ss = authoritys.Role();
            ss.RoleState(id, val);
        }

        //角色删除
        public int DelPart(int id)
        {
            Role role = authoritys.Role();
            return role.DelPart(id);
        }

        //全部角色
        public List<PartMod> PartShow()
        {
            Role permission = authoritys.Role();
            return permission.PartShow();
        }

        //角色查询
        public List<PartMod> PartShow(string PartName = "", string PMState = "")
        {
            Role role = authoritys.Role();
            return role.GetParts(PartName, PMState);
        }

        //角色状态修改
        public void PartState(int id, int val)
        {
            Role role = authoritys.Role();
            role.PartState(id,val);
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
        //查询用户表
        public  List<ConsumerMod> Register1(string ConsumerIPhone)
        {
            return authoritys.User().Register1(ConsumerIPhone);
        }

        //忘记密码/修改
        public int RetrievePassword(string ConsumerIPhone, string ConsumerPwd)
        {
            return authoritys.User().RetrievePassword(ConsumerIPhone, ConsumerPwd);
        }
        //角色查看
        public PartMod SelPart(int id)
        {
            Role role = authoritys.Role();
            return role.PartSel(id);
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
        /// <summary>
        /// 角色修改
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int UptPart(PartMod p)
        {
            Role role = authoritys.Role();
            return role.UptPart(p);
        }

        /// <summary>
        /// 用户角色修改
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public int UptUserPart(UserPardMod u)
        {
            UserRoles user = authoritys.UserRoles();
            return user.UptUserPart(u);
        }

        //用户角色添加
        public int UserAdd(UserPardMod u)
        {
            UserRoles user = authoritys.UserRoles();
            return user.UserAdd(u);
        }

        /// <summary>
        /// 用户角色查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserPardMod UserPartSel(int id)
        {
            UserRoles user = authoritys.UserRoles();
            return user.UserPartSel(id);
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
        public int UserPartShows(string name, string Iphone, string PartName, string State, DateTime? StartTime, DateTime? EndTime)
        {
            UserRoles user = authoritys.UserRoles();
            string sname = name;
            return user.UserPartShows(sname,Iphone,PartName,State,StartTime, EndTime);
        }

        //用户的全部显示
        public List<ConsumerMod> UserShow()
        {
             
            throw new NotImplementedException();
        }
    }
}
