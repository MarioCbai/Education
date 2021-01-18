using EducationMODEL.organizational;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.InstitutionManagement.OrganesTypes
{
    //机构类型增删改查
    public abstract class OrganesType
    {
        //绑定机构类型
        public abstract List<InstitutionalMod> GetInstitutionalMods();
    }
}
