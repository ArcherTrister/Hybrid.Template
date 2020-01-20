// -----------------------------------------------------------------------
//  <copyright file="EntityRoleConfiguration.cs" company="Hybrid开源团队">
//      Copyright (c) 2014-2019 Hybrid. All rights reserved.
//  </copyright>
//  <site>https://www.lxking.cn</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2019-01-06 15:16</last-date>
// -----------------------------------------------------------------------

using System;

using Hybrid.Template.Identity.Entities;
using Hybrid.Template.Security.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Hybrid.Core.EntityInfos;
using Hybrid.Entity;


namespace Hybrid.Template.EntityConfiguration.Security
{
    public class EntityRoleConfiguration : EntityTypeConfigurationBase<EntityRole, Guid>
    {
        /// <summary>
        /// 重写以实现实体类型各个属性的数据库配置
        /// </summary>
        /// <param name="builder">实体类型创建器</param>
        public override void Configure(EntityTypeBuilder<EntityRole> builder)
        {
            builder.HasIndex(m => new { m.EntityId, m.RoleId, m.Operation }).HasName("EntityRoleIndex").IsUnique();

            builder.HasOne<EntityInfo>(er => er.EntityInfo).WithMany().HasForeignKey(m => m.EntityId);
            builder.HasOne<Role>(er => er.Role).WithMany().HasForeignKey(m => m.RoleId);
        }
    }
}