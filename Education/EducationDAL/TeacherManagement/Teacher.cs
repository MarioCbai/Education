using System;
using System.Collections.Generic;
using System.Text;
using EducationDAL.TeacherManagement.Credentialses;
using EducationDAL.TeacherManagement.Teachers;
using EducationDAL.TeacherManagement.TeachingInformations;
using EducationMODEL.TeacherManagement;

namespace EducationDAL.TeacherManagement
{
    //老师管理
    public abstract class Teacher
    {
        /// <summary>
        /// 教师基本信息表
        /// </summary>
        public abstract Teacheres Teacheres();
        /// <summary>
        /// 教学信息
        /// </summary>
        /// <returns></returns>
        public abstract TeachingInformation TeachingInformation();
        /// <summary>
        /// 认证信息
        /// </summary>
        /// <returns></returns>
        public abstract Credentials Credentials();

   
    }
}
