using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.TeachingManagement
{
    public class FAFSAMod  //返还课
    {
        public int AuditionID { get; set; }//主键id

        public string Auditor { get; set; }//审核人

        public int ASID { get; set; }//试听课学生关系表 

        public string AuditorPTime { get; set; }//审核时间

        public int AuditStatus { get; set; }//审核状态
        public string FAFSAremark { get; set; } //备注
        public string FAFStype { get; set; } //申请类型
        public string Audittime { get; set; }  //申请时间
    }
}
