using System;
using System.Collections.Generic;
using System.Text;
using EducationDAL.StudentManagement.Parent;
using EducationDAL.StudentManagement.Schedulings;
using EducationDAL.StudentManagement.Studentes;

namespace EducationDAL.StudentManagement
{
    //学员管理
    public class StudentMessage : Student
    {
        //家长信息
        public override Parents Parents()
        {
            return new ParentsRealize();
        }
        //排课信息
        public override Scheduling Scheduling()
        {
            return new SchedulingRealize();
        }

        //学员信息管理
        public override Students Students()
        {
            return new StudentsRealize();
        }
    }
}
