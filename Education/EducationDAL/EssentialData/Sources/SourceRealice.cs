using EducationMODEL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
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
        //来源表根据id查询反填
        public override SourceMod SourceSelectById(int id)
        {
            return DapperHelper.Query<SourceMod>("select * from Source where SourceId=@SourceId",new { SourceId=id}).FirstOrDefault();
        }

        //来源表显示
        public override List<SourceMod> SourceShow(string name = null)
        {
            string sql = "select* from Source where 1=1";
            if (!string.IsNullOrEmpty(name))
            {
                sql += " and SourceName like concat('%',@SourceName,'%')";
            }
            return DapperHelper.Query<SourceMod>(sql,new { SourceName=name });
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
