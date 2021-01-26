using EducationMODEL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EducationDAL.EssentialData.PriceLevels
{
    //价格级别管理实现
    public class PriceLevelRealize : PriceLevel
    {
        
        //价格级别添加
        public override int PriceLevelAdd(PriceRankMod p)
        {
           
            return DapperHelper.Execute("insert into PriceRank values(@PriceRankName,@Sort,@Ztai)", p);
        }
        //删除
        public override int PriceLevelDelt(int id)
        {
            return DapperHelper.Execute("delete from  PriceRank  where PriceRankId=@PriceRankId",new { PriceRankId =id});
        }


        //价格级别表根据id查询反填
        public override PriceRankMod PriceLevelSelectById(int id)
        {
            return DapperHelper.Query<PriceRankMod>("select * from PriceRank where PriceRankId=@PriceRankId", new { PriceRankId = id }).FirstOrDefault();
        }

        //价格级别显示
        public override List<PriceRankMod> PriceLevelShow()
        {
            return DapperHelper.Query<PriceRankMod>("select * from PriceRank order by Ztai,Sort", "");
        }

        public override List<PriceRankMod> PriceLevelShowName(string name)
        {
            return DapperHelper.Query<PriceRankMod>("select * from PriceRank where PriceRankName=@PriceRankName", new { PriceRankName = name });
        }

        //价格级别修改
        public override int PriceLevelUpt(PriceRankMod p)
        {
            return DapperHelper.Execute("update PriceRank set PriceRankName=@PriceRankName,Sort=@Sort where PriceRankId=@PriceRankId", p);
        }
        //价格级别修改状态
        public override int PriceLevelZtai(int ztai, int id)
        {
            return DapperHelper.Execute("update PriceRank set Ztai=@Ztai where PriceRankId=@PriceRankId", new { Ztai = ztai, PriceRankId = id });
        }
    }
}
