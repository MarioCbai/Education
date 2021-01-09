using EducationDAL.TeachingManagement.Applications;
using EducationDAL.TeachingManagement.Classrooms;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.TeachingManagement
{
    //教学管理工厂
    public class TeachingPlant : Teaching
    {
        //返还课
        public override Application Application()
        {
            return new ApplicationRealize();
        }

        //课堂管理
        public override Classroom Classroom()
        {
            return new ClassroomRealize();
        }
    }
}
