using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationMODEL.linkModel;
using EducationMODEL.TeachingManagement;
using IEducation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
namespace Education.Controllers
{
    /// <summary>
    /// 教学管理控制器
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TeachingMController : ControllerBase
    {
        private readonly ILogger<TeachingMController> _logger;
        private ITeachingManagement _teachingManagement;
        /// <summary>
        /// 教学管理控制器接口
        /// </summary>
        /// <param name="teachingManagement"></param>
        public TeachingMController(ITeachingManagement teachingManagement, ILogger<TeachingMController> logger)
        {
            _logger = logger;
            _teachingManagement = teachingManagement;
        }
       
       //课堂管理显示
       [HttpGet]
       [Route("/TeachingM/ManagementShow")]
        public string ManagementShow(int PageIndex=1,int PageSize=3,string OrganName = "", string BusinessTypeName = "", string ClassModelName = "", string AuditionType = "", string HourTypeName = "", string AuditionState = "", string StudyName = "", string SubjectsName = "",string OrganPhoneName="",string TeacherName="",DateTime ? AuditionTime1=null,DateTime? AuditionTime=null, string StudentName = "")
        {
            if (BusinessTypeName == "1")
            {
                BusinessTypeName = "线上";
            }
            if (BusinessTypeName == "2")
            {  
                BusinessTypeName = "线下";
            }
            if (AuditionType == "1")
            {
                AuditionType = "试听课";
            }
            if (AuditionType == "2")
            {
                AuditionType = "正式课";
            }

            List<ClassroomManagement> list = _teachingManagement.ManagementShow(OrganName, BusinessTypeName, ClassModelName, AuditionType, HourTypeName, AuditionState, StudyName, SubjectsName, OrganPhoneName, TeacherName, AuditionTime1, AuditionTime, StudentName);
            foreach (var item in list)
            {
                item.Data = item.AuditionDate.ToString("yyyy-MM-dd");
            }
            var cc = new
            {
                code = 0,
                msg = "",
                count = list.Count,
                data = list.Skip((PageIndex-1)* PageSize).Take(PageSize).ToList()
            };
           
            return JsonConvert.SerializeObject(cc);
        }
        //查看
        [HttpGet]
        [Route("/TeachingM/Examine")]
        public List<ClassroomManagement> Examine(string StudentId)
        {


            List<ClassroomManagement> list= _teachingManagement.Examine(StudentId);
            foreach (var item in list)
            {
                item.Data = item.AuditionDate.ToString("yyyy-MM-dd");
            }
            return list;
        }
        //下拉机构下拉
        [HttpGet]
        [Route("/TeachingM/Organ")]
        public List<Managethedrop_down> Organ()
        {

            List<Managethedrop_down> list = _teachingManagement.Organ();
            return list;

        }
        //业务类型下拉
        [HttpGet]
        [Route("/TeachingM/BusinessType")]
        public List<Managethedrop_down> BusinessType()
        {
            List<Managethedrop_down> list = _teachingManagement.BusinessType();
            return list;
        }
        //班型下拉
        [HttpGet]
        [Route("/TeachingM/ClassModel")]
        public List<Managethedrop_down> ClassModel()
        {
            List<Managethedrop_down> list = _teachingManagement.ClassModel();
            return list;
        }
        //课时类型下拉
        [HttpGet]
        [Route("/TeachingM/HourType")]
        public List<Managethedrop_down> HourType()
        {
            List<Managethedrop_down> list = _teachingManagement.HourType();
            return list;
        }
        //年级下拉
        [HttpGet]
        [Route("/TeachingM/Study")]
        public List<Managethedrop_down> Study()
        {
            List<Managethedrop_down> list = _teachingManagement.Study();
            return list;
        }
        //学科下拉
        [HttpGet]
        [Route("/TeachingM/Subjects")]
        public List<Managethedrop_down> Subjects()
        {
            List<Managethedrop_down> list = _teachingManagement.Subjects();
            return list;
        }
        //添加申请退款
        [HttpPost]
        [Route("/TeachingM/DropClass")]
        public int DropClass(DropClassMod DropClass)
         {
            int i = _teachingManagement.DropClass(DropClass);
            return i;
        }

        //退课申请单查看
        [HttpGet]
        [Route("/TeachingM/DropClassModShow")]
        public string DropClassModShow()
        {
            List<DropClassModShow> lsit= _teachingManagement.DropClassModShow();
            var cc = new
            {
                code = 0,
                msg = "",
                count = lsit.Count,
                data = lsit
            };
            return JsonConvert.SerializeObject(cc);
        }
        //返还课申请单
        [HttpGet]
        [Route("/TeachingM/ReturnClass")]
        public string ReturnClass()
        {
            List<ClassroomManagement> lsit = _teachingManagement.ReturnClass();
            foreach (var item in lsit)
            {
                item.Data = item.AuditionDate.ToString("yyyy-MM-dd");
            }
            var cc = new
            {
                code = 0,
                msg = "",
                count = lsit.Count,
                data = lsit
            };
            return JsonConvert.SerializeObject(cc);
        }
        //添加返还课
        [HttpPost]
        [Route("/TeachingM/FAFSAAdd")]
        public  int FAFSAAdd(FAFSAMod FAFSAAdd)
        {
            int i = _teachingManagement.FAFSAAdd(FAFSAAdd);
            return i;
        }
        //查询反还课
        [HttpGet]
        [Route("/TeachingM/FAFSAShow")]
        public string FAFSAShow(string OrganName = "", string BusinessTypeName = "", string ClassModelName = "", string AuditionType = "", string HourTypeName = "", string AuditionState = "", string StudyName = "", string SubjectsName = "", string OrganPhoneName = "", string TeacherName = "", DateTime? AuditionTime1 = null, DateTime? AuditionTime = null, string StudentName = "")
        {
            List<ClassroomManagement> list= _teachingManagement.FAFSAShow(OrganName, BusinessTypeName, ClassModelName, AuditionType, HourTypeName, AuditionState, StudyName, SubjectsName, OrganPhoneName, TeacherName, AuditionTime1, AuditionTime, StudentName);
            foreach (var item in list)
            {
                item.Data = item.AuditionDate.ToString("yyyy-MM-dd");
            }
            var cc = new
            {
                code = 0,
                msg = "",
                count = list.Count,
                data = list
            };
            return JsonConvert.SerializeObject(cc);
        }
        //查询通过的返还课
        [HttpGet]
        [Route("/TeachingM/FAFSAShow1")]
        public string FAFSAShow1(string OrganName = "", string BusinessTypeName = "", string ClassModelName = "", string AuditionType = "", string HourTypeName = "", string AuditionState = "", string StudyName = "", string SubjectsName = "", string OrganPhoneName = "", string TeacherName = "", DateTime? AuditionTime1 = null, DateTime? AuditionTime = null, string StudentName = "")
        {
            List<ClassroomManagement> list = _teachingManagement.FAFSAShow(OrganName, BusinessTypeName, ClassModelName, AuditionType, HourTypeName, AuditionState, StudyName, SubjectsName, OrganPhoneName, TeacherName, AuditionTime1, AuditionTime, StudentName);
            list = list.Where(p => p.AuditStatus.Equals(1)).ToList();            
            foreach (var item in list)
            {
                item.Data = item.AuditionDate.ToString("yyyy-MM-dd");
            }
            var cc = new
            {
                code = 0,
                msg = "",
                count = list.Count,
                data = list
            };
            return JsonConvert.SerializeObject(cc);
        }
        //删除反填课
        [HttpGet]
        [Route("/TeachingM/FAFSADel")]
        public  int FAFSADel(int id)
        {
            int i = _teachingManagement.FAFSADel(id);
            return i;
        }
        //返还表的审核//修改
        [HttpGet]
        [Route("/TeachingM/FAFSAUpt")]
        public int FAFSAUpt(int tate, string id, string name)
        {
            int i = _teachingManagement.FAFSAUpt(tate,id, name);

            return i;
        }
    }
}
