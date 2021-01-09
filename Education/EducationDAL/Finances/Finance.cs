using EducationDAL.Finances.AuditTables;
using EducationDAL.Finances.Organizations;
using EducationDAL.Finances.Payments;
using EducationDAL.Finances.Recharges;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.Finances
{
    //财务管理工厂类
    public abstract class Finance
    {
        /// <summary>
        /// 支付
        /// </summary>
        /// <returns></returns>
        public abstract Payment Payment();
        /// <summary>
        /// 充值
        /// </summary>
        /// <returns></returns>

        public abstract Recharge Recharge();

        /// <summary>
        /// 学员余额
        /// </summary>
        /// <returns></returns>
        public abstract AuditTable AuditTable();

        /// <summary>
        /// 机构账户
        /// </summary>
        /// <returns></returns>
        public abstract Organization Organization();
    }
}
