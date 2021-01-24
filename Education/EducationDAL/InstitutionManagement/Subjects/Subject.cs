using EducationMODEL.organizational;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.InstitutionManagement.Subjects
{
    //科目
    public abstract class Subject
    {
        //科目表增删改查
        //科目表显示
        public abstract List<SubjectsMod> GetSubjects();
    }
}
