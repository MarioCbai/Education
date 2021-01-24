using EducationMODEL.organizational;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.InstitutionManagement.Semesters
{
    //学期表实现
    public class SemesterRealize:Semester
    {
        //学期表显示
        public override List<SemesterMod> GetSemesters()
        {
            return DapperHelper.Query<SemesterMod>("select *from Semester", "");
        }
    }
}
