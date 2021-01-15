using EducationMODEL.AuthorityManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace IEducation
{
    //权限管理
    public interface IAuthorityManagement
    {
        //用户显示
        List<ConsumerMod> UserShow();

        //权限查询
        List<MenuMod> SelPermission(int id);

        //查询树权限
        List<MenuMod> PermissionShow();

        //权限全显示
        List<MenuMod> PermissionShowNT();
        //登录
        List<ConsumerMod> Register(string ConsumerIPhone, string ConsumerPwd);

    }
}
