using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.students
{
    public class AuditTableMod//学员余额表
    {
        public int AuditTableId { get; set; }//主键id

        public decimal AuditTableLimit { get; set; }//额度

        public decimal AuditTableBalance { get; set; }//余额

        public int Student { get; set; }//学员表外键

    }
}
