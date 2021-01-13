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
        List<OrdersMod> GetOrdersMods();



    }
}
