using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IEducation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Education.Controllers
{
    /// <summary>
    /// 学员管理控制器
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentMController : ControllerBase
    {
        private readonly ILogger<StudentMController> _logger;
        private IStudentManagement _studentManagement;
        /// <summary>
        /// 学员管理控制器接口
        /// </summary>
        /// <param name="studentManagement"></param>
        public StudentMController(IStudentManagement studentManagement, ILogger<StudentMController> logger)
        {
            _logger = logger;
            _studentManagement = studentManagement;
        }
    }
}
