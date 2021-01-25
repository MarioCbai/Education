using EducationMODEL.Infrastructure;
using EducationMODEL.linkModel;
using EducationMODEL.OrderManagement;
using EducationMODEL.organizational;
using EducationMODEL.students;
using System;
using System.Collections.Generic;
using System.Text;

namespace IEducation
{
    //订单管理
    public interface IIndentManagement
    {
        /// <summary>
        /// 订单的显示以及查询
        /// </summary>
        /// <returns></returns>
        List<OrderaViewModel> GetOrdersMods(string studentIphone = null, string studentName = null, int businessTypeId = -1, int classModelId = -1, int stID = -1, int orderStatus = -1, int stateOfPayment = -1, string buyer = null, int organId = -1, string orderTime = null);
        /// <summary>
        /// 查询所有业务类型的数据
        /// </summary>
        /// <returns></returns>
        List<BusinessTypeMod> GetBusinessTypeMods();
        /// <summary>
        /// 查询出所有的班型
        /// </summary>
        /// <returns></returns>
        public List<ClassModelMod> GetClassModelMods();
        /// <summary>
        /// 查询出所有学段
        /// </summary>
        /// <returns></returns>
        public List<Study> GetStudies();
        /// <summary>
        /// 退款信息的显示
        /// </summary>
        /// <returns></returns>
        List<OrderaViewModel> GetRefundMod(string studentIphone = null, string studentName = null, string refundperson = null, int refundState = -1, int recursionId = -1, string refundTime = null);
        /// <summary>
        /// 查询出所有课时类型
        /// </summary>
        /// <returns></returns>
        List<HourTypeMod> GetTypeMods();
        /// <summary>
        /// 根据参数查询出是意向/正式学员
        /// </summary>
        /// <returns></returns>
        List<StudentViewModel> GetStudentMods(int studentKind =-1);
        /// <summary>
        /// 查询出所有的机构
        /// </summary>
        /// <returns></returns>
        public abstract List<OrganMod> GetOrganes();
        /// <summary>
        /// 根据id查学生
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public StudentViewModel GetStudentModsById(int id);
        /// <summary>
        /// 根据班型,学段,课时类型来查询出课时单价
        /// </summary>
        /// <param name="classModelId"></param>
        /// <param name="StID"></param>
        /// <param name="HourTypeId"></param>
        /// <returns></returns>
        //public List<PricingMod> GetPricingMods(int classModelId,int stID,int hourTypeId,int priceRankId);
        /// <summary>
        /// 查询所有价格级别
        /// </summary>
        /// <returns></returns>
        public  List<PriceRankMod> GetPriceRanks();
        /// <summary>
        /// 根据id查询订单信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<OrderaViewModel> GetOrderaViews(int id);
        /// <summary>
        /// 根据id查询退款信息信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<OrderaViewModel> GetRefundMod(int id);
        /// <summary>
        /// 订单审核的状态修改
        /// </summary>
        /// <param name="id"></param>
        /// <param name="orderStatus"></param>
        /// <returns></returns>
        public int UpdateOrderStatus(OrdersMod orders);
        /// <summary>
        /// 根据id查询出订单信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public  OrderaViewModel GetOrderaViewModelById(int id);
        /// <summary>
        /// 修改订单信息
        /// </summary>
        /// <param name="ovm"></param>
        /// <returns></returns>
        public  int EditOrders(OrdersMod orders);
        /// <summary>
        /// 根据下拉框该变查询出课时单价
        /// </summary>
        /// <param name="priceRankId"></param>
        /// <param name="classModelId"></param>
        /// <param name="stID"></param>
        /// <param name="hourTypeId"></param>
        /// <returns></returns>
        public PricingMod GetPricingMods(int priceRankId=-1,int classModelId=-1,int stID=-1,int hourTypeId=-1);
        /// <summary>
        /// 添加订单信息
        /// </summary>
        /// <param name="orders"></param>
        /// <returns></returns>
        public int  AddOrders(OrdersMod orders);
        /// <summary>
        /// 添加退款订单
        /// </summary>
        /// <param name="refund"></param>
        /// <returns></returns>
        public int AddRefund(RefundMod refund);
        /// <summary>
        /// 退款商品的审核
        /// </summary>
        /// <param name="refundId"></param>
        /// <param name="refundAmount"></param>
        /// <param name="RefundRemark"></param>
        /// <returns></returns>
        public  int EditRefund(RefundMod refund);
        /// <summary>
        /// 首页显示课时小于十五的学生信息
        /// </summary>
        /// <returns></returns>
        public  List<OrderaViewModel> GetStudentOrder();
        /// <summary>
        /// 查询出本月的订单数据
        /// </summary>
        /// <returns></returns>
        public List<OrdersMod> GetOrders();
        /// <summary>
        /// 查询出本月的退款数据
        /// </summary>
        /// <returns></returns>
        public List<RefundMod> GetRefunds();


    }
}
