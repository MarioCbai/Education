using EducationDAL.Finances;
using EducationMODEL.linkModel;
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

        public List<Organ_Inst_Organ> OrganizationShow(int? id = null, string dm = null, string name = null)
        {
            return finances.Organization().OrganizationShow(id,dm,name);
        }

        public int OrganizationUpt(int id, int price)
        {
            return finances.Organization().OrganizationUpt(id,price);
        }
    }
}
