using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationMODEL.Infrastructure;
using EducationMODEL.linkModel;
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
        public string SourceShow(string name = null)
        {
            List<SourceMod> ss = _essentialData.SourceShow(name);
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

        //教师类别管理
        /// <summary>
        /// 教师类别显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/TeacherSortShow")]
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

        //教师水平级别管理
        /// <summary>
        /// 教师水平级别显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/TeacherLevelShow")]
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
        [Route("/api/TeachinglevelMod")]
        [HttpGet]
        public TeachinglevelMod TeacherLevelSelectById(int id)
        {
            return _essentialData.TeacherLevelSelectById(id);
        }

        //教师教学风格管理
        /// <summary>
        /// 教师教学风格显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/TeacherStyleShow")]
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
        //课时类型管理
        /// <summary>
        /// 课时类型显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/ClassTypeShow")]
        public string ClassTypeShow()
        {
            List<Subjects_HourT_Mod> ss = _essentialData.ClassTypeShow();
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
        public int ClassTypeAdd(HourTypeMod s)
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
        public int ClassTypeUpt(HourTypeMod s)
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
        public HourTypeMod ClassTypeSelectById(int id)
        {
            return _essentialData.ClassTypeSelectById(id);
        }

        //班型管理
        /// <summary>
        /// 班型管理显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/ClasstypeManagementShow")]
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
        [HttpGet]
        [Route("/api/PriceLevelShow")]
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
        [HttpPost]
        public PriceRankMod PriceLevelSelectById(int id)
        {
            return _essentialData.PriceLevelSelectById(id);
        }

        //定价管理
        /// <summary>
        /// 定价管理显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/PricingManagementShow")]
        public string PricingManagementShow(int price = -1, int studying = -1, int hour = -1, int? hourprice = null, int? pricehour = null)
        {
            List<Subjects_HourT_Mod> ss = _essentialData.PricingManagementShow(price, studying, hour, hourprice, pricehour);
            var date = new
            {
                code = 0,
                msg = "",
                count = ss.Count,
                data = ss.ToList(),
            };
            return JsonConvert.SerializeObject(date);
        }
        
    }
}
