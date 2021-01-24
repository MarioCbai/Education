using EducationDAL.InstitutionManagement.Organs;
using EducationMODEL.Infrastructure;
using EducationMODEL.linkModel;
using EducationMODEL.OrderManagement;
using EducationMODEL.organizational;
using EducationMODEL.students;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.IndentManagement.Orderses
{
    //订单
    public abstract class Orders
    {
        /// <summary>
        /// 订单的显示以及查询
        /// </summary>
        /// <returns></returns>
        public abstract List<OrderaViewModel> GetOrdersMods(string studentIphone = null, string studentName = null, int businessTypeId = -1, int classModelId = -1, int stID = -1,int orderStatus=-1,int stateOfPayment=-1,string buyer = null,int organId=-1,string orderTime=null);
        /// <summary>
        /// 查询出所有业务类型
        /// </summary>
        /// <returns></returns>
        public abstract List<BusinessTypeMod> GetBusinessTypeMods();
        /// <summary>
        /// 查询出所有的班型
        /// </summary>
        /// <returns></returns>
        public abstract List<ClassModelMod> GetClassModelMods();
        /// <summary>
        /// 查询出所有学段
        /// </summary>
        /// <returns></returns>
        public abstract List<Study> GetStudies();
        /// <summary>
        /// 查询出所有课时类型
        /// </summary>
        /// <returns></returns>
        public abstract List<HourTypeMod> GetTypeMods();
        /// <summary>
        /// 根据参数查询出是意向/正式学员
        /// </summary>
        /// <returns></returns>
        public abstract List<StudentViewModel> GetStudents(int studentKind= -1);
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
        public abstract StudentViewModel GetStudentModsById(int id);
        /// <summary>
        /// 根据班型,学段,课时类型来查询出课时单价
        /// </summary>
        /// <param name="classModelId"></param>
        /// <param name="StID"></param>
        /// <param name="HourTypeId"></param>
        /// <returns></returns>
        //public abstract List<PricingMod> GetPricingMods(int classModelId, int stID, int hourTypeId,int priceRankId);
        /// <summary>
        /// 查询所有价格级别
        /// </summary>
        /// <returns></returns>
        public abstract  List<PriceRankMod> GetPriceRanks();
        /// <summary>
        /// 根据id查询订单信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public abstract List<OrderaViewModel> GetOrderaViews(int id);
        /// <summary>
        /// 订单审核的状态修改
        /// </summary>
        /// <param name="id"></param>
        /// <param name="orderStatus"></param>
        /// <returns></returns>
        public abstract int UpdateOrderStatus(OrdersMod orders);
        /// <summary>
        /// 根据id查询出订单信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public abstract OrderaViewModel GetOrderaViewModelById(int id);
        /// <summary>
        /// 修改订单信息
        /// </summary>
        /// <param name="ovm"></param>
        /// <returns></returns>
        public abstract int EditOrders(OrdersMod orders);
        /// <summary>
        /// 根据下拉框该变查询出课时单价
        /// </summary>
        /// <param name="priceRankId"></param>
        /// <param name="classModelId"></param>
        /// <param name="stID"></param>
        /// <param name="hourTypeId"></param>
        /// <returns></returns>
        public abstract PricingMod GetPricingMods(int priceRankId = -1, int classModelId = -1, int stID = -1, int hourTypeId = -1);
        /// <summary>
        /// 添加订单信息
        /// </summary>
        /// <param name="orders"></param>
        /// <returns></returns>
        public abstract int AddOrders(OrdersMod orders);

    }
}
