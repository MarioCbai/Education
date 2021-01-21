using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationMODEL.linkModel;
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
    }
}
