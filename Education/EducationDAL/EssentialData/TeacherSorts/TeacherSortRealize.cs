using EducationMODEL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EducationDAL.EssentialData.TeacherSorts
{
    //教师类别方法实现
    public class TeacherSortRealize : TeacherSort
    {
        //教师类别添加
        public override int TeacherSortAdd(TeacherTypeMod t)
        {
            return DapperHelper.Execute("insert into TeacherType values(@TeacherTypeName,@Sort,@Ztai)", t);
        }
        //教师类别表根据id查询反填
        public override TeacherTypeMod TeacherSortSelectById(int id)
        {
            return DapperHelper.Query<TeacherTypeMod>("select * from TeacherType where TeacherTypeId=@TeacherTypeId", new { TeacherTypeId = id }).FirstOrDefault();
        }

        //教师类别显示
        public override List<TeacherTypeMod> TeacherSortShow()
        {
            return DapperHelper.Query<TeacherTypeMod>("select * from TeacherType order by Ztai,Sort", "");
        }

        public override List<TeacherTypeMod> TeacherShow(string name)
        {
            return DapperHelper.Query<TeacherTypeMod>("select * from TeacherType where TeacherTypeName=@TeacherTypeName",new { TeacherTypeName =name});
        }

        //教师类别修改
        public override int TeacherSortUpt(TeacherTypeMod t)
        {
            return DapperHelper.Execute("update TeacherType set TeacherTypeName=@TeacherTypeName,Sort=@Sort where TeacherTypeId=@TeacherTypeId", t);
        }
        //状态修改
        public override int TeacherSortZtai(int ztai, int id)
        {
            return DapperHelper.Execute("update TeacherType set Ztai=@Ztai where TeacherTypeId=@TeacherTypeId", new { Ztai = ztai, TeacherTypeId = id });
        }
    }
}
