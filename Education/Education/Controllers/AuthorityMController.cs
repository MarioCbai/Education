using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationMODEL.AuthorityManagement;
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

    }
}
