﻿using EducationDAL.TeacherManagement;
using EducationMODEL.TeacherManagement;
using IEducation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationBLL
{
    //教师管理
    public class TeacherManagementBll: ITeacherManagement
    {
        Teacher teachers = new TeacherPlant();
        #region 教师管理
        //教师管理显示
        public List<TeachMod> GetTeaches(string teaname, string phone, int jigou, int sub, int bookid, int state)
        {
            return teachers.Teacheres().GetTeaches(teaname, phone, jigou, sub, bookid, state);
        }
        //教师管理显示1
        public  List<TeacherMod> GetTeacherMods(string teaname, string phone, int jigou, int tduid)
        {
            return teachers.Teacheres().GetTeacherMods(teaname, phone, jigou, tduid);
        }
        //添加教师管理信息
        public int AddTeacherMod(TeacherMod t)
        {
            return teachers.Teacheres().AddTeacherMod(t);
        }
        //删除教师管理信息
        public int DeleteTeacherMod(int ids)
        {
            return teachers.Teacheres().DeleteTeacherMod(ids);
        }
        //反填教师管理信息
        public TeacherMod ModifyIdTeacherMod(int teacherid)
        {
            return teachers.Teacheres().ModifyIdTeacherMod(teacherid);
        }
        //修改教师管理信息
        public int ModifyTeacherMod(TeacherMod t)
        {
            return teachers.Teacheres().ModifyTeacherMod(t);
        }
        //修改教师管理状态
        public int ModifyTeacherState(int status, int teaid)
        {
            return teachers.Teacheres().ModifyTeacherState(status, teaid);
        }
        #endregion
        #region 教学基本信息
        //教学基本信息显示
        public List<TeachMod> GetTeachMods()
        {
            return teachers.TeachingInformation().GetTeachMods();
        }
        //教学基本信息新增
        public int AddTeachMod(TeachMod tea)
        {
            return teachers.TeachingInformation().AddTeachMod(tea);
        }
        //教学基本信息反填
        public TeachMod ModifyIdTeachMod(int id)
        {
            return teachers.TeachingInformation().ModifyIdTeachMod(id);
        }
        //教学基本信息修改
        public int ModifyTeachMod(TeachMod tea)
        {
            return teachers.TeachingInformation().ModifyTeachMod(tea);
        }
        //教学基本信息删除
        public int DeleteTeachMod(int ids)
        {
            return teachers.TeachingInformation().DeleteTeachMod(ids);
        }
        #endregion
        #region 认证信息
        //认证信息显示
        public List<ApproveMod> GetApproveMods()
        {
            return teachers.Credentials().GetApproveMods();
        }
        //认证信息添加
        public int AddApproveMod(ApproveMod ap)
        {
            return teachers.Credentials().AddApproveMod(ap);
        }
        //认证信息的反填
        public ApproveMod ModifyIdApproveMod(int id)
        {
            return teachers.Credentials().ModifyIdApproveMod(id);
        }
        //认证信息的修改
        public int ModifyApproveMod(ApproveMod ap)
        {
            return teachers.Credentials().ModifyApproveMod(ap); 
        }

        /// <summary>
        /// 教师显示
        /// </summary>
        /// <returns></returns>
        public List<TeacherMod> TeacherShow(int jibie, int leibie, string iphone, string name)
        {
            return teachers.Teacheres().TeacherShow( jibie,  leibie,  iphone,  name);
        }
        #endregion
        #region 学历管理
        //学历表
        public List<TeachereducationMod> GetTeachereducations()
        {
            return teachers.Teacheres().GetTeachereducations();
        }
        #endregion

    }
}
