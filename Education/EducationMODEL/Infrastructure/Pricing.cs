using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.Infrastructure
{
    public class Pricing//定价管理表
    {
        public int PricingId { get; set; }//主键Id

        public int PriceRankId { get; set; }//价格级别管理（外键）

        public int ClassModelId { get; set; }//班型管理（外键）

        public int StID { get; set; }//学段 外键

        public int HourTypeId { get; set; }//课时类别管理（外键）

        public int PricingPrice { get; set; }//课时单价
    }
}
