﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.linkModel
{
   public  class DropClassModShow
    {
        public int DCId { get; set; }
        public int ASID { get; set; }
        public int OrganId { get; set; }
        public string AuditorDrop { get; set; }
        public string AuditorDropdateTime { get; set; }
        public string Remark { get; set; }
        public bool DropClassstate { get; set; }
        public string proposer { get; set; }
        public int OrderId { get; set; }//主键

        public string OrderNO { get; set; }//订单编号(自动生成)

        public int StudentId { get; set; }//学员表外键

        public int BusinessTypeId { get; set; }//业务类型表外键(线上/线下)

        public int ClassModelId { get; set; }//班型表外键

        public int StID { get; set; }//学段年级递归表外键

        public decimal OrderAmount { get; set; }//订单金额

        public decimal AmountPayable { get; set; }//应付金额

        public decimal AmountActually { get; set; }//实付金额

        public int OrderStatus { get; set; }//订单状态(0待审核,1审核拒绝,2审核通过,3已取消)

        public int StateOfPayment { get; set; }//支付状态(1:已支付;2:已返还,3未支付)

        public int ConsumerId { get; set; }//用户表外键

        public int RecursionId { get; set; }//机构递归表外键

        public DateTime OrderTime { get; set; }//下单时间

        public DateTime AuditDateTime { get; set; }//审核时间

        public int PriceRankId { get; set; }//价格级别表外键

        public int HourTypeId { get; set; }//课时类型表外键

        public int SubjectsId { get; set; }//学科表外键

        public int PricingId { get; set; }//定价管理表外键(课时单价)

        public int PeriodNum { get; set; }//课时数

        public int ComplimentaryPeriod { get; set; }//赠送课时

        public decimal CommodityPrice { get; set; }//商品总价

        public decimal PreferentialPrice { get; set; }//优惠价

        public string OrdersRemark { get; set; }//备注
        public string OrganName { get; set; }  //机构名称

        public int RefundState { get; set; }
        public string StudentName { get; set; }   //学生姓名

        public string OrganPhoneName { get; set; }
    }
}
