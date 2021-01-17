using EducationDAL.IndentManagement;
using EducationMODEL.Infrastructure;
using EducationMODEL.linkModel;
using EducationMODEL.OrderManagement;
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
        /// 订单的显示以及查询
        /// </summary>
        /// <returns></returns>
        public List<OrderaViewModel> GetOrdersMods(string studentIphone = null, string studentName = null, int businessTypeId = 0, int classModelId = 0, int stID = 0)
        {
            return indents.Orders().GetOrdersMods(studentIphone, studentName, businessTypeId, classModelId, stID);
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
    }
}
