// -----------------------------------------------------------------------
// <once-generated>
//     这个文件只生成一次，再次生成不会被覆盖。
//     可以在此类进行继承重写来扩展基类 InfosServiceBase
// </once-generated>
//
//  <copyright file="IInfosService.cs" company="Hybrid开源团队">
//      Copyright (c) 2014-2019 Hybrid. All rights reserved.
//  </copyright>
//  <site>https://www.lxking.cn</site>
//  <last-editor>ArcherTrister</last-editor>
// -----------------------------------------------------------------------

using Hybrid.Entity;

using LeXun.Demo.Identity.Entities;

using Microsoft.Extensions.DependencyInjection;

using System;

namespace LeXun.Demo.Infos
{
    /// <summary>
    /// 业务实现基类：信息模块
    /// </summary>
    public partial class InfosService : InfosServiceBase
    {
        /// <summary>
        /// 初始化一个<see cref="InfosService"/>类型的新实例
        /// </summary>
        public InfosService(IServiceProvider provider)
            : base(provider)
        { }

        /// <summary>
        /// 获取 用户存储对象
        /// </summary>
        protected IRepository<User, int> UserRepository => ServiceProvider.GetService<IRepository<User, int>>();

        /// <summary>
        /// 获取 角色存储对象
        /// </summary>
        protected IRepository<Role, int> RoleRepository => ServiceProvider.GetService<IRepository<Role, int>>();
    }
}