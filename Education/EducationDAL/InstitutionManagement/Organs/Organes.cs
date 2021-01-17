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
        public abstract OrganMod ModiyIdOrganes(int id);
        //编辑机构管理信息
        public abstract int ModiyOrganes(OrganMod organ);
        //删除机构管理信息
        public abstract int DeleteOrganes(int ids);
    }
}
