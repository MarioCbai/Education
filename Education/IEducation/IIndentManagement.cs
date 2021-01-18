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
        List<OrderaViewModel> GetOrdersMods(string studentIphone = null, string studentName = null, int businessTypeId = -1, int classModelId = -1, int stID = -1);
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
        List<OrderaViewModel> GetRefundMod();
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
        public List<StudentViewModel> GetStudentModsById(int id);
        /// <summary>
        /// 根据班型,学段,课时类型来查询出课时单价
        /// </summary>
        /// <param name="classModelId"></param>
        /// <param name="StID"></param>
        /// <param name="HourTypeId"></param>
        /// <returns></returns>
        public List<PricingMod> GetPricingMods(int classModelId,int stID,int hourTypeId,int priceRankId);
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

    }
}
