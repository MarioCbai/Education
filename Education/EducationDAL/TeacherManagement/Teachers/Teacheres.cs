﻿using EducationMODEL.TeacherManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.TeacherManagement.Teachers
{
    //教师方法声明
    public abstract class Teacheres
    {
        //教师管理显示
        public abstract List<TeachMod> GetTeaches();
        //教师管理显示1
        public abstract List<TeacherMod> GetTeacherMods();
        //添加教师管理信息
        public abstract int AddTeacherMod(TeacherMod t);
        //反填教师管理信息
        public abstract TeacherMod ModifyIdTeacherMod(int id);
        //修改教师管理信息
        public abstract int ModifyTeacherMod(TeacherMod teacher);
        //修改教师管理状态
        public abstract int ModifyTeacherState(int status, int id);
        //删除教师管理信息
        public abstract int DeleteTeacherMod(int ids);
        /// <summary>
        /// 教师信息显示
        /// </summary>
        /// <returns></returns>
        public abstract List<TeacherMod> TeacherShow();

    }
}
