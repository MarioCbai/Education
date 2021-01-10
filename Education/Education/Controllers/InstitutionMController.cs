using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        private IInstitutionManagement _institutionManagement;
        public InstitutionMController(IInstitutionManagement institutionManagement)
        {
            _institutionManagement = institutionManagement;
        }
    }
}
