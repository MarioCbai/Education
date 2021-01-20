﻿using EducationDAL.IndentManagement;
using EducationMODEL.Infrastructure;
using EducationMODEL.linkModel;
using EducationMODEL.OrderManagement;
using EducationMODEL.organizational;
using EducationMODEL.students;
using IEducation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationBLL
{
    //订单管理
    public class IndentManagementBll: IIndentManagement
    {
        Indent indents = new IndentPlant();
        /// <summary>
        /// 添加订单信息
        /// </summary>
        /// <param name="orders"></param>
        /// <returns></returns>
        public int AddOrders(OrdersMod orders)
        {
            return indents.Orders().AddOrders(orders);
        }
        /// <summary>
        /// 添加退款订单
        /// </summary>
        /// <param name="refund"></param>
        /// <returns></returns>
        public int AddRefund(RefundMod refund)
        {
            return indents.Refund().AddRefund(refund);
        }
        /// <summary>
        /// 修改订单信息
        /// </summary>
        /// <param name="ovm"></param>
        /// <returns></returns>
        public int EditOrders(OrdersMod  orders)
        {
            return indents.Orders().EditOrders(orders);
        }

        /// <summary>
        /// 查询所有业务类型的数据
        /// </summary>
        /// <returns></returns>
        public List<BusinessTypeMod> GetBusinessTypeMods()
        {
            return indents.Orders().GetBusinessTypeMods();
        }

        /// <summary>
        /// 查询出所有的班型
        /// </summary>
        /// <returns></returns>
        public List<ClassModelMod> GetClassModelMods()
        {
            return indents.Orders().GetClassModelMods();
        }
        /// <summary>
        /// 根据id查询出订单信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public OrderaViewModel GetOrderaViewModelById(int id)
        {
            return indents.Orders().GetOrderaViewModelById(id);
        }

        /// <summary>
        /// 根据id查询订单信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<OrderaViewModel> GetOrderaViews(int id)
        {
            return indents.Orders().GetOrderaViews(id);
        }

        /// <summary>
        /// 订单的显示以及查询
        /// </summary>
        /// <returns></returns>
        public List<OrderaViewModel> GetOrdersMods(string studentIphone = null, string studentName = null, int businessTypeId = -1, int classModelId = -1, int stID = -1, int orderStatus = -1, int stateOfPayment = -1, string consumerName = null, int organId = -1)
        {
            return indents.Orders().GetOrdersMods(studentIphone, studentName, businessTypeId, classModelId, stID);
        }
        /// <summary>
        /// 查询出所有的机构
        /// </summary>
        /// <returns></returns>
        public List<OrganMod> GetOrganes()
        {
            return indents.Orders().GetOrganes();
        }
        /// <summary>
        /// 查询所有价格级别
        /// </summary>
        /// <returns></returns>
        public List<PriceRankMod> GetPriceRanks()
        {
            return indents.Orders().GetPriceRanks();
        }
        /// <summary>
        /// 根据下拉框该变查询出课时单价
        /// </summary>
        /// <param name="priceRankId"></param>
        /// <param name="classModelId"></param>
        /// <param name="stID"></param>
        /// <param name="hourTypeId"></param>
        /// <returns></returns>
        public PricingMod GetPricingMods(int priceRankId = -1, int classModelId = -1, int stID = -1, int hourTypeId = -1)
        {
            return indents.Orders().GetPricingMods(priceRankId,classModelId,stID,hourTypeId);
        }

        /// <summary>
        /// 退款信息的显示
        /// </summary>
        /// <returns></returns>
        public List<OrderaViewModel> GetRefundMod()
        {
            return indents.Refund().GetRefundMod();
        }
        /// <summary>
        /// 根据id查询退款信息信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<OrderaViewModel> GetRefundMod(int id)
        {
            return indents.Refund().GetRefundMod(id);
        }

        /// <summary>
        /// 根据参数查询出是意向/正式学员
        /// </summary>
        /// <returns></returns>
        public List<StudentViewModel>  GetStudentMods(int studentKind = -1)
        {
            return indents.Orders().GetStudents(studentKind);
        }
        /// <summary>
        /// 根据id查学生
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<StudentViewModel> GetStudentModsById(int id)
        {
            return indents.Orders().GetStudentModsById(id);
        }

        /// <summary>
        /// 查询出所有学段
        /// </summary>
        /// <returns></returns>
        public List<Study> GetStudies()
        {
            return indents.Orders().GetStudies();
        }
        /// <summary>
        /// 查询出所有的课时类型
        /// </summary>
        /// <returns></returns>
        public List<HourTypeMod> GetTypeMods()
        {
            return indents.Orders().GetTypeMods();
        }
        /// <summary>
        /// 订单审核的状态修改
        /// </summary>
        /// <param name="id"></param>
        /// <param name="orderStatus"></param>
        /// <returns></returns>
        public int UpdateOrderStatus(int id, int orderStatus)
        {
            return indents.Orders().UpdateOrderStatus(id,orderStatus);
        }
    }
}
