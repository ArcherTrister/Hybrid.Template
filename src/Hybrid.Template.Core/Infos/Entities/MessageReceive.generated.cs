//------------------------------------------------------------------------------
// <auto-generated>
//    此代码由代码生成器生成。
//    手动更改此文件可能导致应用程序出现意外的行为。
//    如果重新生成代码，对此文件的任何修改都会丢失。
//    如果需要扩展此类：可遵守如下规则进行扩展：
//      1.横向扩展：如需添加额外的属性，可新建文件“MessageReceive.cs”的分部类“public partial class MessageReceive”}添加属性
// </auto-generated>
//
//  <copyright file="MessageReceive.generated.cs" company="Hybrid开源团队">
//      Copyright (c) 2014-2019 Liuliu. All rights reserved.
//  </copyright>
//  <site>https://www.lxking.cn</site>
//  <last-editor>郭明锋</last-editor>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Hybrid.Entity;

using Hybrid.Template.Identity.Entities;

namespace Hybrid.Template.Infos.Entities
{
    /// <summary>
    /// 实体类：站内信接收记录信息
    /// </summary>
    [Description("站内信接收记录信息")]
    public partial class MessageReceive : EntityBase<Guid>, ICreatedTime
    {
        /// <summary>
        /// 获取或设置 接收时间
        /// </summary>
        [DisplayName("接收时间")]
        public DateTime ReadDate { get; set; }

        /// <summary>
        /// 获取或设置 新回复数，接收者使用
        /// </summary>
        [DisplayName("新回复数，接收者使用")]
        public int NewReplyCount { get; set; }

        /// <summary>
        /// 获取或设置 创建时间
        /// </summary>
        [DisplayName("创建时间")]
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// 获取或设置 接收的主消息编号
        /// </summary>
        [DisplayName("接收的主消息编号")]
        public Guid MessageId { get; set; }

        /// <summary>
        /// 获取或设置 接收的主消息
        /// </summary>
        [DisplayName("接收的主消息")]
        public virtual Message Message { get; set; }

        /// <summary>
        /// 获取或设置 消息接收人编号
        /// </summary>
        [DisplayName("消息接收人编号")]
        public int UserId { get; set; }

        /// <summary>
        /// 获取或设置 消息接收人
        /// </summary>
        [DisplayName("消息接收人")]
        public virtual User User { get; set; }

    }
}

