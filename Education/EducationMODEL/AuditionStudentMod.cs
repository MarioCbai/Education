using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL
{
    public class AuditionStudentMod//试听课学生关系表
    {
        public int ASID { get; set; }//主键id

        public int Audition { get; set; }//课程表（外键）

        public int Student { get; set; }//学生表（外键）
        public DateTime AuditTime { get; set; }//审核时间
    }
}
