using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.Infrastructure
{
    public class Source//来源管理表
    {
        public int SourceId { get; set; }//主键Id

        public string SourceName { get; set; }//来源名称

        public int Sort { get; set; }//排序

        public int Ztai { get; set; }//状态

    }
}
