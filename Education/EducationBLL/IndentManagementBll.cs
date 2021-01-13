using EducationDAL.IndentManagement;
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
        /// 订单的显示以及查询
        /// </summary>
        /// <returns></returns>
        public List<OrdersMod> GetOrdersMods()
        {
            return indents.Orders().GetOrdersMods();
        }





    }
}
