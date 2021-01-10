using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationBLL;
using IEducation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Education.Controllers
{
    //教师管理控制器
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherMController : ControllerBase
    {
        ITeacherManagement teacherManagement = new TeacherManagementBll();
    }
}
