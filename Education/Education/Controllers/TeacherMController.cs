using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationMODEL.TeacherManagement;
using IEducation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Education.Controllers
{
    /// <summary>
    /// 教师管理控制器
    /// </summary>
    
    [ApiController]
    public class TeacherMController : ControllerBase
    {
        private readonly ILogger<TeacherMController> _logger;
        private ITeacherManagement _teacherManagement;
        /// <summary>
        /// 教师管理控制器接口
        /// </summary>
        /// <param name="teacherManagement"></param>
        public TeacherMController(ITeacherManagement teacherManagement, ILogger<TeacherMController> logger)
        {
            _logger = logger;
            _teacherManagement = teacherManagement;
        }
        #region 教师管理信息
        //添加教师管理信息
        [Route("api/AddTeacherMod")]
        [HttpGet]
        public int AddTeacherMod(TeacherMod t)
        {
            _logger.LogInformation("添加教师管理日志");
            return _teacherManagement.AddTeacherMod(t);
        }
        //删除教师管理信息
        [Route("api/DeleteTeacherMod")]
        [HttpPost]
        public int DeleteTeacherMod(int ids)
        {
            _logger.LogInformation("删除教师管理日志");
            return _teacherManagement.DeleteTeacherMod(ids);
        }
        //反填教师管理信息
        [Route("api/ModifyIdTeacherMod")]
        [HttpGet]
        public TeacherMod ModifyIdTeacherMod(int id)
        {
            _logger.LogInformation("反填教师管理日志");
            return _teacherManagement.ModifyIdTeacherMod(id);
        }
        //修改教师管理信息
        [Route("api/ModifyTeacherMod")]
        [HttpPost]
        public int ModifyTeacherMod(TeacherMod t)
        {
            _logger.LogInformation("修改教师管理日志");
            return _teacherManagement.ModifyTeacherMod(t);
        } //教师管理显示1
        [Route("api/GetTeacherMods")]
        [HttpGet]
        public List<TeacherMod> GetTeacherMods()
        {
            _logger.LogInformation("显示教师管理日志");
            return _teacherManagement.GetTeacherMods();
        }
        #endregion
        //教学信息显示
        [Route("api/GetTeaches")]
        [HttpGet]
        public string GetTeaches()
        {
            //记录日志
            _logger.LogInformation("教学管理显示");
            List<TeachMod> teaches = _teacherManagement.GetTeaches();
            var list = new
            {
                code = 0,
                msg = "",
                count = teaches.Count(),
                data = teaches,
            };
            return JsonConvert.SerializeObject(list);
        }
        #region 认证信息
        //认证信息显示
        [Route("api/GetApproveMods")]
        [HttpGet]
        public List<ApproveMod> GetApproveMods()
        {
            _logger.LogInformation("显示认证信息日志");
            return _teacherManagement.GetApproveMods();
        }
        //认证信息添加
        [Route("api/AddApproveMod")]
        [HttpPost]
        public int AddApproveMod(ApproveMod ap)
        {
            _logger.LogInformation("添加认证信息日志");
            return _teacherManagement.AddApproveMod(ap);
        }
        //认证信息的反填
        [Route("api/ModifyIdApproveMod")]
        [HttpGet]
        public ApproveMod ModifyIdApproveMod(int id)
        {
            _logger.LogInformation("反填认证信息日志");
            return _teacherManagement.ModifyIdApproveMod(id);
        }
        //认证信息的修改
        [Route("api/ModifyApproveMod")]
        [HttpPost]
        public int ModifyApproveMod(ApproveMod ap)
        {
            _logger.LogInformation("修改认证信息日志");
            return _teacherManagement.ModifyApproveMod(ap);
        }
        #endregion

    }
}
