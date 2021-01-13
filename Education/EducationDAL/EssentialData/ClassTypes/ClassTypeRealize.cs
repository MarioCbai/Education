using EducationMODEL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.EssentialData.ClassTypes
{
    //课时类型的实现
    public class ClassTypeRealize : ClassType
    {
        public override int ClassTypeAdd(HourTypeMod h)
        {
            return DapperHelper.Execute("insert into HourTypeMod values(@HourTypeName,@Sort,@Proportion,@Ztai)", h);
        }

        public override List<HourTypeMod> ClassTypeShow()
        {
            return DapperHelper.Query<HourTypeMod>("select * from HourTypeMod", "");
        }

        public override int ClassTypeUpt(HourTypeMod h)
        {
            return DapperHelper.Execute("update HourTypeMod set HourTypeName=@HourTypeName,Sort=@Sort,Proportion=@Proportion where HourTypeId=@HourTypeId",h);
        }

        public override int ClassTypeZtai(int ztai, int id)
        {
            return DapperHelper.Execute("update HourTypeMod set Ztai=@Ztai where HourTypeId=@HourTypeId", new { Ztai = ztai, HourTypeId = id });
        }
    }
}
