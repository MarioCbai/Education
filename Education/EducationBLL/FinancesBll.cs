using EducationDAL.Finances;
using EducationMODEL.FinancialManagement;
using EducationMODEL.linkModel;
using EducationMODEL.organizational;
using IEducation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationBLL
{
    //财务管理
    public class FinancesBll: IFinances
    {
        Finance finances = new FinancePlant();
        //机构账户充值
        public int AauditAdd(AauditMod am)
        {
            return finances.Recharge().AauditAdd(am);
        }
        //充值方法
        public int AauditOrganUpt(int price, int id)
        {
            return finances.Recharge().AauditOrganUpt(price,id);
        }
        //充值审核
        public int AauditSHerUpt(AauditMod am)
        {
            return finances.Recharge().AauditSHerUpt(am);
        }

        //机构充值审核显示和查询
        public List<Aaudit_OrganiMod> AauditShow(int ? id =null, string dm = null, string name = null, DateTime? time = null)
        {
            return finances.Recharge().AauditShow(id,dm,name,time);
        }

        //机构审核表显示
        public List<Organ_Inst_Organ> OrganizAauditShow()
        {
            return finances.Organization().OrganizAauditShow();
        }

        public List<Organ_Inst_Organ> OrganizationShow(int? id = null, string dm = null, string name = null)
        {
            return finances.Organization().OrganizationShow(id,dm,name);
        }

        public int OrganizationUpt(OrganizationMod or)
        {
            return finances.Organization().OrganizationUpt(or);
        }
        //查询机构类型表绑定下拉
        public List<Institutional> SelectInstitutionalAll()
        {
            return finances.Organization().SelectInstitutionalAll();
        }
        //查询机构账户反填
        public Organ_Inst_Organ SelectOrganization(int id)
        {
            return finances.Organization().SelectOrganization(id);
        }
    }
}
