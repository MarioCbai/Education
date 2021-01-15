using EducationMODEL.linkModel;
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
        int OrganizationUpt(int id,int price);
    }
}
