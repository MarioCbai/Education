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
    /// 教师管理控制器
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TeacherMController : ControllerBase
    {
        private ITeacherManagement _teacherManagement;
        /// <summary>
        /// 教师管理控制器接口
        /// </summary>
        /// <param name="teacherManagement"></param>
        public TeacherMController(ITeacherManagement teacherManagement)
        {
            _teacherManagement = teacherManagement;
        }
    }
}
