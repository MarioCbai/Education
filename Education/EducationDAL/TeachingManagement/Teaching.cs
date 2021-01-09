using EducationDAL.TeachingManagement.Applications;
using EducationDAL.TeachingManagement.Classrooms;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.TeachingManagement
{
    //教学管理工厂类
    public abstract class Teaching
    {
        /// <summary>
        /// 课堂管理
        /// </summary>
        /// <returns></returns>
        public abstract Classroom Classroom();
        /// <summary>
        /// 返还课
        /// </summary>
        /// <returns></returns>
        public abstract Application Application();
    }
}
