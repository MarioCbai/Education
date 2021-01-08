using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.students
{
    public class Callback//回访表
    {
        public int CallbackId { get; set; }//主键

        public DateTime CallbackDate { get; set; }//回访时间

        public int Callbackpeop { get; set; }//被回访人

        public string CallbackQuality { get; set; }//质量度ABCDEF

        public string CallbackContent { get; set; }//回访内容
    }
}
