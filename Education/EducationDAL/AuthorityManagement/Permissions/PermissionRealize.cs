using EducationMODEL;
using EducationMODEL.AuthorityManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EducationDAL.AuthorityManagement.Permissions
{
    //权限实现
    public class PermissionRealize : Permission
    {

        string u = "";
        int i = 0;
        //全部显示
        public override List<MenuMod> PermissionShowNT(string iphone)
        {
            string ss="";
            List<qq>list =DapperHelper.Query<qq>("select d.PartMenuMenuId from PartMenu d where PartMenuPartId in(select a.Part from ConsumerPart a join Consumer c on a.Consumer=c.ConsumerId where c.ConsumerIPhone=@iphone)",new { iphone});
            foreach (var item in list)
            {
                string vv = dgui(item.PartMenuMenuId);
                ss += item.PartMenuMenuId.ToString()+","+vv ;
                i = 0;
            }
            u = "";
            ss = ss+"1";
            string[] ids = new string[] { };
            ids = ss.Split(",");
            string sql = "select * from Menu where MenuId in @id";
            List<MenuMod> menuMods = DapperHelper.Query<MenuMod>(sql, new { id=ids });
            return menuMods;
        }

        //查询递归键
        public string  dgui(int id)
        {
           List<MenuMod> list= DapperHelper.Query<MenuMod>("select * from Menu where MenuId=@id", new { id });
            foreach (var item in list)
            {
                if (item.MenuCRUD!=0)
                {
                    i++;
                    u += item.MenuCRUD.ToString()+",";
                    dgui(item.MenuCRUD);
                }
            }
            return u;
        }

     


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
