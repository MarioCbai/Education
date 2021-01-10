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
    //教学管理控制器
    [Route("api/[controller]")]
    [ApiController]
    public class TeachingMController : ControllerBase
    {
        ITeachingManagement teachingManagement = new TeachingManagementBll();
    }
}
