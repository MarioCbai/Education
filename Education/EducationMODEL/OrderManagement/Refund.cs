using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.OrderManagement
{
    public class Refund//退款商品表
    {
        public int RefundId { get; set; }//退款主键

        public int OrderId { get; set; }//订单表外键

        public decimal RefundAmount { get; set; }//申请退款金额

        public string RefundRemark { get; set; }//退款备注

        public string Refundperson { get; set; }//申请人

        public DateTime RefundTime { get; set; }//申请退款时间

        public int RefundState { get; set; }//退款状态(0未退款,1部分退款,2全部退款)
    }
}
