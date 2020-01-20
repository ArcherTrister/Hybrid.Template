// -----------------------------------------------------------------------
//  <copyright file="ModuleConfiguration.cs" company="Hybrid开源团队">
//      Copyright (c) 2014-2018 Hybrid. All rights reserved.
//  </copyright>
//  <site>https://www.lxking.cn</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2018-06-27 4:48</last-date>
// -----------------------------------------------------------------------

using Hybrid.Template.Security.Entities;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Hybrid.Entity;


namespace Hybrid.Template.EntityConfiguration.Security
{
    /// <summary>
    /// 模块信息映射配置类
    /// </summary>
    public class ModuleConfiguration : EntityTypeConfigurationBase<Module, int>
    {
        /// <summary>
        /// 重写以实现实体类型各个属性的数据库配置
        /// </summary>
        /// <param name="builder">实体类型创建器</param>
        public override void Configure(EntityTypeBuilder<Module> builder)
        {
            builder.HasOne(m => m.Parent).WithMany(m => m.Children).HasForeignKey(m => m.ParentId).IsRequired(false);

            builder.HasData(
                new Module() { Id = 1, Name = "根节点", Remark = "系统根节点", Code = "Root", OrderCode = 1, TreePathString = "$1$" }
            );
        }
    }
}