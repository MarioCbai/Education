using EducationMODEL.linkModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.EssentialData.ClasstypeManagements
{
    //课型管理表
    public class ClasstypeManagementRealize : ClasstypeManagement
    {
        public override int ClasstypeManagementAdd(ClassModelMod_BusinessTypeMod c)
        {
            return DapperHelper.Execute("insert into ClassModelMod values(@ClassModelName,@BusinessTypeId,@ClassModels,@ClassModelNumber,@Ztai)", c);
        }

        public override List<ClassModelMod_BusinessTypeMod> ClasstypeManagementShow()
        {
            return DapperHelper.Query<ClassModelMod_BusinessTypeMod>("select * from ClassModelMod a join BusinessTypeMod b on a.BusinessTypeId=b.BusinessTypeId", "");
        }

        public override int ClasstypeManagementUpt(ClassModelMod_BusinessTypeMod c)
        {
            
        }

        public override int ClasstypeManagementZtai(int ztai, int id)
        {
            throw new NotImplementedException();
        }
    }
}
