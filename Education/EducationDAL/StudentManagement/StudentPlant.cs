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
    public class StudentPlant : Student
    {
        //回访
        public override Callback Callback()
        {
            return new CallbackRealize();
        }
        //评价
        public override Evaluate Evaluate()
        {
            return new EvaluateRealize();
        }

        //成绩
        public override Grade Grade()
        {
            return new GradeRealize();
        }


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
