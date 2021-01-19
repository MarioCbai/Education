using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.AuthorityManagement
{
    public class PartMod//角色表
    {
        public int PartId { get; set; }//角色id

        public string PartName { get; set; }//角色名称

        public string PartDescribe { get; set; }//角色描述
        public int PMState { get; set; }        //状态
        public DateTime  PCreateTime { get; set; }//创建时间
        public string  date { get; set; }
        public string  Zhuang { get; set; }
    }
}
