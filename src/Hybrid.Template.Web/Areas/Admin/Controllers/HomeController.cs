// -----------------------------------------------------------------------
//  <copyright file="HomeController.cs" company="Hybrid开源团队">
//      Copyright (c) 2014-2018 Hybrid. All rights reserved.
//  </copyright>
//  <site>https://www.lxking.cn</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2018-06-27 4:50</last-date>
// -----------------------------------------------------------------------

using System.ComponentModel;

using Hybrid.Template.Security;

using Microsoft.AspNetCore.Mvc;


namespace Hybrid.Template.Web.Areas.Admin.Controllers
{
    [Description("管理-主页")]
    public class HomeController : AdminApiController
    {
        private readonly SecurityManager _securityManager;

        public HomeController(SecurityManager securityManager)
        {
            _securityManager = securityManager;
        }

        /// <summary>
        /// 获取后台管理主菜单
        /// </summary>
        /// <returns>菜单信息</returns>
        [HttpGet]
        [Description("主菜单")]
        public ActionResult MainMenu()
        {
            return Content("MainMenu");
        }


    }
}