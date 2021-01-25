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
        /// <summary>
        /// 教师信息显示
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        [Route("/api/TeacherShow")]
        [HttpGet]
        public string TeacherShow(int jibie=0,int leibie=0,string iphone="",string name="")
        {
            List<TeacherMod> ll= _teacherManagement.TeacherShow(jibie, leibie, iphone, name);
            var data = new {
                code = 0,
                msg = "",
                count = ll.Count(),
                data = ll,
            };
            return JsonConvert.SerializeObject(data);
        }

        #region 教师管理信息
        //添加教师管理信息
        [Route("api/AddTeacherMod")]
        [HttpPost]
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
        public TeacherMod ModifyIdTeacherMod(int teacherid)
        {
            _logger.LogInformation("反填教师管理日志");
            return _teacherManagement.ModifyIdTeacherMod(teacherid);
        }
        //修改教师管理信息
        [Route("api/ModifyTeacherMod")]
        [HttpPost]
        public int ModifyTeacherMod(TeacherMod t)
        {
            _logger.LogInformation("修改教师管理日志");
            return _teacherManagement.ModifyTeacherMod(t);
        }
        //绑定教师管理显示1
        [Route("api/TeacherMods")]
        [HttpGet]
        public List<TeacherMod> TeacherMods(string teaname, string phone, int jigou, int tduid)
        {
            _logger.LogInformation("教师管理显示下拉");
            List<TeacherMod> Organs = _teacherManagement.GetTeacherMods(teaname, phone, jigou, tduid);
            return Organs;
        }
        //教师管理显示1
        [Route("api/GetTeacherMod")]
        [HttpGet]
        public string GetTeacherMods(string teaname, string phone, int jigou, int tduid, int PageIndex = 1, int PageSize = 1)
        {
            _logger.LogInformation("显示教师管理日志");
            List<TeacherMod> teaches = _teacherManagement.GetTeacherMods(teaname, phone, jigou, tduid);
            var list = new
            {
                code = 0,
                msg = "",
                count = teaches.Count(),
                data = teaches.Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList(),
            };
            return JsonConvert.SerializeObject(list);
        }
        #endregion
        //教学信息显示
        [Route("api/GetTeaches")]
        [HttpGet]
        public string GetTeaches(string teaname, string phone, int jigou, int sub, int bookid, int state, int PageIndex = 1, int PageSize = 1)
        {
            //记录日志
            _logger.LogInformation("教学管理显示");
            List<TeachMod> teaches = _teacherManagement.GetTeaches(teaname, phone, jigou, sub, bookid, state);
            var list = new
            {
                code = 0,
                msg = "",
                count = teaches.Count(),
                data = teaches.Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList(),
            };
            return JsonConvert.SerializeObject(list);
        }
        //修改教师管理状态
        [Route("api/ModifyTeacherState")]
        [HttpPost]
        public int ModifyTeacherState(int status, int teaid)
        {
            _logger.LogInformation("教学修改状态管理日志");
            return _teacherManagement.ModifyTeacherState(status, teaid);
        }
        #region 教学基本信息
        //教学基本信息显示
        [Route("api/GetTeachMods")]
        [HttpGet]
        public string GetTeachMods()
        {
            _logger.LogInformation("教学管理日志");
            List<TeachMod> teaches = _teacherManagement.GetTeachMods();
            var list = new
            {
                code = 0,
                msg = "",
                count = teaches.Count(),
                data = teaches,
            };
            return JsonConvert.SerializeObject(list);
        }
        //教学基本信息新增
        [Route("api/AddTeachMod")]
        [HttpPost]
        public int AddTeachMod(TeachMod tea)
        {
            _logger.LogInformation("添加教学管理日志");
            tea.TeacherTime = DateTime.Now;
            return _teacherManagement.AddTeachMod(tea);
        }
        //教学基本信息反填
        [Route("api/ModifyIdTeachMod")]
        [HttpGet]
        public TeachMod ModifyIdTeachMod(int id)
        {
            _logger.LogInformation("反填教学管理日志");
            return _teacherManagement.ModifyIdTeachMod(id);
        }
        //教学基本信息修改
        [Route("api/ModifyTeachMod")]
        [HttpPost]
        public int ModifyTeachMod(TeachMod tea)
        {
            _logger.LogInformation("修改教学管理日志");
            return _teacherManagement.ModifyTeachMod(tea);
        }
        //教学基本信息删除
        [Route("api/DeleteTeachMod")]
        [HttpPost]
        public int DeleteTeachMod(int ids)
        {
            _logger.LogInformation("添加教学管理日志");
            return _teacherManagement.DeleteTeachMod(ids);
        }
        #endregion
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
