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
    /// 教学管理控制器
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TeachingMController : ControllerBase
    {
        private ITeachingManagement _teachingManagement;
        /// <summary>
        /// 教学管理控制器接口
        /// </summary>
        /// <param name="teachingManagement"></param>
        public TeachingMController(ITeachingManagement teachingManagement)
        {
            _teachingManagement = teachingManagement;
        }
    }
}
