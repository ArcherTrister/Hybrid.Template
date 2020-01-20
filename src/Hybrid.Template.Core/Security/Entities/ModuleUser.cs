﻿// -----------------------------------------------------------------------
//  <copyright file="ModuleUser.cs" company="Hybrid开源团队">
//      Copyright (c) 2014-2019 Hybrid. All rights reserved.
//  </copyright>
//  <site>https://www.lxking.cn</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2019-01-06 15:25</last-date>
// -----------------------------------------------------------------------

using System.ComponentModel;

using Hybrid.Template.Identity.Entities;

using Hybrid.Security;


namespace Hybrid.Template.Security.Entities
{
    /// <summary>
    /// 实体类：模块用户信息
    /// </summary>
    [Description("用户模块信息")]
    public class ModuleUser : ModuleUserBase<int, int>
    {
        /// <summary>
        /// 获取或设置 模块信息
        /// </summary>
        public virtual Module Module { get; set; }

        /// <summary>
        /// 获取或设置 用户信息
        /// </summary>
        public virtual User User { get; set; }
    }
}