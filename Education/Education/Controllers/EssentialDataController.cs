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
    /// 基本数据管理控制器
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EssentialDataController : ControllerBase
    {
        private IEssentialData _essentialData;
        /// <summary>
        /// 基本数据管理控制器连接接口
        /// </summary>
        /// <param name="essentialData"></param>
        public EssentialDataController(IEssentialData essentialData)
        {
            _essentialData = essentialData;
        }
    }
}
