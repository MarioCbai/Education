using EducationMODEL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.EssentialData.PriceLevels
{
    //价格级别管理
    public abstract class PriceLevel
    {
        //价格级别管理增删改查
        //价格级别添加
        public abstract List<PriceRankMod> PriceLevelShow();

        //价格级别表添加
        public abstract int PriceLevelAdd(PriceRankMod p);

        //价格级别表编辑
        public abstract int PriceLevelUpt(PriceRankMod p);

        //价格级别表状态修改
        public abstract int PriceLevelZtai(int ztai, int id);
    }
}
