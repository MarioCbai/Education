using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationMODEL.Infrastructure;
using IEducation;
using log4net.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
namespace Education.Controllers
{
    /// <summary>
    /// 基本数据管理控制器
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EssentialDataController : ControllerBase
    {
        private readonly ILogger<EssentialDataController> _logger;
        private IEssentialData _essentialData;
        /// <summary>
        /// 基本数据管理控制器连接接口
        /// </summary>
        /// <param name="essentialData"></param>
        public EssentialDataController(IEssentialData essentialData,ILogger<EssentialDataController> logger)
        {
            _logger = logger;
            _essentialData = essentialData;
        }
        [HttpGet]
        public string Show()
        {
            List<SourceMod> ss = _essentialData.SourceShow();
            return JsonConvert.SerializeObject(ss);
        }
    }
}
