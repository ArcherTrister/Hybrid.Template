﻿// -----------------------------------------------------------------------
//  <copyright file="AuditEntity.cs" company="Hybrid开源团队">
//      Copyright (c) 2014-2018 Hybrid. All rights reserved.
//  </copyright>
//  <site>https://www.lxking.cn</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2018-08-02 4:17</last-date>
// -----------------------------------------------------------------------

using System;

using Hybrid.Template.Systems.Entities;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Hybrid.Entity;



namespace Hybrid.Template.EntityConfiguration.Systems
{
    public class AuditEntityConfiguration : EntityTypeConfigurationBase<AuditEntity, Guid>
    {
        /// <summary>
        /// 重写以实现实体类型各个属性的数据库配置
        /// </summary>
        /// <param name="builder">实体类型创建器</param>
        public override void Configure(EntityTypeBuilder<AuditEntity> builder)
        {
            builder.HasIndex(m => m.OperationId);
            builder.HasOne(m => m.Operation).WithMany(n => n.AuditEntities).HasForeignKey(m => m.OperationId);
        }
    }
}