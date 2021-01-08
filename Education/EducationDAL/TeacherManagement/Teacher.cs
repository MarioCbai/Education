using System;
using System.Collections.Generic;
using System.Text;
using EducationDAL.TeacherManagement.Teachers;

namespace EducationDAL.TeacherManagement
{
    //老师管理
    public abstract class Teacher
    {
        /// <summary>
        /// 教师表
        /// </summary>
        public abstract Teacheres Teacheres();
    }
}
