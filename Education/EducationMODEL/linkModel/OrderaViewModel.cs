using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.linkModel
{
    public class OrderaViewModel
    {
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

        public string buyer { get; set; }//下单人

        public int RecursionId { get; set; }//机构递归表外键

        public DateTime OrderTime { get; set; }//下单时间

        public DateTime AuditDateTime { get; set; }//审核时间

        public int PriceRankId { get; set; }//价格级别表外键

        public int HourTypeId { get; set; }//课时类型表外键

        public int SubjectsId { get; set; }//学科表外键

        public int PricingId { get; set; }//定价管理表外键(课时单价)

        public int PeriodNum { get; set; }//课时数
        public string Auditor { get; set; } //审核人
        public string Verifier { get; set; }  //审核人

        public int ComplimentaryPeriod { get; set; }//赠送课时

        public decimal CommodityPrice { get; set; }//商品总价

        public decimal PreferentialPrice { get; set; }//优惠价

        public string OrdersRemark { get; set; }//备注
        public string StudentName { get; set; }//学员姓名(学员表 )
        public string StudentIphone { get; set; }//学员手机号 
        public string BusinessTypeName { get; set; }//业务类型名称(业务类型表)
        public string ClassModelName { get; set; }//班型名称(版型表)
        public string ConsumerName { get; set; }//姓名(用户表)
        public string StudyName { get; set; }  //学段年级名称(学段表)
        public string OrganName { get; set; }//机构名称(机构循环表)
        public string PatternOfPayment { get; set; }//支付方式
        public int RefundState { get; set; }//退款状态(0未退款,1部分退款,2全部退款)

        public string ClassModels { get; set; }//进入课堂形式

        public int ClassModelNumber { get; set; }//容纳学员人数

        public int Sort { get; set; }//排序
        public string HourTypeName { get; set; }//课时类别名称
        public decimal Proportion { get; set; }//课时比例

        public int Ztai { get; set; }//状态
        public string PriceRankName { get; set; }//价格级别
        public int PricingPrice { get; set; }//课时单价s
        public string ConsumerIPhone { get; set; }//手机

        public string ConsumerRemark { get; set; }//备注

        public string ConsumerPwd { get; set; }//密码

        public int ConsumerSection { get; set; }//权限部门，按照机构来
        public int PaymentId { get; set; }//支付表id
        public DateTime PaymentZahlungsziel { get; set; }//支付时间

        public int PaymentOrderId { get; set; }//订单表外键

        public int RefundId { get; set; }//退款主键

        public decimal RefundAmount { get; set; }//申请退款金额

        public string RefundRemark { get; set; }//退款备注

        public string Refundperson { get; set; }//申请人

        public DateTime RefundTime { get; set; }//申请退款时间
        public int StudyId { get; set; }   //父级编号
        public int OrganId { get; set; }//机构表主键

        public string OrganEncod { get; set; }//机构编码
        public int InstitutionalId { get; set; }//机构类型外键

        public string OrganPhoneName { get; set; }//联系人

        public string OrganPhone { get; set; }//联系电话

        public int ProvinceId { get; set; }//省Id

        public int City { get; set; }//市Id地区绑定三级联动

        public int District { get; set; }//区Id --地区表外键 绑定下拉

        public string OrganRemark { get; set; }//备注

        public bool OrganStatus { get; set; }//状态 启用禁用

        public DateTime OrganBeginTime { get; set; }//创建时间 获取当前时间

        public int PId { get; set; }//递归表编号PId上级机构
        public string SubjectsName { get; set; }//科目名称

        public string StudentIDNo { get; set; }//学员身份证号

        public DateTime StudentBirthday { get; set; }//生日

        public string StudentWeChat { get; set; }//学员微信

        public string StudentQQ { get; set; }//学员QQ

        public string StudentPwd { get; set; }//学员密码

        public bool StudentSex { get; set; }//学员性别

        public string StudentSchool { get; set; }//学员学校

        public int Province { get; set; }//省ID

        public int County { get; set; }//区县ID

        public string StudentSite { get; set; }//学员地址

        public string StudentQuality { get; set; }//质量度		ABCDEF

        public int Institution { get; set; }//所+属机构

        public int StudentKind { get; set; }//学员状态是否成单：1成 0意向
        public int AuditionID { get; set; }//主键

        public string AuditionType { get; set; }//课程类别 试听课和正式课

        public int Grade { get; set; }//年级（外键）

        public string AuditionClass { get; set; }//上课主题

        public string AuditionDate { get; set; }//上课日期

        public string AuditionTime { get; set; }//上课时间

        public int AuditionState { get; set; }//课堂状态 ,1已上课，2已排课，3以备课，4以上课，5未上课，6已取消，7以退课,8返还课

        public string AuditionRemark { get; set; }//备注

        public int TeacherId { get; set; }//教师

        public int ASID { get; set; }//主键id

        public int Audition { get; set; }//课程表（外键）

        public int Student { get; set; }//学生表（外键）
        public DateTime AuditTime { get; set; }//审核时间


    }
}
