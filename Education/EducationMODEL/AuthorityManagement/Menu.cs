using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.AuthorityManagement
{
    public class Menu//权限表
    {
        public int MenuId { get; set; }//菜单id

        public string MenuName { get; set; }//权限名称

        public string MenuUrl { get; set; }//权限URL地址

        public int MenuCRUD { get; set; }//递归
    }
}
