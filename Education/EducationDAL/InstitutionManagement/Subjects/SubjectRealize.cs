using EducationMODEL.organizational;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.InstitutionManagement.Subjects
{
    //科目表实现
    public class SubjectRealize : Subject
    {
        //科目表显示
        public override List<SubjectsMod> GetSubjects()
        {
            return DapperHelper.Query<SubjectsMod>("select *from Subjects", "");
        }
    }
}
