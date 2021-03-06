﻿using EducationMODEL;
using EducationMODEL.Infrastructure;
using EducationMODEL.linkModel;
using EducationMODEL.organizational;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.EssentialData.ClassTypes
{
    //课时类型
    public abstract class ClassType
    {
        //课时类型增删改查
        //课时表显示
        public abstract List<GG_SubjectsHourType> ClassTypeShow(string name=null,int xk=0,int ? bl=null);

        //课时表添加
        public abstract int ClassTypeAdd(SubjectsHourTypeMod h);

        //课时表编辑
        public abstract int ClassTypeUpt(SubjectsHourTypeMod h);

        //课时表状态修改
        public abstract int ClassTypeZtai(int ztai, int id);
        //删除
        public abstract int ClassTypeDelt(int id);
        //课时表根据id查询反填
        public abstract GG_SubjectsHourType ClassTypeSelectById(int id);

        //查询科目表绑定下拉
        public abstract List<SubjectsMod> ClassTypeSelectAll();

        //查询课时表绑定下拉
        public abstract List<HourTypeMod> HourTypeSelectAll();

        //查询学科表绑定下拉
        public abstract List<SubjectsMod> SubjectsSelectAll();
    }
}
