﻿using EducationMODEL;
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
        //角色添加权限
        int AddPart(JueseP j);

        //角色修改
        int UptPart(PartMod p);

        //角色状态修改
        void PartState(int id, int val);

        //角色查询
       List<PartMod> PartShow(string PartName="",string PMState="");

        //角色查看
        PartMod SelPart(int id);

        //角色删除
        int DelPart(int id);

        //用户角色修改
        int UptUserPart(UserPardMod u);

        //用户角色查询
        UserPardMod UserPartSel(int id);
        //用户角色添加
        int UserAdd(UserPardMod u);

        //用户角色状态修改
        void State(int id,int val);
        //角色权限状态
        void CPState(int id, int val);

        //用户角色显示
        List<UserPardMod> UserPartShow(int PageIndex, int PageSize, string name, string Iphone, string PartName, string State, DateTime? StartTime, DateTime? EndTime);
        //用户数据总条数
        int UserPartShows(string name, string Iphone, string PartName, string State , DateTime? StartTime, DateTime? EndTime);

        //权限查询
        List<MenuMod> SelPermission(int id);

        //查询树权限
        List<MenuMod> PermissionShow();

        //权限全显示
        List<MenuMod> PermissionShowNT(string iphone);
        //全部角色
        List<PartMod> PartShow();
        //登录
        List<ConsumerMod> Register(string ConsumerIPhone, string ConsumerPwd);
        //查询用户名
        List<ConsumerMod> Register2(string ConsumerIPhone);
        //忘记密码,修改密码
        int RetrievePassword(string ConsumerIPhone, string ConsumerPwd);
        //添加角色
        int AddPart(PartMod dt);
        //查询用户表
        List<ConsumerMod> Register1(string ConsumerIPhone);
        //快速导航表显示
        List<QuickNavigation> QuickNavigation(string QuickIName);
        //添加快速导航
        int QuickNavigationadd(string title, string href, string QuickIName);
        //删除快速导航
        int QuickNavigationDel(string id);

    }
}
