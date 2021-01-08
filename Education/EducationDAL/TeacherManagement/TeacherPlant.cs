using System;
using System.Collections.Generic;
using System.Text;
using EducationDAL.TeacherManagement.Teachers;

namespace EducationDAL.TeacherManagement
{
    //教师管理
    public class TeacherPlant : Teacher
    {
        public override Teacheres Teacheres()
        {
            return new TeacheresRealize();
        }
    }
}
