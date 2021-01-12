using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.Infrastructure
{
    public class TeachinglevelMod//教师水平级别管理表
    {
        public int LevelId { get; set; }//主键

        public string LeveName { get; set; }//教师级别名称

        public int Sort { get; set; }//排序

        public int Ztai { get; set; }//状态

    }
}
