using EducationDAL.IndentManagement.Orderses;
using EducationDAL.IndentManagement.Refunds;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.IndentManagement
{
    //订单管理
    public abstract class Indent
    {
        /// <summary>
        /// 订单表
        /// </summary>
        /// <returns></returns>
        public abstract Orders Orders();

        /// <summary>
        /// 退款
        /// </summary>
        /// <returns></returns>
        public abstract Refund Refund();
    }
}
