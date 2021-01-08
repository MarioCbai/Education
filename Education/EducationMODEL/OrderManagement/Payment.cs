using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.OrderManagement
{
    public class Payment//支付表
    {
        public int PaymentId { get; set; }//支付表id

        public string PatternOfPayment { get; set; }//支付方式

        public DateTime PaymentZahlungsziel { get; set; }//支付时间

        public int PaymentOrderId { get; set; }//订单表外键
    }
}
