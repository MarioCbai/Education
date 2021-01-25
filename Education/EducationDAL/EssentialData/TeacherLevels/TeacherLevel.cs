using EducationMODEL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.EssentialData.TeacherLevels
{
    //教师水平管理
    public abstract class TeacherLevel
    {
        //教师水平增删改查
        //教师水平表显示
        public abstract List<TeachinglevelMod> TeacherLevelShow();

        //教师水平表添加
        public abstract int TeacherLevelAdd(TeachinglevelMod t);

        //教师水平表编辑
        public abstract int TeacherLevelUpt(TeachinglevelMod t);

        //教师水平表状态修改
        public abstract int TeacherLevelZtai(int ztai, int id);

        //来源表根据id查询反填
        public abstract TeachinglevelMod TeacherLevelSelectById(int id);

        public abstract List<TeachinglevelMod> TeacherModShow(string name);
    }
}
