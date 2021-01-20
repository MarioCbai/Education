using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationMODEL.Infrastructure;
using EducationMODEL.linkModel;
using EducationMODEL.organizational;
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

        /// <summary>
        /// 地址
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet]
        [Route("/api/Dizhi")]
        public List<SitesMod> Dizhi(int id)
        {
            return _studentManagement.Dizhi(id);
        }



        /// <summary>
        /// 学员添加
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpPost]
        [Route("/api/StudentAdd")]
        public int StudentAdd(StudentMod ss)
        {
            try
            {
                ss.StudentPwd = ss.StudentIphone.Substring(5, ss.StudentIphone.Length);
                ss.Counselor = "ccc";
                return _studentManagement.StudentAdd(ss);
            }
            catch (Exception)
            {

                throw;
            }
          
        }

        /// <summary>
        /// 来源显示
        /// </summary>
        /// 
        [HttpGet]
        [Route("/api/LaiShow")]
        public List<SourceMod> LaiShow()
        {
            return _studentManagement.LaiShow();
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
