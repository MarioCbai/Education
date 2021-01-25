using EducationMODEL.FinancialManagement;
using EducationMODEL.linkModel;
using EducationMODEL.organizational;
using System;
using System.Collections.Generic;
using System.Text;

namespace IEducation
{
    //财务管理
    public interface IFinances
    {
        //财务机构账户显示
        List<Organ_Inst_Organ> OrganizationShow(int? id = null, string dm = null, string name = null);

        //财务机构账户充值金额
        int OrganizationUpt(OrganizationMod or);

        //查询机构类型表绑定下拉
        public abstract List<Institutional> SelectInstitutionalAll();
        //查询机构账户反填
        public abstract Organ_Inst_Organ SelectOrganization(int id);

        //机构审核表显示
        public abstract List<Organ_Inst_Organ> OrganizAauditShow();

        //机构账户充值
        public abstract int AauditAdd(AauditMod am);

        //机构充值审核显示和查询
        public abstract List<Aaudit_OrganiMod> AauditShow(int id = 0, string dm = null, string name = null, DateTime? time = null);

        //充值审核
        public abstract int AauditSHerUpt(AauditMod am);
        //充值方法
        public abstract int AauditOrganUpt(int price, int id);
    }
}
