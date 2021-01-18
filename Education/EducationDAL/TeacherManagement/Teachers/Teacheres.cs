using EducationMODEL.TeacherManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.TeacherManagement.Teachers
{
    //教师方法声明
    public abstract class Teacheres
    {
        //教师管理显示
        public abstract List<TeachMod> GetTeaches();
    }
}
