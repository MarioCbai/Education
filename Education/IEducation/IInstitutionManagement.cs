using EducationMODEL.organizational;
using System;
using System.Collections.Generic;
using System.Text;

namespace IEducation
{
    //机构管理
    public interface IInstitutionManagement
    {
        #region 机构管理
        //机构管理显示
        List<OrganMod> GetOrganMods();
        //添加机构信息
        int AddOrganes(OrganMod organ);
        //反填机构管理信息
        OrganMod ModiyIdOrganes(int orgid);
        //修改机构管理信息
        int ModiyOrganes(OrganMod organ);
        //单删除机构管理信息
        int DeleteOrganes(int ids);
        //反填机构管理状态
        OrganMod ModiyIdStates(int orgids);

        //修改机构管理状态
        int ModiyStates(OrganMod organ);

        //绑定上级机构
        List<OrganMod> GetOrganName();

        //查询顶级节点
        List<OrganMod> GetList();
        //查询子节点
        List<OrganMod> Gets(int id);
        //机构类型表
        List<InstitutionalMod> GetInstitutionalMods();
        //绑定省
        List<OrganMod> GetProvinceId();
        //绑定市
        List<OrganMod> GetCity();
        //绑定区
        List<OrganMod> GetDistrict();
        #endregion
    }
}
