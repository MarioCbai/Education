using EducationMODEL.organizational;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.InstitutionManagement.Organs
{
    //机构表增删改
    public abstract class Organes
    {
        //机构管理显示
        public abstract List<OrganMod> GetOrganMods();
        //添加机构管理信息
        public abstract int AddOrganes(OrganMod organ);
        //反填机构管理信息
        public abstract OrganMod ModiyIdOrganes(int orgid);
        //编辑机构管理信息
        public abstract int ModiyOrganes(OrganMod organ);
        //删除机构管理信息
        public abstract int DeleteOrganes(int ids);
        //修改机构管理状态
        public abstract int ModiyStates(int status, int orgid);

        //查询顶级节点
        public abstract List<OrganMod> GetMods();
        //查询子节点
        public abstract List<OrganMod> Mods(int id);
        public abstract List<OrganMod> GetList();
        public abstract List<OrganMod> Gets(int id);
        //绑定上级机构
        public abstract List<OrganMod> GetOrganName();
        //绑定省
        public abstract List<OrganMod> GetProvinceId();
        //绑定市
        public abstract List<OrganMod> GetCity();
        //绑定区
        public abstract List<OrganMod> GetDistrict();
    }
}
