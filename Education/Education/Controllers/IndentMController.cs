using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationDAL.IndentManagement.Orderses;
using EducationMODEL.OrderManagement;
using IEducation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Education.Controllers
{
    /// <summary>
    /// 订单管理
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class IndentMController : ControllerBase
    {
        private readonly ILogger<IndentMController> _logger;
        private IIndentManagement _indentManagement;
        /// <summary>
        /// 订单管理接口
        /// </summary>
        /// <param name="indentManagement"></param>
        public IndentMController(IIndentManagement indentManagement, ILogger<IndentMController> logger)
        {
            _logger = logger;
            _indentManagement = indentManagement;
        }
        /// <summary>
        /// 显示以及查询
        /// </summary>
        /// <returns></returns>
        [Route("/api/GetOrders")]
        [HttpGet]
        public List<OrdersMod> GetOrders() 
        {
            List<OrdersMod> list = _indentManagement.GetOrdersMods();
            return list;
        }




    }
}
