using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.organizational
{
    public class HourTableMod//课时包表
    {
        public int HourId { get; set; }//主键

        public string HourName { get; set; }//课时包表名称

        public string BeginTime { get { return HourBeginTime.ToString("yyyy-MM-dd"); } set { HourBeginTime = Convert.ToDateTime(value); } }//课时包名称
        public string EngTime { get { return HourEngTime.ToString("yyyy-MM-dd"); } set { HourEngTime = Convert.ToDateTime(value); } }//课时包名称

        public DateTime HourBeginTime { get; set; }//课时包表有效期开始时间

        public DateTime HourEngTime { get; set; }//课时包表有效期结束时间
    }
}
