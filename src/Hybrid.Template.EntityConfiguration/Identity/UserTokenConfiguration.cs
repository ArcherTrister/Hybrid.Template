﻿// -----------------------------------------------------------------------
//  <copyright file="UserTokenConfiguration.cs" company="Hybrid开源团队">
//      Copyright (c) 2014-2019 Hybrid. All rights reserved.
//  </copyright>
//  <site>https://www.lxking.cn</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2019-01-06 14:57</last-date>
// -----------------------------------------------------------------------

using System;

using Hybrid.Template.Identity.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Hybrid.Entity;


namespace Hybrid.Template.EntityConfiguration.Identity
{
    public class UserTokenConfiguration : EntityTypeConfigurationBase<UserToken, Guid>
    {
        /// <summary>
        /// 重写以实现实体类型各个属性的数据库配置
        /// </summary>
        /// <param name="builder">实体类型创建器</param>
        public override void Configure(EntityTypeBuilder<UserToken> builder)
        {
            builder.HasIndex(m => new { m.UserId, m.LoginProvider, m.Name }).HasName("UserTokenIndex").IsUnique();
            builder.HasOne(ut => ut.User).WithMany(u => u.UserTokens).HasForeignKey(ut => ut.UserId).IsRequired();
        }
    }
}