// -----------------------------------------------------------------------
//  <copyright file="RoleStore.cs" company="Hybrid开源团队">
//      Copyright (c) 2014-2018 Hybrid. All rights reserved.
//  </copyright>
//  <site>https://www.lxking.cn</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2018-06-27 4:44</last-date>
// -----------------------------------------------------------------------

using Hybrid.Template.Identity.Entities;

using Hybrid.Entity;
using Hybrid.Identity;


namespace Hybrid.Template.Identity
{
    /// <summary>
    /// 角色仓储
    /// </summary>
    public class RoleStore : RoleStoreBase<Role, int, RoleClaim>
    {
        /// <summary>
        /// 初始化一个<see cref="RoleStoreBase{TRole,TRoleKey,TRoleClaim}"/>类型的新实例
        /// </summary>
        public RoleStore(IRepository<Role, int> roleRepository, IRepository<RoleClaim, int> roleClaimRepository)
            : base(roleRepository, roleClaimRepository)
        { }
    }
}