using EducationMODEL.organizational;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.InstitutionManagement.Semesters
{
    //学期方法声明
    public abstract class Semester
    {
        //增删改查
        //学期表显示
        public abstract List<SemesterMod> GetSemesters();
        
    }
}
