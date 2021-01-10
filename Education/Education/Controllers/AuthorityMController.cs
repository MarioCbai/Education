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
    //权限管理控制器
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorityMController : ControllerBase
    {
        IAuthorityManagement authorityManagement = new AuthorityManagementBll();
    }
}
