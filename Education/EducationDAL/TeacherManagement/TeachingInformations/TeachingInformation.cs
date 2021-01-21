using EducationMODEL.TeacherManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.TeacherManagement.TeachingInformations
{
    //教学基本信息方法声明
    public abstract class TeachingInformation
    {
        //增删改查
        //教学基本信息显示
        public abstract List<TeachMod> GetTeachMods();
        //教学基本信息新增
        public abstract int AddTeachMod(TeachMod tea);
        //教学基本信息反填
        public abstract TeachMod ModifyIdTeachMod(int id);
        //教学基本信息修改
        public abstract int ModifyTeachMod(TeachMod tea);
        //教学基本信息删除
        public abstract int DeleteTeachMod(int ids);
    }
}
