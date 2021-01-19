﻿using EducationMODEL.organizational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EducationDAL.InstitutionManagement.Organs
{
    //机构表实现
    public class OrganRealize:Organes
    {
        //机构管理显示
        public override List<OrganMod> GetOrganMods()
        {
            return DapperHelper.Query<OrganMod>("select org.OrganName as aa,* from Organ org join Organ b on org.OrganId=b.PId  join Institutional ins on org.InstitutionalId = ins.InstitutionalId join PriceRank pri on org.PriceRankId = pri.PriceRankId join Sites pro on pro.SiID = org.ProvinceId join Sites city on city.SiID = org.City join Sites dis on dis.SiID = org.District", " ");
        }

        //添加机构管理信息
        public override int AddOrganes(OrganMod organ)
        {
            var result = DapperHelper.Execute("insert into Organ values(@OrganEncod,@OrganName,@InstitutionalId,@PriceRankId,@OrganPhoneName,@OrganPhone,@ProvinceId,@City,@District,@OrganRemark,@OrganStatus,@OrganBeginTime,@PId,@OrganAddress)",
            new { organ.OrganEncod, organ.OrganName, organ.InstitutionalId, organ.PriceRankId, organ.OrganPhoneName, organ.OrganPhone, organ.ProvinceId, organ.City, organ.District, organ.OrganRemark, organ.OrganStatus, organ.OrganBeginTime, organ.PId, organ.OrganAddress });
            return result;
        }
        //反填机构管理信息
        public override OrganMod ModiyIdOrganes(int orgid)
        {
            return DapperHelper.Query<OrganMod>("select *from Organ where OrganId=@OrganId", new { OrganId = orgid }).FirstOrDefault();
        }
        //修改机构管理信息
        public override int ModiyOrganes(OrganMod organ)
        {
            var result = DapperHelper.Execute("update Organ set OrganEncod=@OrganEncod,OrganName=@OrganName,InstitutionalId=@InstitutionalId,OrganPhoneName=@OrganPhoneName,OrganPhone=@OrganPhone,ProvinceId=@ProvinceId,City=@City,District=@District,OrganRemark=@OrganRemark,PId=@PId where OrganId=@OrganId",
            new { organ.OrganEncod, organ.OrganName, organ.InstitutionalId, organ.OrganPhoneName, organ.OrganPhone, organ.ProvinceId, organ.City, organ.District, organ.OrganRemark, organ.PId, organ.OrganId });
            return result;
        }
        //单删除机构管理信息
        public override int DeleteOrganes(int ids)
        {
            return DapperHelper.Execute("delete from Organ where OrganId=@OrganId", new { OrganId = ids });
        }
        ////反填机构管理状态
        //public override OrganMod ModiyIdStates(int orgids)
        //{
        //    return DapperHelper.Query<OrganMod>("select *from Organ where OrganId=@OrganId", new { OrganId = orgids }).FirstOrDefault();
        //}
        //修改机构管理状态
        public override int ModiyStates(int status,int orgid)
        {
            return DapperHelper.Execute("update Organ set OrganStatus=@OrganStatus  where OrganId=@OrganId",new { OrganStatus= status, OrganId= orgid });
        }

        //绑定上级机构
        public override List<OrganMod> GetOrganName()
        {
            return DapperHelper.Query<OrganMod>("select OrganId,OrganName from  Organ", " ");
        }
        //绑定省
        public override List<OrganMod> GetProvinceId()
        {
            return DapperHelper.Query<OrganMod>("select ProvinceId,pro.SitesName from Organ org" +
                " join Sites pro on pro.SiID = org.ProvinceId" +
                " join Sites city on city.SiID = org.City join Sites dis on dis.SiID = org.District", "");
        }
        //绑定市
        public override List<OrganMod> GetCity()
        {
            return DapperHelper.Query<OrganMod>("select city,city.SitesName from Organ org" +
                " join Sites pro on pro.SiID = org.ProvinceId" +
                " join Sites city on city.SiID = org.City join Sites dis on dis.SiID = org.District", "");
        }
        //绑定区
        public override List<OrganMod> GetDistrict()
        {
            return DapperHelper.Query<OrganMod>("select District,dis.SitesName from Organ org" +
                " join Sites pro on pro.SiID = org.ProvinceId" +
                " join Sites city on city.SiID = org.City join Sites dis on dis.SiID = org.District", "");
        }



        //查询顶级节点
        public override List<OrganMod> GetMods()
        {
            var list = DapperHelper.Query<OrganMod>("select *from Organ where PId=0", "").ToList();
            return list;
        }
        //查询子节点
        public override List<OrganMod> Mods(int id)
        {
            var list = DapperHelper.Query<OrganMod>("select *from Organ where PId=@id", new { id }).ToList();
            return list;
        }
        //顶级节点循环
        public override List<OrganMod> GetList()
        {
            var list = GetMods();
            foreach (var item in list)
            {
                item.children = Gets(item.OrganId);
            }
            return list;
        }
        //节点循环
        public override List<OrganMod> Gets(int id)
        {
            var list = Mods(id);
            foreach (var citem in list)
            {
                citem.children = Gets(citem.OrganId);
            }
            return list;
        }
    }
}
