using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IEducation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Education.Controllers
{
    /// <summary>
    /// 财务管理控制器
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FinancesController : ControllerBase
    {
        private readonly ILogger<FinancesController> _logger;
        private IFinances _finances;
        /// <summary>
        /// 财务管理控制器接口
        /// </summary>
        /// <param name="finances"></param>
        public FinancesController(IFinances finances, ILogger<FinancesController> logger)
        {
            _logger = logger;
            _finances = finances;
        }
    }
}
