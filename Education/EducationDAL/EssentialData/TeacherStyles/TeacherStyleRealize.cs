using EducationMODEL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.EssentialData.TeacherStyles
{
    //教师教学风格方法实现
    public class TeacherStyleRealize : TeacherStyle
    {
        //教师教学风格添加
        public override int TeacherStyleAdd(TeachingStyleMod t)
        {
            return DapperHelper.Execute("insert into TeachingStyle values(@TeachingStyleName,@Sort,@Ztai)", t);
        }
        //教师教学风格显示
        public override List<TeachingStyleMod> TeacherStyleShow()
        {
            return DapperHelper.Query<TeachingStyleMod>("select * from TeachingStyle", "");
        }
        //教师教学风格修改状态
        public override int TeacherStyleZtai(int ztai, int id)
        {
            return DapperHelper.Execute("update TeacherType set Ztai=@Ztai where TeachingStyleId=@TeachingStyleId", new { Ztai = ztai, TeachingStyleId = id });
        }
        //教师教学风格修改
        public override int TTeacherStyleUpt(TeachingStyleMod t)
        {
            return DapperHelper.Execute("update TeachingStyle set TeachingStyleName=@TeachingStyleName,Sort=@Sort where TeachingStyleId=@TeachingStyleId", t);
        }
    }
}
