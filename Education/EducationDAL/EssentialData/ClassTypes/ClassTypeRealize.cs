using EducationMODEL.Infrastructure;
using EducationMODEL.linkModel;
using System;
using System.Collections.Generic;
using System.Linq;
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
        //课时表根据id查询反填
        public override HourTypeMod ClassTypeSelectById(int id)
        {
            return DapperHelper.Query<HourTypeMod>("select * from HourType where HourTypeId=@HourTypeId", new { HourTypeId = id }).FirstOrDefault();
        }

        //课时表显示
        public override List<Subjects_HourT_Mod> ClassTypeShow()
        {
            return DapperHelper.Query<Subjects_HourT_Mod>("select * from SubjectsHourType a join Subjects b on a.Subjects=b.SubjectsId join HourType c on a.HourType=c.HourTypeId", "");
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
