using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.Infrastructure
{
    public class TeacherType//教师类别管理
    {
        public int TeacherTypeId { get; set; }//主键Id

        public string TeacherTypeName { get; set; }//教师类别名称

        public int Sort { get; set; }//排序

        public int Ztai { get; set; }//状态
    }
}
