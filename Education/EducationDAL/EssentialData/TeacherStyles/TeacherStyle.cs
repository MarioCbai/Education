using EducationMODEL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.EssentialData.TeacherStyles
{
    //教师风格管理
    public abstract class TeacherStyle
    {
        //教师风格管理增删改

        //教师风格显示
        public abstract List<TeachingStyleMod> TeacherStyleShow();

        //教师风格添加
        public abstract int TeacherStyleAdd(TeachingStyleMod t);

        //教师风格编辑
        public abstract int TTeacherStyleUpt(TeachingStyleMod t);

        //教师风格状态修改
        public abstract int TeacherStyleZtai(int ztai, int id);

        //教师风格根据id查询反填
        public abstract TeachingStyleMod TeacherStyleSelectById(int id);
    }
}
