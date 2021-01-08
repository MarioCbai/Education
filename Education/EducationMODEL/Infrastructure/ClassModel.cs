using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.Infrastructure
{
    public class ClassModel//班型管理表
    {
        public int ClassModelId { get; set; }//主键

        public string ClassModelName { get; set; }//班型名称

        public int BusinessTypeId { get; set; }//业务类型id（外键）

        public string ClassModels { get; set; }//进入课堂形式

        public int ClassModelNumber { get; set; }//容纳学员人数

        public int Sort { get; set; }//排序
    }
}
