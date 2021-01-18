using EducationMODEL.linkModel;
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
        public abstract int OrganizationUpt(int id, int price);
    }
}
