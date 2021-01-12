using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.students
{
    public class RechargeMod//充值金额表
    {
        public int RechargeId { get; set; }//主键

        public decimal RechargePrice { get; set; }//充值金额

        public DateTime RechargeStratDate { get; set; }//充值时间

        public int RechargeAudit { get; set; }//审核

        public DateTime RechargeStatrtDate { get; set; }//审核时间

        public string RechargeRemark { get; set; }//备注

        public int Student { get; set; }//学员表外键
    }
}
