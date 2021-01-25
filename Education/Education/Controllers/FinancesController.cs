using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationMODEL.FinancialManagement;
using EducationMODEL.linkModel;
using EducationMODEL.organizational;
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
        public int OrganizationUpt(OrganizationMod or)
        {
            return _finances.OrganizationUpt(or);
        }

        /// <summary>
        /// 查询机构类型表绑定下拉
        /// </summary>
        /// <returns></returns>
        [Route("/api/SelectInstitutionalAll")]
        [HttpGet]
        public string SelectInstitutionalAll()
        {
            return JsonConvert.SerializeObject(_finances.SelectInstitutionalAll());
        }

        /// <summary>
        /// 查询机构账户反填
        /// </summary>
        /// <returns></returns>
        [Route("/api/SelectOrganization")]
        [HttpGet]
        public Organ_Inst_Organ SelectOrganization(int id)
        {
            return _finances.SelectOrganization(id);
        }

        /// <summary>
        /// 机构账户充值
        /// </summary>
        /// <param name="am"></param>
        /// <returns></returns>
        [Route("/api/AauditAdd")]
        [HttpPost]
        public int AauditAdd(AauditMod am)
        {
            am.AauditDateTiem = DateTime.Now;
            am.AauditName = "张三";
            return _finances.AauditAdd(am);
        }

        /// <summary>
        /// 机构充值审核显示和查询
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dm"></param>
        /// <param name="name"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        [Route("/api/AauditShow")]
        [HttpGet]
        public string AauditShow(int id = 0, string dm = null, string name = null, DateTime? time = null)
        {
            List<Aaudit_OrganiMod> ss =_finances.AauditShow(id, dm, name, time);
            foreach (var item in ss)
            {
                if (item.SHerDatetiem.ToString("yyyy-MM-dd")!= "0001-01-01")
                {
                    item.time = item.SHerDatetiem.ToString("yyyy-MM-dd");
                }
            }
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
        /// 充值方法
        /// </summary>
        /// <param name="price"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("/api/AauditOrganUpt")]
        [HttpPost]
        public int AauditOrganUpt(int price, int id)
        {
            return _finances.AauditOrganUpt(price, id);
        }

        /// <summary>
        /// 充值审核
        /// </summary>
        /// <param name="am"></param>
        /// <returns></returns>
        [Route("/api/AauditSHerUpt")]
        [HttpPost]
        public int AauditSHerUpt(AauditMod am)
        {
           am.SHerDatetiem = DateTime.Now;
            return _finances.AauditSHerUpt(am);
        }
    }
}
