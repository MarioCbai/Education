using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.linkModel
{
   public class ClassModelMod_BusinessTypeMod//班型与业务类型--关系表
    {
        public int BusinessTypeId { get; set; }//主键

        public string BusinessTypeName { get; set; }//业务类型名称

        public int ClassModelId { get; set; }//主键

        public string ClassModelName { get; set; }//班型名称

        public string ClassModels { get; set; }//进入课堂形式

        public int ClassModelNumber { get; set; }//容纳学员人数

        public int Sort { get; set; }//排序
    }
}
