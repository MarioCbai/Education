using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationMODEL;
using EducationMODEL.Infrastructure;
using EducationMODEL.linkModel;
using EducationMODEL.OrderManagement;
using EducationMODEL.organizational;
using IEducation;
using log4net.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
namespace Education.Controllers
{
    /// <summary>
    /// 基本数据管理控制器
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EssentialDataController : ControllerBase
    {
        private readonly ILogger<EssentialDataController> _logger;
        private IEssentialData _essentialData;
        /// <summary>
        /// 基本数据管理控制器连接接口
        /// </summary>
        /// <param name="essentialData"></param>
        public EssentialDataController(IEssentialData essentialData,ILogger<EssentialDataController> logger)
        {
            _logger = logger;
            _essentialData = essentialData;
        }
        //来源管理
        /// <summary>
        /// 来源管理显示
        /// </summary>
        /// <returns></returns>
        [Route("/api/SourceShow")]
        [HttpGet]
        public string SourceShow()
        {
            List<SourceMod> ss = _essentialData.SourceShow();
            var date = new
            {
                code = 0,
                msg = "",
                count = ss.Count,
                data = ss.ToList(),
            };
            return JsonConvert.SerializeObject(date);
        }
        /// <summary>
        /// 来源管理添加
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [Route("/api/SourceAdd")]
        [HttpPost]
        public int SourceAdd(SourceMod s)
        {
            return _essentialData.SourceAdd(s);
        }
        /// <summary>
        /// 来源管理修改
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [Route("/api/SourceUpt")]
        [HttpPost]
        public int SourceUpt(SourceMod s)
        {
            return _essentialData.SourceUpt(s);
        }
        /// <summary>
        /// 来源管理修改状态
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [Route("/api/SourceZtai")]
        [HttpPost]
        public int SourceZtai(int ztai, int id)
        {
            return _essentialData.SourceZtai(ztai, id);
        }
        /// <summary>
        /// 来源表根据id查询反填
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [Route("/api/SourceSelectById")]
        [HttpGet]
        public SourceMod SourceSelectById(int id)
        {
            return _essentialData.SourceSelectById(id);
        }
        /// <summary>
        /// 来源管理判断名称唯一性
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [Route("/api/SourceShowName")]
        [HttpGet]
        public List<SourceMod> SourceShowName(string name)
        {
            return _essentialData.SourceShowName(name);
        }

        //教师类别管理
        /// <summary>
        /// 教师类别显示
        /// </summary>
        /// <returns></returns>
        [Route("/api/TeacherSortShow")]
        [HttpGet]
        public string TeacherSortShow()
        {
            List<TeacherTypeMod> ss = _essentialData.TeacherSortShow();
            var date = new
            {
                code = 0,
                msg = "",
                count = ss.Count,
                data = ss.ToList(),
            };
            return JsonConvert.SerializeObject(date);
        }
        /// <summary>
        /// 教师类别添加
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [Route("/api/TeacherSortAdd")]
        [HttpPost]
        public int TeacherSortAdd(TeacherTypeMod s)
        {
            return _essentialData.TeacherSortAdd(s);
        }
        /// <summary>
        /// 教师类别修改
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [Route("/api/TeacherSortUpt")]
        [HttpPost]
        public int TeacherSortUpt(TeacherTypeMod s)
        {
            return _essentialData.TeacherSortUpt(s);
        }
        /// <summary>
        /// 教师类别修改状态
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [Route("/api/TeacherSortZtai")]
        [HttpPost]
        public int TeacherSortZtai(int ztai, int id)
        {
            return _essentialData.TeacherSortZtai(ztai, id);
        }
        /// <summary>
        /// 教师类别表根据id查询反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("/api/TeacherSortSelectById")]
        [HttpGet]
        public TeacherTypeMod TeacherSortSelectById(int id)
        {
            return _essentialData.TeacherSortSelectById(id);
        }
        /// <summary>
        /// 教师类别表判断名称唯一性
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [Route("/api/TeacherShow")]
        [HttpPost]
        public List<TeacherTypeMod> TeacherShow(string name)
        {
            return _essentialData.TeacherShow(name);
        }


        //教师水平级别管理
        /// <summary>
        /// 教师水平级别显示
        /// </summary>
        /// <returns></returns>
        [Route("/api/TeacherLevelShow")]
        [HttpGet]
        public string TeacherLevelShow()
        {
            List<TeachinglevelMod> ss = _essentialData.TeacherLevelShow();
            var date = new
            {
                code = 0,
                msg = "",
                count = ss.Count,
                data = ss.ToList(),
            };
            return JsonConvert.SerializeObject(date);
        }
        /// <summary>
        /// 教师水平级别添加
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [Route("/api/TeacherLevelAdd")]
        [HttpPost]
        public int TeacherLevelAdd(TeachinglevelMod s)
        {
            return _essentialData.TeacherLevelAdd(s);
        }
        /// <summary>
        /// 教师水平级别修改
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [Route("/api/TeacherLevelUpt")]
        [HttpPost]
        public int TeacherLevelUpt(TeachinglevelMod s)
        {
            return _essentialData.TeacherLevelUpt(s);
        }
        /// <summary>
        /// 教师水平级别修改状态
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [Route("/api/TeacherLevelZtai")]
        [HttpPost]
        public int TeacherLevelZtai(int ztai, int id)
        {
            return _essentialData.TeacherLevelZtai(ztai, id);
        }
        /// <summary>
        /// 教师水平表根据id查询反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("/api/TeacherLevelSelectById")]
        [HttpGet]
        public TeachinglevelMod TeacherLevelSelectById(int id)
        {
            return _essentialData.TeacherLevelSelectById(id);
        }
        /// <summary>
        /// 教师水平表判断姓名唯一性
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [Route("/api/TeacherModShow")]
        [HttpGet]
        public List<TeachinglevelMod> TeacherModShow(string name)
        {
            return _essentialData.TeacherModShow(name);
        }


        //教师教学风格管理
        /// <summary>
        /// 教师教学风格显示
        /// </summary>
        /// <returns></returns>
        [Route("/api/TeacherStyleShow")]
        [HttpGet]
        public string TeacherStyleShow()
        {
            List<TeachingStyleMod> ss = _essentialData.TeacherStyleShow();
            var date = new
            {
                code = 0,
                msg = "",
                count = ss.Count,
                data = ss.ToList(),
            };
            return JsonConvert.SerializeObject(date);
        }
        /// <summary>
        /// 教师教学风格添加
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [Route("/api/TeacherStyleAdd")]
        [HttpPost]
        public int TeacherStyleAdd(TeachingStyleMod s)
        {
            return _essentialData.TeacherStyleAdd(s);
        }
        /// <summary>
        /// 教师教学风格修改
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [Route("/api/TTeacherStyleUpt")]
        [HttpPost]
        public int TTeacherStyleUpt(TeachingStyleMod s)
        {
            return _essentialData.TTeacherStyleUpt(s);
        }
        /// <summary>
        /// 教师风格根据id查询反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("/api/TeacherStyleSelectById")]
        [HttpGet]
        public TeachingStyleMod TeacherStyleSelectById(int id)
        {
            return _essentialData.TeacherStyleSelectById(id);
        }
        /// <summary>
        /// 教师教学风格修改状态
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [Route("/api/TeacherStyleZtai")]
        [HttpPost]
        public int TeacherStyleZtai(int ztai, int id)
        {
            return _essentialData.TeacherStyleZtai(ztai, id);
        }
        /// <summary>
        /// 教师风格表判断姓名唯一性
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [Route("/api/TeacherStyleShowName")]
        [HttpGet]
        public List<TeachingStyleMod> TeacherStyleShowName(string name)
        {
            return _essentialData.TeacherStyleShowName(name);
        }


        //课时类型管理
        /// <summary>
        /// 课时类型显示
        /// </summary>
        /// <returns></returns>
        [Route("/api/ClassTypeShow")]
        [HttpGet]
        public string ClassTypeShow()
        {
            List<GG_SubjectsHourType> ss = _essentialData.ClassTypeShow();
            var date = new
            {
                code = 0,
                msg = "",
                count = ss.Count,
                data = ss.ToList(),
            };
            return JsonConvert.SerializeObject(date);
        }
        /// <summary>
        /// 课时类型添加
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [Route("/api/ClassTypeAdd")]
        [HttpPost]
        public int ClassTypeAdd(SubjectsHourTypeMod s)
        {
            return _essentialData.ClassTypeAdd(s);
        }
        /// <summary>
        /// 课时类型修改
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [Route("/api/ClassTypeUpt")]
        [HttpPost]
        public int ClassTypeUpt(SubjectsHourTypeMod s)
        {

            return _essentialData.ClassTypeUpt(s);
        }
        /// <summary>
        /// 课时类型修改状态
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [Route("/api/ClassTypeZtai")]
        [HttpPost]
        public int ClassTypeZtai(int ztai, int id)
        {
            return _essentialData.ClassTypeZtai(ztai, id);
        }
        /// <summary>
        /// 课时表根据id查询反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("/api/ClassTypeSelectById")]
        [HttpGet]
        public GG_SubjectsHourType ClassTypeSelectById(int id)
        {
            return _essentialData.ClassTypeSelectById(id);
        }
        /// <summary>
        /// 查询科目表绑定下拉
        /// </summary>
        /// <returns></returns>
        [Route("/api/ClassTypeSelectAll")]
        [HttpGet]
        public string ClassTypeSelectAll()
        {
            return JsonConvert.SerializeObject(_essentialData.ClassTypeSelectAll());
        }
        /// <summary>
        /// 查询课时表绑定下拉
        /// </summary>
        /// <returns></returns>
        [Route("/api/HourTypeSelectAll")]
        [HttpGet]
        public string HourTypeSelectAll()
        {
            return JsonConvert.SerializeObject(_essentialData.HourTypeSelectAll());
        }



        //班型管理
        /// <summary>
        /// 班型管理显示
        /// </summary>
        /// <returns></returns>
        [Route("/api/ClasstypeManagementShow")]
        [HttpGet]
        public string ClasstypeManagementShow()
        {
            List<ClassModelMod_BusinessTypeMod> ss = _essentialData.ClasstypeManagementShow();
            var date = new
            {

                code = 0,
                msg = "",
                count = ss.Count,
                data = ss.ToList(),
            };
            return JsonConvert.SerializeObject(date);
        }


        //价格级别管理
        /// <summary>
        /// 价格级别显示
        /// </summary>
        /// <returns></returns>
        [Route("/api/PriceLevelShow")]
        [HttpGet]
        public string PriceLevelShow()
        {
            List<PriceRankMod> ss = _essentialData.PriceLevelShow();
            var date = new
            {
                code = 0,
                msg = "",
                count = ss.Count,
                data = ss.ToList(),
            };
            return JsonConvert.SerializeObject(date);
        }
        /// <summary>
        /// 价格级别添加
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [Route("/api/PriceLevelAdd")]
        [HttpPost]
        public int PriceLevelAdd(PriceRankMod s)
        {
            return _essentialData.PriceLevelAdd(s);
        }
        /// <summary>
        /// 价格级别修改
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [Route("/api/PriceLevelUpt")]
        [HttpPost]
        public int PriceLevelUpt(PriceRankMod s)
        {
            return _essentialData.PriceLevelUpt(s);
        }
        /// <summary>
        /// 价格级别修改状态
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [Route("/api/PriceLevelZtai")]
        [HttpPost]
        public int PriceLevelZtai(int ztai, int id)
        {
            return _essentialData.PriceLevelZtai(ztai, id);
        }
        /// <summary>
        /// 价格级别表根据id查询反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("/api/PriceLevelSelectById")]
        [HttpGet]
        public PriceRankMod PriceLevelSelectById(int id)
        {
            return _essentialData.PriceLevelSelectById(id);
        }
        /// <summary>
        /// 价格级别表判断名称唯一性
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [Route("/api/PriceLevelShowName")]
        [HttpGet]
        public List<PriceRankMod> PriceLevelShowName(string name)
        {
            return _essentialData.PriceLevelShowName(name);
        }

        //定价管理
        /// <summary>
        /// 定价管理显示
        /// </summary>
        /// <returns></returns>
        [Route("/api/PricingManagementShow")]
        [HttpGet]
        public string PricingManagementShow(int price = -1, int studying = -1, string name = null, int hourprice = 0, int pricehour = 0, int hour = 0)
        {
            List<Subjects_HourT_Mod> ss = _essentialData.PricingManagementShow(price, studying, name, hourprice, pricehour, hour);
            var date = new
            {
                code = 0,
                msg = "",
                count = ss.Count,
                data = ss.ToList(),
            };
            return JsonConvert.SerializeObject(date);
        }
        /// <summary>
        /// 查询价格级别表绑定下拉
        /// </summary>
        /// <returns></returns>
        [Route("/api/SelectPriceRankModAll")]
        [HttpGet]
        public  string SelectPriceRankModAll()
        {
            return JsonConvert.SerializeObject(_essentialData.SelectPriceRankModAll());
        }
        /// <summary>
        /// 查询学段表绑定下拉
        /// </summary>
        /// <returns></returns>
        [Route("/api/SelectStudyModAll")]
        [HttpGet]
        public string SelectStudyModAll()
        {
            return JsonConvert.SerializeObject(_essentialData.SelectStudyModAll());
        }
        /// <summary>
        /// 查询课时表绑定下拉
        /// </summary>
        /// <returns></returns>
        [Route("/api/HourTypeModAll")]
        [HttpGet]
        public string HourTypeModAll()
        {
            return JsonConvert.SerializeObject(_essentialData.HourTypeModAll());
        }

        /// <summary>
        /// 修改课时单价
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        [Route("/api/PricingManagementUpt")]
        [HttpPost]
        public int PricingManagementUpt(PricingMod m)
        {
            return _essentialData.PricingManagementUpt(m);
        }
    }
}
