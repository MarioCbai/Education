using EducationMODEL.AuthorityManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.AuthorityManagement.Permissions
{
    //权限实现
    public class PermissionRealize : Permission
    {
        

        //权限树显示
        public override List<MenuMod> PermissionShow()
        {
            string sql = "select * from Menu where MenuCRUD = @i";
            List<MenuMod> menuMods = DapperHelper.Query<MenuMod>(sql, new {i=0 });
            foreach (var item in menuMods)
            {
               item.children = RecursionP(item.MenuId);
            }
            return menuMods;
        }
        //全部显示
        public override List<MenuMod> PermissionShowNT()
        {
            string sql = "select * from Menu";
            List<MenuMod> menuMods = DapperHelper.Query<MenuMod>(sql, new { });
            return menuMods;
        }
        //权限递归方法
        public List<MenuMod> RecursionP(int id)
        {
            string sql = "select * from Menu where MenuCRUD = @i";
            List<MenuMod> menuMods = DapperHelper.Query<MenuMod>(sql,new { i=id });
            foreach (var item in menuMods)
            {
                item.children = RecursionP(item.MenuId);
            }
            return menuMods;
        }
        //权限查询
        public override List<MenuMod> SelPermission(int id)
        {
            return DapperHelper.Query<MenuMod>("select * from Menu where MenuCRUD=@i", new { i = id });
        }
    }
}
