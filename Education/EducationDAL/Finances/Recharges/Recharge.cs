using EducationMODEL.FinancialManagement;
using EducationMODEL.linkModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.Finances.Recharges
{
    //充值方法声明
    public abstract class Recharge
    {
        //机构账户充值
        public abstract int AauditAdd(AauditMod am);
        //机构充值审核显示和查询
        public abstract List<Aaudit_OrganiMod> AauditShow(int ? id=null,string dm=null,string name=null,DateTime ? time=null);

        //充值审核
        public abstract int AauditSHerUpt(AauditMod am);
        //充值方法
        public abstract int AauditOrganUpt(int price, int id);

    }
}
