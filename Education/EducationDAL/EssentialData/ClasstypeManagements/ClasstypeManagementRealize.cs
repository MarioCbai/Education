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
            return DapperHelper.Query<ClassModelMod_BusinessTypeMod>("select * from SubjectsHourType a join ClassModel b on a.SHId=b.ClassModelId join Subjects c on a.SHId=c.SubjectsId","");
        }

        public override int ClasstypeManagementUpt(ClassModelMod_BusinessTypeMod c)
        {
            return DapperHelper.Execute("update SubjectsHourType set HourTypeName=@HourTypeName,Sort=@Sort,Proportion=@Proportion where HourTypeId=@HourTypeId", c);
        }

        public override int ClasstypeManagementZtai(int ztai, int id)
        {
            throw new NotImplementedException();
        }
    }
}
