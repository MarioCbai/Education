using EducationMODEL.Infrastructure;
using EducationMODEL.linkModel;
using EducationMODEL.OrderManagement;
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
        List<OrderaViewModel> GetOrdersMods(string studentIphone = null, string studentName = null, int businessTypeId = 0, int classModelId = 0, int stID = 0);
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


    }
}
