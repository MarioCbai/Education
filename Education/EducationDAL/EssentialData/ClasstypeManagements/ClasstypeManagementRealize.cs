using EducationMODEL.linkModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.EssentialData.ClasstypeManagements
{
    //班型管理表
    public class ClasstypeManagementRealize : ClasstypeManagement
    {
        //班型显示
        public override List<ClassModelMod_BusinessTypeMod> ClasstypeManagementShow()
        {
            return DapperHelper.Query<ClassModelMod_BusinessTypeMod>("select * from ClassModel a join BusinessType b on a.BusinessTypeId=b.BusinessTypeId order by Sort", "");
        }
    }
}
