using EducationDAL.IndentManagement.Orderses;
using EducationDAL.IndentManagement.Refunds;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.IndentManagement
{
    //订单管理工厂
    public class IndentPlant : Indent
    {
        //订单表
        public override Orders Orders()
        {
            return new OrdersRealize();
        }
        //退款
        public override Refund Refund()
        {
            return new RefundRealize();
        }
    }
}
