using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationMODEL.linkModel;
using IEducation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

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

        //机构账户管理
        /// <summary>
        /// 机构账户管理显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/OrganizationShow")]
        public string OrganizationShow(int? id = null, string dm = null, string name = null)
        {
            List<Organ_Inst_Organ> ss = _finances.OrganizationShow(id, dm, name);
            var date = new
            {
                code = 0,
                msg = "",
                count = ss.Count,
                data = ss.ToList(),
            };
            return JsonConvert.SerializeObject(date);
        }
        /// <summary>
        /// 机构账户充值
        /// </summary>
        /// <returns></returns>
        [Route("/api/OrganizationUpt")]
        [HttpPost]
        public int OrganizationUpt(int id, int price)
        {
            return _finances.OrganizationUpt(id,price);
        }
    }
}
