﻿// -----------------------------------------------------------------------
//  <copyright file="RegisterEventData.cs" company="Hybrid开源团队">
//      Copyright (c) 2014-2018 Hybrid. All rights reserved.
//  </copyright>
//  <site>https://www.lxking.cn</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2018-06-27 4:44</last-date>
// -----------------------------------------------------------------------

using Hybrid.Template.Identity.Dtos;
using Hybrid.Template.Identity.Entities;

using Hybrid.EventBuses;


namespace Hybrid.Template.Identity.Events
{
    /// <summary>
    /// 注册事件数据
    /// </summary>
    public class RegisterEventData : EventDataBase
    {
        /// <summary>
        /// 获取或设置 注册信息
        /// </summary>
        public RegisterDto RegisterDto { get; set; }

        /// <summary>
        /// 获取或设置 注册用户
        /// </summary>
        public User User { get; set; }
    }
}