using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL
{
    public class StudentTeacherMod//学员教师关系表
    {
        public int STId { get; set; }//主键

        public int Student { get; set; }//学员表（外键）

        public int Teacher { get; set; }//教师表（外键）
    }
}
