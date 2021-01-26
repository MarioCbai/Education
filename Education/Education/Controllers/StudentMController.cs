using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationMODEL.Infrastructure;
using EducationMODEL.linkModel;
using EducationMODEL.OrderManagement;
using EducationMODEL.organizational;
using EducationMODEL.students;
using EducationMODEL.TeacherManagement;
using IEducation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Education.Controllers
{
    /// <summary>
    /// 学员管理控制器
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentMController : ControllerBase
    {
        private readonly ILogger<StudentMController> _logger;
        private IStudentManagement _studentManagement;
        /// <summary>
        /// 学员管理控制器接口
        /// </summary>
        /// <param name="studentManagement"></param>
        public StudentMController(IStudentManagement studentManagement, ILogger<StudentMController> logger)
        {
            _logger = logger;
            _studentManagement = studentManagement;
        }



        [HttpGet]
        [Route("/api/ApplyFormallessonsess")]
        public List<StudentLian> ApplyFormallessonsess(int id)
        {
            List<StudentLian> list = _studentManagement.TrialClasss();
            foreach (var item in list)
            {
                if (item.State == 1)
                {
                    item.shen = "通过";
                }
                else if (item.State == 2)
                {
                    item.shen = "驳回";
                }
                else
                {
                    item.shen = "待审核";
                }

                if (item.AuditionState == 1)
                {
                    item.kezhuang = "已上课";
                }
                else if (item.AuditionState == 2)
                {
                    item.kezhuang = "待上课";
                }
                else
                {
                    item.kezhuang = "已取消";
                }
                item.tiem = item.AuditionDate;

            }
            return list.Where(x => x.ASID == id).ToList();
        }


        [HttpGet]
        [Route("/api/ApplyFormallessonses")]
        public List<StudentLian> ApplyFormallessonses(int id)
        {
            List<StudentLian> list = _studentManagement.TrialClass();
            foreach (var item in list)
            {
                if (item.State == 1)
                {
                    item.shen = "通过";
                }
                else if (item.State == 2)
                {
                    item.shen = "驳回";
                }
                else
                {
                    item.shen = "待审核";
                }

                if (item.AuditionState == 1)
                {
                    item.kezhuang = "已上课";
                }
                else if (item.AuditionState == 2)
                {
                    item.kezhuang = "待上课";
                }
                else
                {
                    item.kezhuang = "已取消";
                }
                item.tiem = item.AuditionDate;

            }
            return list.Where(x=>x.ASID==id).ToList();
        }

        //正式课
        [HttpGet]
        [Route("/api/ApplyFormallessons")]
        public string ApplyFormallessons()
        {
            List<StudentLian> list = _studentManagement.TrialClasss();
            foreach (var item in list)
            {
                if (item.State == 1)
                {
                    item.shen = "通过";
                }
                else if (item.State == 2)
                {
                    item.shen = "驳回";
                }
                else
                {
                    item.shen = "待审核";
                }

                if (item.AuditionState == 1)
                {
                    item.kezhuang = "已上课";
                }
                else if (item.AuditionState == 2)
                {
                    item.kezhuang = "待上课";
                }
                else
                {
                    item.kezhuang = "已取消";
                }
                item.tiem = item.AuditionDate;

            }
            var ss = new
            {
                code = 0,
                msg = "",
                count = list.Count,
                data = list
            };

            return JsonConvert.SerializeObject(ss);
        }

        //修改状态
        [HttpPost]
        [Route("/api/xiugai")]
        public int xiugai(int i,int id)
        {
            return _studentManagement.xiugai(i, id);
        }

        // 试听课
        [HttpGet]
        [Route("/api/TrialClass")]
        public string TrialClass(int id)
        {
            try
            {
                List<StudentLian> list = _studentManagement.TrialClass();
                foreach (var item in list)
                {
                    if (item.State == 1)
                    {
                        item.shen = "通过";
                    }
                    else if (item.State == 2)
                    {
                        item.shen = "驳回";
                    }
                    else
                    {
                        item.shen = "待审核";
                    }

                    if (item.AuditionState == 1)
                    {
                        item.kezhuang = "已上课";
                    }
                    else if (item.AuditionState == 2)
                    {
                        item.kezhuang = "待上课";
                    }
                    else
                    {
                        item.kezhuang = "已取消";
                    }
                    item.tiem = item.AuditionDate;
                   
                }

                if (id!=0)
                {
                    list = list.Where(x => x.State == id).ToList();
                }
                var ss = new
                {
                    code = 0,
                    msg = "",
                    count = list.Count,
                    data = list
                };

                return JsonConvert.SerializeObject(ss);
            }
            catch (Exception)
            {

                throw;
            }
           
        }


        //学员详情信息
        [HttpPost]
        [Route("/api/SelStudent")]
        public StudentLian SelStudent(int id)
        {
            StudentLian ll = _studentManagement.SelStudent(id);
            ll.tiem = ll.StudentBirthday.ToString("yyyy-MM-dd");
            return ll;
        }


        //所有学员显示
        [HttpGet]
        [Route("/api/StudentShow")]
        public string StudentShow(int zhuang=-1,int jigou=0, string zi="", string zhi="", int nian=0, string name="", string iphone="")
        {
            List<StudentLian> list = _studentManagement.StudentShow(zhuang, jigou, zi, zhi, nian, name, iphone);
            foreach (var item in list)
            {
                if (item.StudentKind==1)
                {
                    item.zhuang = "成单学员";
                }
                else
                {
                    item.zhuang = "意向学员";
                }
                
            }
            var ss = new
            {
                code = 0,
                msg = "",
                count = list.Count,
                data = list
            };
            return JsonConvert.SerializeObject(ss);
        }


        //正式学员显示
        [HttpGet]
        [Route("/api/ShowOfficial")]
        public string ShowOfficial(int jigou, string zi, string zhi, int nian, string name, string iphone)
        {
            List<StudentLian> list = _studentManagement.ShowOfficial(jigou, zi, zhi, nian, name, iphone);
            var ss = new
            {
                code = 0,
                msg = "",
                count = list.Count,
                data = list
            };
            return JsonConvert.SerializeObject(ss);
        }


        //添加试听课表

        [HttpPost]
        [Route("/api/ScheduleAdd")]
        public int ScheduleAdd(AuditionMod aa)
        {
            return _studentManagement.ScheduleAdd(aa);
        }



        [HttpGet]
        [Route("/api/Xue")]
        public List<Study> Xue(int id)
        {
            return _studentManagement.Xue(id);
        }


        [HttpGet]
        [Route("/api/ShowSan")]
        public StudentMod ShowSan(int id)
        {
            return _studentManagement.ShowSan(id);
        }

        /// <summary>
        /// 家长信息添加
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/api/ParentAdd")]
        public int ParentAdd(PatriarchMod p)
        {
            return _studentManagement.AddParetn(p);
        }


        /// <summary>
        /// 家长信息反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/FanParent")]
        public  PatriarchMod FanParent(int id)
        {
           return  _studentManagement.FanParent(id);
        }
        /// <summary>
        /// 修改家长信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/api/UptParent")]
        public int UptParent(PatriarchMod p)
        {
            return _studentManagement.UptParent(p);
        }

        /// <summary>
        /// 删除家长信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/DelParent")]
        public int DelParent(int id)
        {
            return _studentManagement.DelPatrn(id);
        }

        //家长信息
        [HttpGet]
        [Route("/api/ParntShows")]
        public List<PatriarchMod> ParntShows(int id)
        {
            List<PatriarchMod> list = _studentManagement.PartriarchShow(id);
          
            return list;
        }

        /// <summary>
        /// 家长显示
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/ParntShow")]
        public string ParntShow(int id)
        {
            List<PatriarchMod> list= _studentManagement.PartriarchShow(id);
            var ss = new
            {
                code = 0,
                msg = "",
                count = list.Count,
                data = list
            };
            return JsonConvert.SerializeObject(ss);
        }




        /// <summary>
        /// 地址
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet]
        [Route("/api/Dizhi")]
        public List<SitesMod> Dizhi(int id)
        {
            return _studentManagement.Dizhi(id);
        }



        /// <summary>
        /// 学员添加
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpPost]
        [Route("/api/StudentAdd")]
        public int StudentAdd(StudentMod ss)
        {
            try
            {
                ss.StudentPwd = ss.StudentIphone.Substring(5);
                ss.Counselor = "ccc";
                ss.StudentKind = 0;
                return _studentManagement.StudentAdd(ss);
            }
            catch (Exception)
            {

                throw;
            }
          
        }

        /// <summary>
        /// 来源显示
        /// </summary>
        /// 
        [HttpGet]
        [Route("/api/LaiShow")]
        public List<SourceMod> LaiShow()
        {
            return _studentManagement.LaiShow();
        }


        //学员显示查询
        [HttpGet]
        [Route("/api/StudentShows")]
        public string StudentShow(int jigou, string zi, string zhi, int nian, string name, string iphone)
        {
            List<StudentLian> list = _studentManagement.StudentShow(jigou, zi, zhi, nian, name, iphone);
            var ss = new
            {
                code = 0,
                msg = "",
                count = list.Count,
                data = list
            };
            return JsonConvert.SerializeObject(ss);
        }
    }
}
