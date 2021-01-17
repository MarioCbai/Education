using EducationMODEL;
using EducationMODEL.AuthorityManagement;
using EducationMODEL.linkModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace IEducation
{
    //权限管理
    public interface IAuthorityManagement
    {
        //用户角色添加
        int UserAdd(UserPardMod u);

        //用户角色状态修改
        void State(int id,int val);
        //用户角色显示
        List<UserPardMod> UserPartShow(int PageIndex, int PageSize, string name, string Iphone, string PartName, string State, DateTime? StartTime, DateTime? EndTime);
        //用户数据总条数
        int UserPartShows(string name, string Iphone, string PartName, string State , DateTime? StartTime, DateTime? EndTime);

        //权限查询
        List<MenuMod> SelPermission(int id);

        //查询树权限
        List<MenuMod> PermissionShow();

        //权限全显示
        List<MenuMod> PermissionShowNT();
        //全部角色
        List<PartMod> PartShow();
        //登录
        List<ConsumerMod> Register(string ConsumerIPhone, string ConsumerPwd);






    }
}
