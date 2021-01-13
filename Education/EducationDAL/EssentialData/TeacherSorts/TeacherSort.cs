using EducationMODEL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.EssentialData.TeacherSorts
{
    //教师类别
    public abstract class TeacherSort
    {
        //教师类别增删改查声明
        //教师类显示
        public abstract List<TeacherTypeMod> TeacherSortShow();

        //教师类添加
        public abstract int TeacherSortAdd(TeacherTypeMod t);

        //教师类编辑
        public abstract int TeacherSortUpt(TeacherTypeMod t);

        //教师类状态修改
        public abstract int TeacherSortZtai(int ztai, int id);
    }
}
