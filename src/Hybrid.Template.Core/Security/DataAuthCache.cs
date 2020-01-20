// -----------------------------------------------------------------------
//  <copyright file="DataAuthCache.cs" company="Hybrid开源团队">
//      Copyright (c) 2014-2018 Hybrid. All rights reserved.
//  </copyright>
//  <site>https://www.lxking.cn</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2018-07-04 18:25</last-date>
// -----------------------------------------------------------------------

using System;

using Hybrid.Template.Identity.Entities;
using Hybrid.Template.Security.Entities;

using Hybrid.Core.EntityInfos;
using Hybrid.Security;


namespace Hybrid.Template.Security
{
    /// <summary>
    /// 数据权限缓存
    /// </summary>
    public class DataAuthCache : DataAuthCacheBase<EntityRole, Role, EntityInfo, int>
    {
        /// <summary>
        /// 初始化一个<see cref="DataAuthCacheBase{TEntityRole, TRole, TEntityInfo, TRoleKey}"/>类型的新实例
        /// </summary>
        public DataAuthCache(IServiceProvider serviceProvider)
            : base(serviceProvider)
        { }
    }
}