// -----------------------------------------------------------------------
//  <copyright file="SignalrPack.cs" company="Hybrid开源团队">
//      Copyright (c) 2014-2018 Hybrid. All rights reserved.
//  </copyright>
//  <site>https://www.lxking.cn</site>
//  <last-editor></last-editor>
//  <last-date>2018-07-26 12:15</last-date>
// -----------------------------------------------------------------------

using Microsoft.AspNetCore.SignalR;
using Hybrid.AspNetCore.SignalR;
using System;
using System.ComponentModel;


namespace Hybrid.Template.Web.Startups
{
    /// <summary>
    /// SignalR模块
    /// </summary>
    [Description("SignalR模块")]
    public class SignalRPack : SignalRPackBase
    {
#if NETCOREAPP2_2
        /// <summary>
        /// 重写以获取Hub路由创建委托
        /// </summary>
        /// <param name="serviceProvider">服务提供者</param>
        /// <returns></returns>
        protected override Action<HubRouteBuilder> GetHubRouteBuildAction(IServiceProvider serviceProvider)
        {
            return new Action<HubRouteBuilder>(builder =>
            {
                // 在这实现Hub的路由映射
                // 例如：builder.MapHub<MyHub>();
            });
        }
#endif 
    }
}