using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.AuthorityManagement
{
    public class MenuMod//权限表
    {
        public int MenuId { get; set; }//菜单id
        public int id { get { return MenuId; } }
        public string MenuName { get; set; }//权限名称
        public string title { get { return MenuName; } }//权限名称
        public string MenuUrl { get; set; }//权限URL地址
        public string href { get { return MenuUrl; } }//url地址
        public int MenuCRUD { get; set; }//递归
        public int pId { get { return  MenuCRUD; } }

        public int value { get { return MenuId; } }
        public List<MenuMod> children { get; set; }//子节点数据
    }
}
