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
    //订单管理
    [Route("api/[controller]")]
    [ApiController]
    public class IndentMController : ControllerBase
    {
        IIndentManagement indentManagement = new IndentManagementBll();
    }
}
