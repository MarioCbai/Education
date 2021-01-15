using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.OrderManagement
{
    public class Study   //学段年级循环表
    {
        public int StID { get; set; }
        public string StudyName { get; set; }  //学段年级名称
        public int StudyId { get; set; }   //父级编号
    }
}
