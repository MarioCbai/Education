using EducationDAL.TeacherManagement;
using EducationMODEL.TeacherManagement;
using IEducation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationBLL
{
    //教师管理
    public class TeacherManagementBll: ITeacherManagement
    {
        Teacher teachers = new TeacherPlant();
        //教师管理显示
        public List<TeachMod> GetTeaches()
        {
            return teachers.Teacheres().GetTeaches();
        }
    }
}
