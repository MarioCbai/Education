using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.TeachingManagement
{
    public class ConfuciusMod//课堂管理表
    {
        public int ClassroomId { get; set; }//主键id

        public int AuditionID { get; set; }//排课表外键 

        public int ASID { get; set; }//试听课学生关系表 

    }
}
