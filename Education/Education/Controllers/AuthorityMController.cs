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
        /// 全部角色
        /// </summary>
        [HttpGet]
        [Route("/api/PartShow")]
        public List<PartMod> PartShow()
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
        public List<MenuMod> MenuShowNT()
        {
            List<MenuMod> menuMods = _authorityManagement.PermissionShowNT();

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
            return _authorityManagement.RetrievePassword(ConsumerIPhone, ConsumerPwd);
        }

    }
}
