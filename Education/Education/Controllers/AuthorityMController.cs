using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationMODEL;
using EducationMODEL.AuthorityManagement;
using EducationMODEL.linkModel;
using IEducation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Education.Controllers
{
    /// <summary>
    /// 权限管理控制器
    /// </summary>
    //[Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthorityMController : ControllerBase
    {
        private IAuthorityManagement _authorityManagement;
        /// <summary>
        /// 连接口
        /// </summary>
        /// <param name="authorityManagement"></param>
        public AuthorityMController(IAuthorityManagement authorityManagement)
        {
            _authorityManagement = authorityManagement;
        }

        /// <summary>
        /// 添加角色权限
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("/api/AddPart")]
        public int AddPart(JueseP j)
        {
            j.data = j.data1.Split(',');
            return _authorityManagement.AddPart(j);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("/api/UptPart")]
        public int UptPart(PartMod dt)
        {
            dt.PMState = 0;
            dt.PCreateTime = DateTime.Now;
            return _authorityManagement.UptPart(dt);
        }

        /// <summary>
        /// 角色状态修改
        /// </summary>
        /// <param name="id"></param>
        /// <param name="val"></param>
        [HttpPost]
        [Route("/api/PartState")]
        public void PartState(int id, int val)
        {
            _authorityManagement.PartState(id, val);
        }


        /// <summary>
        /// 角色查看
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("/api/PartSel")]
        public PartMod PartSel(int id)
        {
            return _authorityManagement.SelPart(id);
        }

        /// <summary>
        /// 角色删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/api/DelPart")]
        public int DelPart(int id)
        {
            return _authorityManagement.DelPart(id);
        }


        /// <summary>
        /// 角色权限状态修改
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("/api/CPState")]
        public void  CPState(int id, int val)
        {
            _authorityManagement.CPState(id, val);
        }

        /// <summary>
        /// 角色用户修改
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/api/UptUserPart")]
        public int UptUserPart(UserPardMod u)
        {
            try
            {
                u.ConsumerPwd = u.ConsumerIPhone.Substring(5, u.ConsumerIPhone.Length);
                u.Createtime = DateTime.Now;
                return _authorityManagement.UptUserPart(u);
            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// 用户角色查询
        /// </summary>
        [HttpPost]
        [Route("/api/UserPartSel")]
        public UserPardMod UserPartSel(int id)
        {
            return _authorityManagement.UserPartSel(id);
        }

        /// <summary>
        /// 用户角色添加
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("/api/UserAdd")]
        public int UserAdd([FromBody] UserPardMod u)
        {
            u.ConsumerPwd = u.ConsumerIPhone.Substring(5);
            u.Createtime = DateTime.Now;
            u.CPState = 0;
            return _authorityManagement.UserAdd(u);
        }

        /// <summary>
        /// 全部角色
        /// </summary>
        [HttpGet]
        [Route("/api/PartShow")]
        public string PartShow(string PartName,string PMState)
        {
            List<PartMod> list = _authorityManagement.PartShow(PartName, PMState);
            foreach (var item in list)
            {
                if (item.PMState == 1)
                {
                    item.Zhuang = "启用";
                }
                else
                {
                    item.Zhuang = "禁用";
                }
                item.date = item.PCreateTime.ToString("yyyy-MM-dd");
            }
            var da =new {
                code = 0,
                msg = "",
                count = list.Count,
                data = list
            };
            return JsonConvert.SerializeObject(da);
        }
        //
        [HttpGet]
        [Route("/api/PartShows")]
        public List<PartMod> PartShows()
        {
            return _authorityManagement.PartShow();
        }

        /// <summary>
        /// 用户角色状态修改
        /// </summary>
        /// <param name=""></param>
        [HttpPost]
        [Route("/api/State")]
        public void State(int id,int val)
        {
            _authorityManagement.State(id,val);
        }

        /// <summary>
        /// 用户角色显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/UserPartShow")]
        public string UserPartShow(int PageIndex=1,int PageSize=3,string name="",string Iphone="",string PartName="",string State="全部",DateTime? StartTime= null, DateTime? EndTime=null)
        {
     
            List<UserPardMod> list= _authorityManagement.UserPartShow( PageIndex, PageSize, name, Iphone, PartName, State, StartTime, EndTime);
            foreach (var item in list)
            {
                if (item.CPState==1)
                {
                    item.Zhuang = "启用";
                }
                else
                {
                    item.Zhuang = "禁用";
                }
                item.date = item.Createtime.ToString("yyyy-MM-dd");
            }
            int counts = _authorityManagement.UserPartShows(name, Iphone, PartName, State, StartTime, EndTime);
            var cc = new
            {
                code=0,
                msg="",
                count= counts,
                data=list
            };
            return JsonConvert.SerializeObject(cc);
        }

        /// <summary>
        /// 权限查询
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("/api/SelMenu")]
        public List<MenuMod> SelMenu(int id)
        {
            List<MenuMod> menuMods = _authorityManagement.SelPermission(id);
            return menuMods;
        }
        /// <summary>
        /// 权限菜单的树显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/MenuShow")]
        public List<MenuMod> MenuShow()
        {
            List<MenuMod> menuMods = _authorityManagement.PermissionShow();
            return menuMods;
        }

        /// <summary>
        /// 权限菜单的显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/MenuShowNT")]
        public List<MenuMod> MenuShowNT(string iphone)
        {
            List<MenuMod> menuMods = _authorityManagement.PermissionShowNT(iphone);

            return menuMods;
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/AuthorityM/Register")]
        public List<ConsumerMod> Register(string ConsumerIPhone, string ConsumerPwd)
        {
            List<ConsumerMod> list = _authorityManagement.Register(ConsumerIPhone, ConsumerPwd);
            return list;
        }
        //查询用户名
        [HttpGet]
        [Route("/AuthorityM/Register2")]
        public List<ConsumerMod> Register2(string ConsumerIPhone)
        {
            List<ConsumerMod> list = _authorityManagement.Register2(ConsumerIPhone);
            return list;
        }
        /// <summary>
        ///  忘记密码/修改
        /// </summary>
        /// <param name="ConsumerIPhone"></param>
        /// <param name="ConsumerPwd"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/AuthorityM/RetrievePassword")]
        public int RetrievePassword(string ConsumerIPhone, string ConsumerPwd)
        {
           int i=_authorityManagement.RetrievePassword(ConsumerIPhone, ConsumerPwd);
            return i;
        }
        //添加角色
      
        [Route("/AuthorityM/AddPart")]
        [HttpPost]
        public int AddPart(PartMod dt)
        {
            dt.PMState = 0;
            dt.PCreateTime = DateTime.Now;
            int permission = _authorityManagement.AddPart(dt);
            return permission;
        }
        //查询用户表
        [HttpGet]
        [Route("/AuthorityM/Register1")]
        public List<ConsumerMod> Register1(string ConsumerIPhone)
        {
            List<ConsumerMod> list = _authorityManagement.Register1(ConsumerIPhone);
            return list;
        }



    }
}
