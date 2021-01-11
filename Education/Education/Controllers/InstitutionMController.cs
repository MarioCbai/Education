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
    /// 机构管理管理控制器
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class InstitutionMController : ControllerBase
    {
        private IInstitutionManagement _institutionManagement;
        /// <summary>
        /// 机构管理管理控制器接口
        /// </summary>
        /// <param name="institutionManagement"></param>
        public InstitutionMController(IInstitutionManagement institutionManagement)
        {
            _institutionManagement = institutionManagement;
        }
    }
}
