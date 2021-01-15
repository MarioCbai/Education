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
        #endregion
    }
}
