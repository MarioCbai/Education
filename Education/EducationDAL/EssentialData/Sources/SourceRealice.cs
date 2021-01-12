using EducationMODEL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.EssentialData.Sources
{
    //来源实现
    public class SourceRealice : Source
    {
        //来源表添加功能
        public override int SourceAdd(SourceMod s)
        {
            return DapperHelper.Execute("insert into Source values(@SourceName,@Sort,@Ztai)",s);
        }
        //来源表显示
        public override List<SourceMod> SourceShow()
        {
            return DapperHelper.Query<SourceMod>("select * from Source","");
        }

        public override int SourceUpt(SourceMod s)
        {
            return DapperHelper.Execute("update Source set SourceName=@SourceName,Sort=@Sort where SourceId=@SourceId", s);
        }

        public override int SourceZtai(int ztai, int id)
        {
            return DapperHelper.Execute("update Source set Ztai=@Ztai where SourceId=@SourceId",new { Ztai=ztai, SourceId =id});
        }
    }
}
