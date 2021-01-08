using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL
{
    public class SubjectsHourType//科目课时关系表
    {
        public int SHId { get; set; }//主键

        public int HourType { get; set; }//课时类型(外键)

        public int Subjects { get; set; }//科目(外键)
    }
}
