// -----------------------------------------------------------------------
//  <copyright file="FunctionAuthCache.cs" company="Hybrid开源团队">
//      Copyright (c) 2014-2018 Hybrid. All rights reserved.
//  </copyright>
//  <site>https://www.lxking.cn</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2018-06-27 4:44</last-date>
// -----------------------------------------------------------------------

using System;

using Hybrid.Template.Identity.Entities;
using Hybrid.Template.Security.Entities;

using Hybrid.Core.Functions;
using Hybrid.Security;


namespace Hybrid.Template.Security
{
    /// <summary>
    /// 功能权限缓存
    /// </summary>
    public class FunctionAuthCache : FunctionAuthCacheBase<ModuleFunction, ModuleRole, ModuleUser, Function, Module, int, Role, int, User, int>
    {
        /// <summary>
        /// 初始化一个<see cref="FunctionAuthCacheBase{TModuleFunction, TModuleRole, TModuleUser, TFunction, TModule, TModuleKey,TRole, TRoleKey, TUser, TUserKey}"/>类型的新实例
        /// </summary>
        public FunctionAuthCache(IServiceProvider serviceProvider)
            : base(serviceProvider)
        { }
    }
}