using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.students
{
    public class Textbook//教材表
    {
        public int TextbookId { get; set; }//主键

        public string TextbookName { get; set; }//版本名称

        public int StID { get; set; }//学段

        public int SubjectsId { get; set; }//学科
    }
}
