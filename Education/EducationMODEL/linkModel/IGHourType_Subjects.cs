using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.linkModel
{
   public class IGHourType_Subjects
    {
        public int SHId { get; set; }//主键

        public int HourType { get; set; }//课时类型(外键)

        public int Subjects { get; set; }//科目(外键)

        public int HourTypeId { get; set; }//主键

        public string HourTypeName { get; set; }//课时类别名称

        public int Sort { get; set; }//排序

        public decimal Proportion { get; set; }//课时比例

        public int Ztai { get; set; }//状态

        public int SubjectsId { get; set; }//主键

        public int SHState { get; set; }//状态

        public string SubjectsName { get; set; }//科目名称
    }
}
