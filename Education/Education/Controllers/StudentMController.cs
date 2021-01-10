using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IEducation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Education.Controllers
{
    //学员管理控制器
    [Route("api/[controller]")]
    [ApiController]
    public class StudentMController : ControllerBase
    {
        private IStudentManagement _studentManagement;
        public StudentMController(IStudentManagement studentManagement)
        {
            _studentManagement = studentManagement;
        }
    }
}
