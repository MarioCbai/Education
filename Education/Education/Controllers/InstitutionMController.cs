using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationMODEL.organizational;
using IEducation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Education.Controllers
{
    /// <summary>
    /// 机构管理管理控制器
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class InstitutionMController : ControllerBase
    {
        private readonly ILogger<IndentMController> _logger;
        private IInstitutionManagement _institutionManagement;
        /// <summary>
        /// 机构管理管理控制器接口
        /// </summary>
        /// <param name="institutionManagement"></param>
        public InstitutionMController(IInstitutionManagement institutionManagement, ILogger<IndentMController> logger)
        {
            _logger = logger;
            _institutionManagement = institutionManagement;
        }
        #region 机构管理
        //机构管理显示
        [Route("api/GetOrganMods")]
        [HttpGet]
        public string GetOrganMods()
        {
            //记录日志
            _logger.LogInformation("机构管理显示");
            List<OrganMod> Organs = _institutionManagement.GetOrganMods();
            var list = new
            {
                code = 0,
                msg = "",
                count = Organs.Count(),
                data = Organs,
            };
            return JsonConvert.SerializeObject(list);
        }
        [HttpPost]
        [Route("api/AddOrganes")]
        //添加机构管理
        public int AddOrganes(OrganMod organ)
        {
            //添加日志
            _logger.LogInformation("添加机构管理信息");
            organ.OrganBeginTime = DateTime.Now;
            return _institutionManagement.AddOrganes(organ);
        }
        //反填机构管理信息 
        [HttpPost]
        [Route("api/ModiyIdOrganes")]
        public OrganMod ModiyIdOrganes(int orgid)
        {
            //反填日志
            _logger.LogInformation("回显机构管理信息");
            return _institutionManagement.ModiyIdOrganes(orgid);
        }
        //修改机构管理信息
        [HttpPost]
        [Route("api/ModiyOrganes")]
        public int ModiyOrganes(OrganMod organ)
        {
            //修改日志
            _logger.LogInformation("修改机构管理信息");
            return _institutionManagement.ModiyOrganes(organ);
        }

        //单删除机构管理信息
        [HttpPost]
        [Route("api/DeleteOrganes")]
        public int DeleteOrganes(int ids)
        {
            //删除日志
            _logger.LogInformation("删除机构管理信息");
            return _institutionManagement.DeleteOrganes(ids);
        }
        #endregion
    }
}
