using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.TeachingManagement
{
    public class DropClassMod//退课申请表
    {
        public int DCId { get; set; }
        public int ASID { get; set; }
        public int OrganId { get; set; }
        public string AuditorDrop { get; set; }
        public string AuditorDropdateTime { get; set; }
        public string Remark { get; set; }
        public bool DropClassstate { get; set; }
        public string proposer { get; set; }
        public decimal AmountActually { get; set; }
        public int OrderId { get; set; }
      
    }
}
