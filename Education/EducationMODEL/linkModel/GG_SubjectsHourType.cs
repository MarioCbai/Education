﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.linkModel
{
    public class GG_SubjectsHourType//课时科目联查表
    {
        public int HourTypeId { get; set; }//课时主键

        public string HourTypeName { get; set; }//课时名称

        public int Sort { get; set; }//排序

        public decimal Proportion { get; set; }//课时比例

        public int Ztai { get; set; }//状态

        public int SubjectsId { get; set; }//科目主键

        public string SubjectsName { get; set; }//科目名称

        public int SHId { get; set; }//课时科目关系主键

        public int HourType { get; set; }//课时表（外键）

        public int Subjects { get; set; }//科目表（外键）

        public int SHState { get; set; }//状态
    }
}
