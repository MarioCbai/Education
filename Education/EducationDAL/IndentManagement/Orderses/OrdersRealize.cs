using EducationMODEL.OrderManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.IndentManagement.Orderses
{
    //订单实现
    public class OrdersRealize : Orders
    {
        /// <summary>
        /// 订单的显示以及查询
        /// </summary>
        /// <returns></returns>
        public override List<OrdersMod> GetOrdersMods()
        {
            return DapperHelper.Query<OrdersMod>("select * from Orders orders join Student student on orders.StudentId = student.StudentId join BusinessType businessType on orders.BusinessTypeId = businessType.BusinessTypeId join ClassModel classmodel on orders.ClassModelId = classmodel.ClassModelId join Study study on orders.StID = study.StID join Payment payment on payment.PaymentOrderId = orders.OrderId join Organ organ on organ.OrganId = orders.RecursionId join Consumer consumer on consumer.ConsumerId = orders.ConsumerId join Refund refund on refund.RefundId = orders.OrderId join HourType hourType on hourType.HourTypeId = orders.HourTypeId join PriceRank pricerank on pricerank.PriceRankId = orders.PriceRankId join Pricing pricing on pricing.PricingId = orders.PricingId join SubjectsHourType subjectshourtype on subjectshourtype.HourType = HourType.HourTypeId join Subjects subjects on subjects.SubjectsId = subjectshourtype.Subjects",new { });
        }
    }
}
