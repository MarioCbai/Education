using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL
{
    public class PartMenu//角色权限关系表
    {
        public int PartMenuId { get; set; }//主键id

        public int PartMenuPartId { get; set; }//角色表外键

        public int PartMenuMenuId { get; set; }//菜单表外键
    }
}
