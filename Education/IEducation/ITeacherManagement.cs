using EducationMODEL.linkModel;
using EducationMODEL.TeacherManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace IEducation
{
    //教师管理
    public interface ITeacherManagement
    {
        //教学管理显示
        List<TeachMod> GetTeaches();

    

    }
}
