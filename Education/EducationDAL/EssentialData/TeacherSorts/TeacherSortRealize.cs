using EducationMODEL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.EssentialData.TeacherSorts
{
    //教师类别方法实现
    public class TeacherSortRealize : TeacherSort
    {
        //教师类别添加
        public override int TeacherSortAdd(TeacherTypeMod t)
        {
            return DapperHelper.Execute("insert into TeacherTypeMod values(@TeacherTypeName,@Sort,@Ztai)", t);
        }
        //教师类别显示
        public override List<TeacherTypeMod> TeacherSortShow()
        {
            return DapperHelper.Query<TeacherTypeMod>("select * from TeacherTypeMod", "");
        }
        //教师类别修改
        public override int TeacherSortUpt(TeacherTypeMod t)
        {
            return DapperHelper.Execute("update TeacherTypeMod set TeacherTypeName=@TeacherTypeName,Sort=@Sort where TeacherTypeId=@TeacherTypeId", t);
        }
        //状态修改
        public override int TeacherSortZtai(int ztai, int id)
        {
            return DapperHelper.Execute("update TeacherTypeMod set Ztai=@Ztai where TeacherTypeId=@TeacherTypeId", new { Ztai = ztai, TeacherTypeId = id });
        }
    }
}
