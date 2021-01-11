using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IEducation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Education.Controllers
{
    /// <summary>
    /// 订单管理
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class IndentMController : ControllerBase
    {
        private IIndentManagement _indentManagement;
        /// <summary>
        /// 订单管理接口
        /// </summary>
        /// <param name="indentManagement"></param>
        public IndentMController(IIndentManagement indentManagement)
        {
            _indentManagement = indentManagement;
        }
    }
}
