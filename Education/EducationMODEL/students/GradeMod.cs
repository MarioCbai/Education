using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.students
{
    public class GradeMod//成绩表
    {
        public int GradeId { get; set; }//主键

        public DateTime GradeDate { get; set; }//考试时间

        public string GradeType { get; set; }//考试类型表小测验、期中考试、期末考试、中考、高考

        public decimal GradeMark { get; set; }//成绩

        public int StudentId { get; set; }//学员外键

        public int SubjectsId { get; set; }//学科
    }
}
