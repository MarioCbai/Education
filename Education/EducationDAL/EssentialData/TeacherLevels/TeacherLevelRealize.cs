using EducationMODEL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.EssentialData.TeacherLevels
{
    //教师水平级别管理
    public class TeacherLevelRealize : TeacherLevel
    {
        //教师水平添加
        public override int TeacherLevelAdd(TeachinglevelMod t)
        {
            return DapperHelper.Execute("insert into Teachinglevel values(@LeveName,@Sort,@Ztai)", t);
        }
        //教师水平显示
        public override List<TeachinglevelMod> TeacherLevelShow()
        {
            return DapperHelper.Query<TeachinglevelMod>("select * from Teachinglevel", "");
        }
        //教师水平修改
        public override int TeacherLevelUpt(TeachinglevelMod t)
        {
            return DapperHelper.Execute("update Teachinglevel set LeveName=@LeveName,Sort=@Sort where LevelId=@LevelId", t);
        }
        //教师水平修改状态
        public override int TeacherLevelZtai(int ztai,int id)
        {
            return DapperHelper.Execute("update Teachinglevel set Ztai=@Ztai where LevelId=@LevelId", new { Ztai = ztai, LevelId = id });
        }
    }
}
