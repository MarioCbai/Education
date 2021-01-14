using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.TeachingManagement
{
    public class DropClassMod//退课申请表
    {
        public int DCId				 { get; set; }              
        public int ASID				 { get; set; }               //课堂管理
        public int OrganId				 { get; set; }           //机构表
        public string  AuditorDrop			 { get; set; }       //审核人
        public DateTime AuditorDropdateTime { get; set; }        //审核时间
    }
}
