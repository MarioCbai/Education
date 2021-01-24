using EducationMODEL;
using EducationMODEL.Infrastructure;
using EducationMODEL.linkModel;
using EducationMODEL.organizational;
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
        public override int ClassTypeAdd(SubjectsHourTypeMod h)
        {
            return DapperHelper.Execute("insert into SubjectsHourType values(@HourType,@Subjects,@SHState)", h);
        }
        //查询科目表绑定下拉
        public override List<SubjectsMod> ClassTypeSelectAll()
        {
            return DapperHelper.Query<SubjectsMod>("select * from Subjects","");
        }

        //课时表根据id查询反填
        public override SubjectsHourTypeMod ClassTypeSelectById(int id)
        {
            return DapperHelper.Query<SubjectsHourTypeMod>("select * from SubjectsHourType where SHId=@SHId", new { SHId = id }).FirstOrDefault();
        }

        //课时表显示
        public override List<IGHourType_Subjects> ClassTypeShow()
        {
            return DapperHelper.Query<IGHourType_Subjects>("select a.*,b.SubjectsName,c.HourTypeName,c.Proportion,c.Sort from SubjectsHourType a join Subjects b on a.Subjects=b.SubjectsId join HourType c on a.HourType=c.HourTypeId order by a.SHState,c.Sort ", "");
        }
        //课时表修改
        public override int ClassTypeUpt(SubjectsHourTypeMod h)
        {
            return DapperHelper.Execute("update SubjectsHourType set HourType=@HourType,Subjects=@Subjects where SHId=@SHId", h);
        }
        //课时表的修改状态
        public override int ClassTypeZtai(int ztai, int id)
        {
            return DapperHelper.Execute("update SubjectsHourType set SHState=@SHState where SHId=@SHId", new { SHState = ztai, SHId = id });
        }
        //查询课时表绑定下拉
        public override List<HourTypeMod> HourTypeSelectAll()
        {
            return DapperHelper.Query<HourTypeMod>("select * from HourType", "");
        }
    }
}
