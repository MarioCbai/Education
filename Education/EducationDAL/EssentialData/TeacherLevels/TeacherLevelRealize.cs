using EducationMODEL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
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
        //删除
        public override int TeacherLevelDelt(int id)
        {
            return DapperHelper.Execute("delete from Teachinglevel where LevelId=@LevelId",new { LevelId =id});
        }

        //教师水平表根据id查询反填
        public override TeachinglevelMod TeacherLevelSelectById(int id)
        {
            return DapperHelper.Query<TeachinglevelMod>("select * from Teachinglevel where LevelId=@LevelId", new { LevelId = id }).FirstOrDefault();
        }

        //教师水平显示
        public override List<TeachinglevelMod> TeacherLevelShow()
        {
            return DapperHelper.Query<TeachinglevelMod>("select * from Teachinglevel order by Ztai,Sort", "");
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

        public override List<TeachinglevelMod> TeacherModShow(string name)
        {
            return DapperHelper.Query<TeachinglevelMod>("select * from Teachinglevel where LeveName=@LeveName", new { LeveName = name });
        }
    }
}
