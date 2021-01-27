using EducationMODEL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
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
        //教师风格根据id查询反填
        public override TeachingStyleMod TeacherStyleSelectById(int id)
        {
            return DapperHelper.Query<TeachingStyleMod>("select * from TeachingStyle where TeachingStyleId=@TeachingStyleId", new { TeachingStyleId = id }).FirstOrDefault();
        }

        //教师教学风格显示
        public override List<TeachingStyleMod> TeacherStyleShow()
        {
            return DapperHelper.Query<TeachingStyleMod>("select * from TeachingStyle order by Ztai,Sort", "");
        }

        public override List<TeachingStyleMod> TeacherStyleShowName(string name)
        {
            return DapperHelper.Query<TeachingStyleMod>("select * from TeachingStyle where TeachingStyleName=@TeachingStyleName", new { TeachingStyleName = name });
        }

        //教师教学风格修改状态
        public override int TeacherStyleZtai(int ztai,int id)
        {
            return DapperHelper.Execute("update TeachingStyle set Ztai=@Ztai where TeachingStyleId=@TeachingStyleId", new { Ztai = ztai, TeachingStyleId = id });
        }
        //删除
        public override int TTeacherStyleDelt(int id)
        {
            return DapperHelper.Execute("delete from TeachingStyle where TeachingStyleId=@TeachingStyleId",new { TeachingStyleId=id });
        }

        //教师教学风格修改
        public override int TTeacherStyleUpt(TeachingStyleMod t)
        {
            return DapperHelper.Execute("update TeachingStyle set TeachingStyleName=@TeachingStyleName,Sort=@Sort where TeachingStyleId=@TeachingStyleId", t);
        }
    }
}
