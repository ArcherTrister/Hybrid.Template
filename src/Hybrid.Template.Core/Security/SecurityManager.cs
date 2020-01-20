// -----------------------------------------------------------------------
//  <copyright file="SecurityManager.cs" company="Hybrid开源团队">
//      Copyright (c) 2014-2018 Hybrid. All rights reserved.
//  </copyright>
//  <site>https://www.lxking.cn</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2018-07-04 1:13</last-date>
// -----------------------------------------------------------------------

using System;

using Hybrid.Template.Identity.Entities;
using Hybrid.Template.Security.Dtos;
using Hybrid.Template.Security.Entities;

using Hybrid.Core.EntityInfos;
using Hybrid.Core.Functions;
using Hybrid.Entity;
using Hybrid.EventBuses;
using Hybrid.Security;


namespace Hybrid.Template.Security
{
    /// <summary>
    /// 权限安全管理器
    /// </summary>
    public class SecurityManager
        : SecurityManagerBase<Function, FunctionInputDto, EntityInfo, EntityInfoInputDto,
            Module, ModuleInputDto, int, ModuleFunction, ModuleRole, ModuleUser, EntityRole, EntityRoleInputDto, UserRole, Role, int, User, int>
    {
        /// <summary>
        /// 初始化一个<see cref="SecurityManager"/>类型的新实例
        /// </summary>
        public SecurityManager(
            IEventBus eventBus,
            IRepository<Function, Guid> functionRepository,
            IRepository<EntityInfo, Guid> entityInfoRepository,
            IRepository<Module, int> moduleRepository,
            IRepository<ModuleFunction, Guid> moduleFunctionRepository,
            IRepository<ModuleRole, Guid> moduleRoleRepository,
            IRepository<ModuleUser, Guid> moduleUserRepository,
            IRepository<EntityRole, Guid> entityRoleRepository,
            IRepository<UserRole, Guid> userRoleRepository,
            IRepository<Role, int> roleRepository,
            IRepository<User, int> userRepository
        )
            : base(eventBus,
                functionRepository,
                entityInfoRepository,
                moduleRepository,
                moduleFunctionRepository,
                moduleRoleRepository,
                moduleUserRepository,
                entityRoleRepository,
                userRoleRepository,
                roleRepository,
                userRepository)
        { }
    }
}