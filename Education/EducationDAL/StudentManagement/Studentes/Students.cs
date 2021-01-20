﻿using EducationMODEL.Infrastructure;
using EducationMODEL.linkModel;
using EducationMODEL.organizational;
using EducationMODEL.students;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.StudentManagement.Studentes
{
    //学员增删改查 声明
    public abstract class Students
    {
        //意向学员方法的声明
        public abstract List<StudentLian> StudentShow(int jigou, string zi, string  zhi, int nian, string name, string iphone);

        //来源显示
        public abstract List<SourceMod> LaiShow();

        //学员添加
        public abstract int StudentAdd(StudentMod s);

        //地址
        public abstract List<SitesMod> Dizhi(int id);
    }
}
