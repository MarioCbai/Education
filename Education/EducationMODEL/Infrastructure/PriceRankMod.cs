using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.Infrastructure
{
    public class PriceRankMod//价格级别管理表
    {
        public int PriceRankId { get; set; }//主键

        public string PriceRankName { get; set; }//价格级别

        public int Sort { get; set; }//排序

        public int Ztai { get; set; }//状态
}
}
