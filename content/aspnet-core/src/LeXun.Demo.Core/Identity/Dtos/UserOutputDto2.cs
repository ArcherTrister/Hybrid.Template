﻿// -----------------------------------------------------------------------
//  <copyright file="UserOutputDto2.cs" company="Hybrid开源团队">
//      Copyright (c) 2014-2018 Hybrid. All rights reserved.
//  </copyright>
//  <site>https://www.lxking.cn</site>
//  <last-editor>ArcherTrister</last-editor>
//  <last-date>2018-06-27 4:44</last-date>
// -----------------------------------------------------------------------

using Hybrid.Entity;
using Hybrid.Mapping;

using LeXun.Demo.Identity.Entities;

namespace LeXun.Demo.Identity.Dtos
{
    /// <summary>
    /// 简单用户输出DTO
    /// </summary>
    [MapFrom(typeof(User))]
    public class UserOutputDto2 : IOutputDto
    {
        /// <summary>
        /// 获取或设置 用户编号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 获取或设置 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 获取或设置 用户昵称
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// 获取或设置 用户邮箱
        /// </summary>
        public string Email { get; set; }
    }
}