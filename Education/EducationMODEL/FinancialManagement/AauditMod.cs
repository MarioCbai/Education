using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.FinancialManagement
{
    public class AauditMod//财务管理 //机构充值审核表
    {
        public int AauditId { get; set; }//主键

        public string AauditName { get; set; }//充值人姓名

        public DateTime AauditDateTiem { get; set; }//充值时间

        public decimal CPrice { get; set; }//充值金额

        public decimal AauditLimit { get; set; }//充值额度

        public int AauditZtai { get; set; }//审核状态

        public string SHerName { get; set; }//审核人

        public DateTime SHerDatetiem { get; set; }//审核时间

        public string BeiZu { get; set; }//备注

        public int OrganizationId { get; set; }//机构账户表（外键）

        public string time { get; set; }

    }
}
