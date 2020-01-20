﻿// -----------------------------------------------------------------------
//  <copyright file="ModuleUserConfiguration.cs" company="Hybrid开源团队">
//      Copyright (c) 2014-2018 Hybrid. All rights reserved.
//  </copyright>
//  <site>https://www.lxking.cn</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2018-06-27 4:48</last-date>
// -----------------------------------------------------------------------

using System;

using Hybrid.Template.Identity.Entities;
using Hybrid.Template.Security.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Hybrid.Entity;


namespace Hybrid.Template.EntityConfiguration.Security
{
    /// <summary>
    /// 模块用户信息映射配置类
    /// </summary>
    public class ModuleUserConfiguration : EntityTypeConfigurationBase<ModuleUser, Guid>
    {
        /// <summary>
        /// 重写以实现实体类型各个属性的数据库配置
        /// </summary>
        /// <param name="builder">实体类型创建器</param>
        public override void Configure(EntityTypeBuilder<ModuleUser> builder)
        {
            builder.HasIndex(m => new { m.ModuleId, m.UserId }).HasName("ModuleUserIndex").IsUnique();

            builder.HasOne<Module>(mu => mu.Module).WithMany().HasForeignKey(m => m.ModuleId);
            builder.HasOne<User>(mu => mu.User).WithMany().HasForeignKey(m => m.UserId);
        }
    }
}