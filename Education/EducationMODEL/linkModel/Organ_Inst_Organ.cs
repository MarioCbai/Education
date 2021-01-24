using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.linkModel
{
    public class Organ_Inst_Organ//机构类型+机构递归+机构账户
    {
        public string InstitutionalName { get; set; }//机构类型名称

        public int OrganizationId { get; set; }//主键

        public string OrganizationCode { get; set; }//机构代码

        public int OrganId { get; set; }//机构表（外键）

        public decimal OrganizationMoney { get; set; }//账户金额

        public string OrganizationRemark { get; set; }//备注

        public string OrganName { get; set; }//机构名称

        public int AauditId { get; set; }//机构审核表id
        public string AauditName { get; set; }//审核人
        public DateTime AauditDateTiem { get; set; }//审核时间
        public int AauditZtai { get; set; }//审核状态

        public DateTime time { get; set; }
    }
}
