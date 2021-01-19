using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationMODEL.linkModel;
using EducationMODEL.students;
using IEducation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

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
        //学员显示查询
        [HttpGet]
        [Route("/api/StudentShow")]
        public string StudentShow(int jigou, string zi, string zhi, int nian, string name, string iphone)
        {
            List<StudentLian> list = _studentManagement.StudentShow(jigou, zi, zhi, nian, name, iphone);
            var ss = new
            {
                code = 0,
                msg = "",
                count = list.Count,
                data = list
            };
            return JsonConvert.SerializeObject(ss);
        }
    }
}
