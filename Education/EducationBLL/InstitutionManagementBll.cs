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
        #endregion
    }
}
