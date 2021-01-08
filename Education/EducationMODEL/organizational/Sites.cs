using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.organizational
{
    public class Sites//省市区地址表
    {
        public int SiID { get; set; }//主键
        public string SitesName { get; set; }//地址名称
        public int SitesId { get; set; }//父级id

    }
}
