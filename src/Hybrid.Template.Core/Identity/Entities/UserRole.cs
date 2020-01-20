// -----------------------------------------------------------------------
//  <copyright file="UserRole.cs" company="Hybrid开源团队">
//      Copyright (c) 2014-2018 Hybrid. All rights reserved.
//  </copyright>
//  <site>https://www.lxking.cn</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2018-06-27 4:44</last-date>
// -----------------------------------------------------------------------

using System.ComponentModel;

using Hybrid.Identity;


namespace Hybrid.Template.Identity.Entities
{
    /// <summary>
    /// 实体类：用户角色信息
    /// </summary>
    [Description("用户角色信息")]
    public class UserRole : UserRoleBase<int, int>
    {
        /// <summary>
        /// 获取或设置 关联用户信息
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// 获取或设置 关联角色信息
        /// </summary>
        public virtual Role Role { get; set; }
    }
}