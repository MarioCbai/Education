using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.TeachingManagement
{
    public class FAFSAMod//退课申请表//返还课
    {
        public int AuditionID { get; set; }//主键id

        public int CourseId { get; set; }//排课申请表id

        public int ASID { get; set; }//试听课学生关系表 

        public int Dropclasstype { get; set; }//1 退课  2返还课
    }
}
