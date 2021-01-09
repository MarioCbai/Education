using System;
using System.Collections.Generic;
using System.Text;
using EducationDAL.StudentManagement.Callbacks;
using EducationDAL.StudentManagement.Evaluates;
using EducationDAL.StudentManagement.Grades;
using EducationDAL.StudentManagement.Parent;
using EducationDAL.StudentManagement.Schedulings;
using EducationDAL.StudentManagement.Studentes;

namespace EducationDAL.StudentManagement
{
    //学员管理
    public abstract class Student
    {
        /// <summary>
        /// 学员信息表
        /// </summary>
        /// <returns></returns>
        public abstract Students Students();

        /// <summary>
        /// 家长信息
        /// </summary>
        /// <returns></returns>
        public abstract Parents Parents();

        /// <summary>
        /// 排课信息
        /// </summary>
        /// <returns></returns>
        public abstract Scheduling Scheduling();

        /// <summary>
        /// 成绩
        /// </summary>
        /// <returns></returns>
        public abstract Grade Grade();
        /// <summary>
        /// 回访
        /// </summary>
        /// <returns></returns>
        public abstract Callback Callback();

        /// <summary>
        /// 评价
        /// </summary>
        /// <returns></returns>
        public abstract Evaluate Evaluate();





    }
}
