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
        //教师类别显示
        public abstract List<TeacherTypeMod> TeacherSortShow();

        //教师类别添加
        public abstract int TeacherSortAdd(TeacherTypeMod t);

        //教师类别编辑
        public abstract int TeacherSortUpt(TeacherTypeMod t);

        //教师类别状态修改
        public abstract int TeacherSortZtai(int ztai, int id);

        //教师类别表根据id查询反填
        public abstract TeacherTypeMod TeacherSortSelectById(int id);
    }
}
