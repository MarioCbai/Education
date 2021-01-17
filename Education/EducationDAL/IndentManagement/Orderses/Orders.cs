using EducationMODEL.Infrastructure;
using EducationMODEL.linkModel;
using EducationMODEL.OrderManagement;
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
        public abstract List<OrderaViewModel> GetOrdersMods(string studentIphone = null, string studentName = null, int businessTypeId = 0, int classModelId = 0, int stID = 0);
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


    }
}
