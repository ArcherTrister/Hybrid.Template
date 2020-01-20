﻿// -----------------------------------------------------------------------
//  <copyright file="UserRoleNode.cs" company="Hybrid开源团队">
//      Copyright (c) 2014-2018 Hybrid. All rights reserved.
//  </copyright>
//  <site>https://www.lxking.cn</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2018-06-27 4:44</last-date>
// -----------------------------------------------------------------------

using Hybrid.Template.Identity.Entities;

using Hybrid.Entity;
using Hybrid.Mapping;


namespace Hybrid.Template.Identity.Dtos
{
    /// <summary>
    /// 用户角色节点
    /// </summary>
    [MapFrom(typeof(Role))]
    public class UserRoleNode : IOutputDto
    {
        /// <summary>
        /// 获取或设置 角色编号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 获取或设置 角色名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 获取或设置 是否选中
        /// </summary>
        public bool IsChecked { get; set; }
    }
}