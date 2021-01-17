using EducationDAL.InstitutionManagement;
using EducationMODEL.organizational;
using IEducation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationBLL
{
    //机构管理
    public  class InstitutionManagementBll: IInstitutionManagement
    {
        Institution institutions = new InstitutionPlant();
        #region 机构管理
        //机构管理显示
        public List<OrganMod> GetOrganMods()
        {
            return institutions.Organ().GetOrganMods();
        }
        //添加机构管理
        public int AddOrganes(OrganMod organ)
        {
            return institutions.Organ().AddOrganes(organ);
        }
        //反填机构管理信息        
        public OrganMod ModiyIdOrganes(int orgid)
        {
            return institutions.Organ().ModiyIdOrganes(orgid);
        }
        //修改机构管理信息
        public int ModiyOrganes(OrganMod organ)
        {
            return institutions.Organ().ModiyOrganes(organ);
        }
        //单删除机构管理信息
        public int DeleteOrganes(int ids)
        {
            return institutions.Organ().DeleteOrganes(ids);
        }
        //反填机构管理状态
        public OrganMod ModiyIdStates(int orgids)
        {
            return institutions.Organ().ModiyIdStates(orgids);
        }
        //修改机构管理状态
        public int ModiyStates(OrganMod organ)
        {
            return institutions.Organ().ModiyStates(organ);
        }
        //查询顶级节点
        public List<OrganMod> GetList()
        {
            return institutions.Organ().GetList();
        }
        //查询子节点
        public List<OrganMod> Gets(int id)
        {
            return institutions.Organ().Gets(id);
        }
        //绑定上级机构
        public List<OrganMod> GetOrganName()
        {
            return institutions.Organ().GetOrganName();
        }
        //绑定机构类型
        public List<InstitutionalMod> GetInstitutionalMods()
        {
            return institutions.OrganesType().GetInstitutionalMods();
        }
        //绑定省
        public List<OrganMod> GetProvinceId()
        {
            return institutions.Organ().GetProvinceId();
        }
        //绑定市
        public List<OrganMod> GetCity()
        {
            return institutions.Organ().GetCity();
        }
        //绑定区
        public List<OrganMod> GetDistrict()
        {
            return institutions.Organ().GetDistrict();
        }
        #endregion
    }
}
