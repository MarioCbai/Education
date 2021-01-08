using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.Infrastructure
{
    public class TeachingStyle//教师教学风格管理表
    {
        public int TeachingStyleId { get; set; }//主键Id

        public string TeachingStyleName { get; set; }//教师风格名称

        public int Sort { get; set; }//排序

        public int Ztai { get; set; }//状态
}
}
