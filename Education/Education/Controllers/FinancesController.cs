using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IEducation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Education.Controllers
{
    //财务管理控制器
    [Route("api/[controller]")]
    [ApiController]
    public class FinancesController : ControllerBase
    {
        private IFinances _finances;
        public FinancesController(IFinances finances)
        {
            _finances = finances;
        }
    }
}
