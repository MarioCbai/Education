using EducationMODEL.linkModel;
using EducationMODEL.OrderManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.IndentManagement.Refunds
{
    //退款
    public class RefundRealize:Refund
    {
        /// <summary>
        /// 退款信息的显示
        /// </summary>
        /// <returns></returns>
        public override List<OrderaViewModel> GetRefundMod()
        {
            string sql = " select * from Refund a  join Orders b on a.OrderId=b.OrderId join Student c on b.StudentId=c.StudentId join Organ d on b.RecursionId=d.OrganId where 1 =1";
            return DapperHelper.Query<OrderaViewModel>(sql, new { });
        }
        /// <summary>
        /// 根据id查询退款信息信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override List<OrderaViewModel> GetRefundMod(int id)
        {
            string sql = " select * from Refund a  join Orders b on a.OrderId=b.OrderId join Student c on b.StudentId=c.StudentId join Organ d on b.RecursionId=d.OrganId join Study e on b.StID=e.StID where a.RefundId=@RefundId";
            return DapperHelper.Query<OrderaViewModel>(sql, new { RefundId=id });
        }
        /// <summary>
        /// 添加退款订单
        /// </summary>
        /// <param name="refund"></param>
        /// <returns></returns>
        public override int AddRefund(RefundMod refund)
        {
            return DapperHelper.Execute("insert into Refund values(@OrderId,@RefundAmount,@RefundRemark,@Refundperson,@RefundTime,@RefundState)", refund);
        }
        /// <summary>
        /// 退款商品的审核
        /// </summary>
        /// <param name="refundId"></param>
        /// <param name="refundAmount"></param>
        /// <param name="RefundRemark"></param>
        /// <returns></returns>
        public override int EditRefund(RefundMod refund)
        {
            return DapperHelper.Execute("update Refund Set RefundAmount=@RefundAmount,RefundRemark=@RefundRemark,RefundState=@RefundState where RefundId=@RefundId", refund);
        }
    }
}
