using EducationMODEL.linkModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.IndentManagement.Refunds
{
    //退款
    public abstract class Refund
    {
        /// <summary>
        /// 退款信息的显示
        /// </summary>
        /// <returns></returns>
        public abstract List<OrderaViewModel> GetRefundMod();
        /// <summary>
        /// 根据id查询退款信息信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public abstract List<OrderaViewModel> GetRefundMod(int id);
    }
}
