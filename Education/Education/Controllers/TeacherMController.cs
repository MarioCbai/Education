using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationMODEL.TeacherManagement;
using IEducation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Education.Controllers
{
    /// <summary>
    /// 教师管理控制器
    /// </summary>
    
    [ApiController]
    public class TeacherMController : ControllerBase
    {
        private readonly ILogger<TeacherMController> _logger;
        private ITeacherManagement _teacherManagement;
        /// <summary>
        /// 教师管理控制器接口
        /// </summary>
        /// <param name="teacherManagement"></param>
        public TeacherMController(ITeacherManagement teacherManagement, ILogger<TeacherMController> logger)
        {
            _logger = logger;
            _teacherManagement = teacherManagement;
        }

        //教学信息显示
        [Route("api/GetTeaches")]
        [HttpGet]
        public string GetTeaches()
        {
            //记录日志
            _logger.LogInformation("教学管理显示");
            List<TeachMod> teaches = _teacherManagement.GetTeaches();
            var list = new
            {
                code = 0,
                msg = "",
                count = teaches.Count(),
                data = teaches,
            };
            return JsonConvert.SerializeObject(list);
        }
    }
}
