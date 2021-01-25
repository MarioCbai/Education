using EducationMODEL.linkModel;
using EducationMODEL.OrderManagement;
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
        public abstract List<OrderaViewModel> GetRefundMod(string studentIphone = null, string studentName = null, string refundperson = null, int refundState = -1, int recursionId = -1,string refundTime = null);
        /// <summary>
        /// 根据id查询退款信息信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public abstract List<OrderaViewModel> GetRefundMod(int id);
        /// <summary>
        /// 添加退款订单
        /// </summary>
        /// <param name="refund"></param>
        /// <returns></returns>
        public abstract int AddRefund(RefundMod refund);
        /// <summary>
        /// 退款商品的审核
        /// </summary>
        /// <param name="refundId"></param>
        /// <param name="refundAmount"></param>
        /// <param name="RefundRemark"></param>
        /// <returns></returns>
        public abstract int EditRefund(RefundMod refund);
        /// <summary>
        /// 首页显示课时小于十五的学生信息
        /// </summary>
        /// <returns></returns>
        public abstract List<OrderaViewModel> GetStudentOrder();
        /// <summary>
        /// 查询出本月的退款数据
        /// </summary>
        /// <returns></returns>
        public abstract  List<RefundMod> GetRefunds();



    }
}
