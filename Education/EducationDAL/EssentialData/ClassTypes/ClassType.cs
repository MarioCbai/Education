using EducationMODEL.Infrastructure;
using EducationMODEL.linkModel;
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
        public abstract List<Subjects_HourT_Mod> ClassTypeShow();

        //课时表添加
        public abstract int ClassTypeAdd(HourTypeMod h);

        //课时表编辑
        public abstract int ClassTypeUpt(HourTypeMod h);

        //课时表状态修改
        public abstract int ClassTypeZtai(int ztai, int id);

        //课时表根据id查询反填
        public abstract HourTypeMod ClassTypeSelectById(int id);
    }
}
