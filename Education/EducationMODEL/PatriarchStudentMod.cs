using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL
{
    public class PatriarchStudentMod//家长学员关系表
    {
        public int PSID { get; set; }//主键

        public int Patriarch { get; set; }//家长外键

        public int Student { get; set; }//学员外键
    }
}
