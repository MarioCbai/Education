using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationMODEL.OrderManagement;
using EducationMODEL.organizational;
using EducationMODEL.students;
using IEducation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Education.Controllers
{
    /// <summary>
    /// 机构管理管理控制器
    /// </summary>
    //[Route("api/[controller]/[action]")]
    [ApiController]
    public class InstitutionMController : ControllerBase
    {
        private readonly ILogger<IndentMController> _logger;
        private IInstitutionManagement _institutionManagement;
        /// <summary>
        /// 机构管理管理控制器接口
        /// </summary>
        /// <param name="institutionManagement"></param>
        public InstitutionMController(IInstitutionManagement institutionManagement, ILogger<IndentMController> logger)
        {
            _logger = logger;
            _institutionManagement = institutionManagement;
        }
        #region 机构管理

        //机构管理显示陈
        [Route("api/GetOrganMod")]
        [HttpGet]
        public List<OrganMod> GetOrganMod()
        {
            //记录日志
            _logger.LogInformation("机构管理显示");
            List<OrganMod> Organs = _institutionManagement.GetOrganMods();
            return Organs;
        }
        //机构管理下拉
        [Route("api/OrganMods")]
        [HttpGet]
        public List<OrganMod> OrganMods()
        {
            _logger.LogInformation("机构管理显示下拉");
            List<OrganMod> Organs = _institutionManagement.OrganMods();
            return Organs;
        }

        //机构管理显示
        [Route("api/GetOrganMods")]
        [HttpGet]
        public string GetOrganMods(int OrganId, string name = null, int PageIndex = 1, int PageSize = 1)
        {
            //记录日志
            _logger.LogInformation("机构管理显示");

            List<OrganMod> Organs = _institutionManagement.GetOrganMods(name);
            if(OrganId != 0)
            {
                Organs = Organs.Where(p => p.OrganId.Equals(OrganId)).ToList();
            }           
            var list = new
            {
                code = 0,
                msg = "",
                count = Organs.Count(),
                data = Organs.Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList(),
            };
            return JsonConvert.SerializeObject(list);
        }
        [HttpPost]
        [Route("api/AddOrganes")]
        //添加机构管理
        public int AddOrganes(OrganMod organ)
        {
            //添加日志
            _logger.LogInformation("添加机构管理信息");
            organ.OrganBeginTime = DateTime.Now;
            organ.PriceRankId = 1;
            return _institutionManagement.AddOrganes(organ);
        }
        //反填机构管理信息 
        [HttpGet]
        [Route("api/ModiyIdOrganes")]
        public OrganMod ModiyIdOrganes(int orgid)
        {
            //反填日志
            _logger.LogInformation("回显机构管理信息");
            return _institutionManagement.ModiyIdOrganes(orgid);
        }
        //修改机构管理信息
        [HttpPost]
        [Route("api/ModiyOrganes")]
        public int ModiyOrganes(OrganMod organ)
        {
            //修改日志
            _logger.LogInformation("修改机构管理信息");
            return _institutionManagement.ModiyOrganes(organ);
        }

        //单删除机构管理信息
        [HttpPost]
        [Route("api/DeleteOrganes")]
        public int DeleteOrganes(int ids)
        {
            //删除日志
            _logger.LogInformation("删除机构管理信息");
            return _institutionManagement.DeleteOrganes(ids);
        }
        ////反填机构管理状态
        //[HttpPost]
        //[Route("api/ModiyIdStates")]
        //public OrganMod ModiyIdStates(int orgids)
        //{
        //    _logger.LogInformation("反填机构管理状态信息");
        //    return _institutionManagement.ModiyIdStates(orgids);
        //}

        //修改机构管理状态
        [HttpPost]
        [Route("api/ModiyStates")]
        public int ModiyStates(int status, int orgid)
        {
            _logger.LogInformation("修改机构管理状态信息");
            return _institutionManagement.ModiyStates(status, orgid);
        }
        //查询顶级节点
        [Route("api/GetLists")]
        [HttpGet]
        public List<OrganMod> GetLists()
        {
            //记录日志
            _logger.LogInformation("机构递归管理显示");
            List<OrganMod> Organs = _institutionManagement.GetList();
            return Organs;
        }
        //绑定上级机构
        [Route("api/GetOrganName")]
        [HttpGet]
        public string GetOrganName()
        {
            _logger.LogInformation("机构递归管理显示");
            return JsonConvert.SerializeObject(_institutionManagement.GetOrganName());
        }
        //绑定机构类型
        [Route("api/GetInstitutionalMods")]
        [HttpGet]
        public string GetInstitutionalMods()
        {
            _logger.LogInformation("机构类型显示");
            return JsonConvert.SerializeObject(_institutionManagement.GetInstitutionalMods());
        }
        //绑定省
        [Route("api/GetProvinceId")]
        [HttpGet]
        public string GetProvinceId()
        {
            _logger.LogInformation("省");
            return JsonConvert.SerializeObject(_institutionManagement.GetProvinceId());
        }
        //绑定市
        [Route("api/GetCity")]
        [HttpGet]
        public string GetCity()
        {
            _logger.LogInformation("市");
            return JsonConvert.SerializeObject(_institutionManagement.GetCity());
        }
        //绑定区
        [Route("api/GetDistrict")]
        [HttpGet]
        public string GetDistrict()
        {
            _logger.LogInformation("区");
            return JsonConvert.SerializeObject(_institutionManagement.GetDistrict());
        }
        #endregion
        #region 班级管理
        [Route("api/GetClassRooms")]
        [HttpGet]
        //班级管理显示
        public string GetClassRooms(string roomname, int sub, int jigou, int stid, DateTime? HourBeginTime, DateTime? HourEngTime, int PageIndex = 1, int PageSize = 1)
        {
            //记录日志
            _logger.LogInformation("班级管理显示");
            List<ClassRoomMod> classRooms = _institutionManagement.GetClassRooms(roomname,sub, jigou, stid,HourBeginTime,HourEngTime);
            var list = new
            {
                code = 0,
                msg = "",
                count = classRooms.Count(),
                data = classRooms.Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList(),
            };
            return JsonConvert.SerializeObject(list);
        }
        //添加班级管理数据       
        [Route("api/AddClassRooms")]
        [HttpPost]
        public int AddClassRooms(ClassRoomMod Room)
        {
            //记录日志
            _logger.LogInformation("添加班级管理数据");
            return _institutionManagement.AddClassRooms(Room);
        }
        //反填班级管理
        
        [Route("api/ModifyIdClassRoomMod")]
        [HttpGet]
        public ClassRoomMod ModifyIdClassRoomMod(int id)
        {
            _logger.LogInformation("反填班级管理数据");
            return _institutionManagement.ModifyIdClassRoomMod(id);
        }
        //修改班级管理数据
       
        [Route("api/ModifyClassRoomMod")]
        [HttpPost]
        public int ModifyClassRoomMod(ClassRoomMod Room)
        {
            _logger.LogInformation("修改班级管理数据");
            return _institutionManagement.ModifyClassRoomMod(Room);
        }
        //单删除班级管理信息

        [Route("api/DeleteClassRoomMod")]
        [HttpPost]
        public int DeleteClassRoomMod(int ids)
        {
            _logger.LogInformation("删除班级管理数据");
            return _institutionManagement.DeleteClassRoomMod(ids);
        }
        //绑定年级下拉
        [Route("api/GetRoomStudys")]
        [HttpGet]
        public List<Study> GetRoomStudys()
        {
            _logger.LogInformation("下拉班级数据");
            return _institutionManagement.GetRoomStudys();
        }
        //绑定版本下拉
        [Route("api/GetTextbookMod")]
        [HttpGet]
        public List<TextbookMod> GetTextbookMod()
        {
            _logger.LogInformation("下拉版本数据");
            return _institutionManagement.GetTextbookMod();
        }
        #endregion
        #region 科目表
        //科目表显示
        [Route("api/GetSubjects")]
        [HttpGet]
        public List<SubjectsMod> GetSubjects()
        {
            _logger.LogInformation("查询科目表数据");
            return _institutionManagement.GetSubjects();
        }
        #endregion
        #region 学期表
        //学期表显示
        [Route("api/GetSemesters")]
        [HttpGet]
        public List<SemesterMod> GetSemesters()
        {
            _logger.LogInformation("查询科目表数据");
            return _institutionManagement.GetSemesters();
        }
        #endregion
        #region 课时包
        //课时包显示
        [Route("api/HourTableMods")]
        [HttpGet]
        public string HourTableMods()
        {
            _logger.LogInformation("查询课时包数据");
            List<HourTableMod> hours = _institutionManagement.HourTableMods();
            var list = new
            {
                code = 0,
                msg = "",
                count = hours.Count(),
                data = hours,
            };
            return JsonConvert.SerializeObject(list);
        }
        //课时包反填
        [Route("api/ModifyIdHourTableMods")]
        [HttpGet]
        public HourTableMod ModifyIdHourTableMods(int id)
        {
            _logger.LogInformation("反填课时包数据");
            return _institutionManagement.ModifyIdHourTableMods(id);
        }
        //课时包修改
        [Route("api/ModifyHourTableMods")]
        [HttpPost]
        public int ModifyHourTableMods(HourTableMod hour)
        {
            _logger.LogInformation("修改课时包数据");            
            return _institutionManagement.ModifyHourTableMods(hour);
        }
        #endregion
    }
}
