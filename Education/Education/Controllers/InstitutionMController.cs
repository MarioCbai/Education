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

        //机构管理显示
        [HttpGet]
        [Route("api/GetOrganMod")]
        public List<OrganMod> GetOrganMod()
        {
            //记录日志
            _logger.LogInformation("机构管理显示");
            List<OrganMod> Organs = _institutionManagement.GetOrganMods();        
            return Organs;
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
        //反填机构管理状态
        [HttpPost]
        [Route("api/ModiyIdStates")]
        public OrganMod ModiyIdStates(int orgids)
        {
            _logger.LogInformation("反填机构管理状态信息");
            return _institutionManagement.ModiyIdStates(orgids);
        }
        //修改机构管理状态
        [HttpGet]
        [Route("api/ModiyStates")]
        public int ModiyStates(OrganMod organ)
        {
            _logger.LogInformation("修改机构管理状态信息");
            return _institutionManagement.ModiyStates(organ);
        }

        //查询顶级节点
        [Route("api/GetLists")]
        [HttpGet]
        public List<OrganMod> GetLists()
        {
            //记录日志
            _logger.LogInformation("机构递归管理显示");
            List<OrganMod> Organs = _institutionManagement.GetList();
            return Organs;
        }
        //绑定上级机构
        [Route("api/GetOrganName")]
        [HttpGet]
        public string GetOrganName()
        {
            _logger.LogInformation("机构递归管理显示");
            return JsonConvert.SerializeObject(_institutionManagement.GetOrganName());
        }
        //绑定机构类型
        [Route("api/GetInstitutionalMods")]
        [HttpGet]
        public string GetInstitutionalMods()
        {
            _logger.LogInformation("机构类型显示");
            return JsonConvert.SerializeObject(_institutionManagement.GetInstitutionalMods());
        }
        //绑定省
        [Route("api/GetProvinceId")]
        [HttpGet]
        public string GetProvinceId()
        {
            _logger.LogInformation("省");
            return JsonConvert.SerializeObject(_institutionManagement.GetProvinceId());
        }
        //绑定市
        [Route("api/GetCity")]
        [HttpGet]
        public string GetCity()
        {
            _logger.LogInformation("市");
            return JsonConvert.SerializeObject(_institutionManagement.GetCity());
        }
        //绑定区
        [Route("api/GetDistrict")]
        [HttpGet]
        public string GetDistrict()
        {
            _logger.LogInformation("区");
            return JsonConvert.SerializeObject(_institutionManagement.GetDistrict());
        }
        #endregion
    }
}
