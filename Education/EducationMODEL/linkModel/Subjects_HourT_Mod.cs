using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.linkModel
{
   public class Subjects_HourT_Mod//课时类型+科目+学科
    {
        public int PricingId { get; set; }//主键id

        public int PriceRankId { get; set; }//价格级别管理（外键）

        public int ClassModelId { get; set; }//班型管理（外键）

        public int StID { get; set; }//学段 外键

        public int HourTypeId { get; set; }//课时类别管理（外键）

        public int PriceReigth { get; set; }

        public int PriceLefght { get; set; }

        public int PricingPrice { get; set; }//课时单价
        public string PriceRankName { get; set; }//价格级别
        public string ClassModelName { get; set; }//班型名称
        public string StudyName { get; set; }  //学段年级名称
        public string HourTypeName { get; set; }//课时类别名称
    }
}
