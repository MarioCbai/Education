using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.FinancialManagement
{
    public class OrganizationMod//机构账户管理 --机构管理
    {
        public int OrganizationId { get; set; }//主键

        public string OrganizationCode { get; set; }//机构代码

        public int OrganId { get; set; }//机构表（外键）

        public decimal OrganizationMoney { get; set; }//账户金额

        public string OrganizationRemark { get; set; }//备注

    }
}
