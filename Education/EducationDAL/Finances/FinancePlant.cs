using EducationDAL.Finances.AuditTables;
using EducationDAL.Finances.Organizations;
using EducationDAL.Finances.Payments;
using EducationDAL.Finances.Recharges;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.Finances
{
    //财务管理工厂
    public class FinancePlant : Finance
    {
        //学员余额
        public override AuditTable AuditTable()
        {
            return new AuditTableRealize();
        }

        //机构账户
        public override Organization Organization()
        {
            return new OrganizationRealize();
        }

        //支付
        public override Payment Payment()
        {
            return new PaymentRealize();
        }

        //充值
        public override Recharge Recharge()
        {
            return new RechargeRealize();
        }
    }
}
