using System;
using System.Collections.Generic;
using System.Text;
using EducationDAL.StudentManagement.Parent;
using EducationDAL.StudentManagement.Schedulings;
using EducationDAL.StudentManagement.Studentes;

namespace EducationDAL.StudentManagement
{
    //学员管理
    public abstract class Student
    {
        //学员信息表
        public abstract Students Students();

        //家长信息
        public abstract Parents Parents();

        //排课信息
        public abstract Scheduling Scheduling();
    }
}
