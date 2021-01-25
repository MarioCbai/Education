using EducationMODEL.FinancialManagement;
using EducationMODEL.linkModel;
using EducationMODEL.organizational;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.Finances.Organizations
{
    //机构账户
    public abstract class Organization
    {
        //机构账户显示查询
        public abstract List<Organ_Inst_Organ> OrganizationShow(int ? id=null,string dm=null,string name=null);
        //机构账户充值
        public abstract int OrganizationUpt(OrganizationMod or);
        //查询机构类型表绑定下拉
        public abstract List<Institutional> SelectInstitutionalAll();
        //查询机构账户反填
        public abstract Organ_Inst_Organ SelectOrganization(int id);

        //机构审核表显示
        public abstract List<Organ_Inst_Organ> OrganizAauditShow();
    }
}
