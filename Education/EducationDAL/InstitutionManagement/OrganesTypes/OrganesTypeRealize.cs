using EducationMODEL.organizational;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.InstitutionManagement.OrganesTypes
{
    //机构类型方法实现
    public class OrganesTypeRealize: OrganesType
    {
        //绑定机构类型
        public override List<InstitutionalMod> GetInstitutionalMods()
        {
            return DapperHelper.Query<InstitutionalMod>("select InstitutionalId,InstitutionalName from Institutional", " ");
            //select org.OrganId,ins.InstitutionalId  from Organ org join Institutional ins on org.InstitutionalId = ins.InstitutionalId
        }
    }
}
