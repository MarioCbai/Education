using EducationMODEL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.EssentialData.ClassTypes
{
    //课时类型的实现
    public class ClassTypeRealize : ClassType
    {
        //课时表添加
        public override int ClassTypeAdd(HourTypeMod h)
        {
            return DapperHelper.Execute("insert into HourType values(@HourTypeName,@Sort,@Proportion,@Ztai)", h);
        }
        //课时表显示
        public override List<HourTypeMod> ClassTypeShow()
        {
            return DapperHelper.Query<HourTypeMod>("select * from SubjectsHourType a join ClassModel b on a.SHId=b.ClassModelId join Subjects c on a.SHId=c.SubjectsId", "");
        }
        //课时表修改
        public override int ClassTypeUpt(HourTypeMod h)
        {
            return DapperHelper.Execute("update SubjectsHourType set HourType=@HourType,Subjects=@Subjects where HourTypeId=@HourTypeId", h);
        }
        //课时表的修改状态
        public override int ClassTypeZtai(int ztai, int id)
        {
            return DapperHelper.Execute("update HourType set Ztai=@Ztai where HourTypeId=@HourTypeId", new { Ztai = ztai, HourTypeId = id });
        }
    }
}
