using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.Infrastructure
{
    public class HourTypeMod//课时类型管理表
    {
        public int HourTypeId { get; set; }//主键

        public string HourTypeName { get; set; }//课时类别名称

        public int Sort { get; set; }//排序

        public decimal Proportion { get; set; }//课时比例

        public int Ztai { get; set; }//状态
    }
}
