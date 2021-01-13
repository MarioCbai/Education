using EducationMODEL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.EssentialData.ClassTypes
{
    //课时类型
    public abstract class ClassType
    {
        //课时类型增删改查
        //来源表显示
        public abstract List<HourTypeMod> ClassTypeShow();

        //来源表添加
        public abstract int ClassTypeAdd(HourTypeMod h);

        //来源表编辑
        public abstract int ClassTypeUpt(HourTypeMod h);

        //来源表状态修改
        public abstract int ClassTypeZtai(int ztai, int id);
    }
}
