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
    //机构管理管理控制器
    [Route("api/[controller]")]
    [ApiController]
    public class InstitutionMController : ControllerBase
    {
        IInstitutionManagement institutionManagement = new InstitutionManagementBll();
    }
}
