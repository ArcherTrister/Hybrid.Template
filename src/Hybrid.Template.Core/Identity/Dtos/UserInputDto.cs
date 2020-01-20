// -----------------------------------------------------------------------
//  <copyright file="UserInputDto.cs" company="Hybrid开源团队">
//      Copyright (c) 2014-2018 Hybrid. All rights reserved.
//  </copyright>
//  <site>https://www.lxking.cn</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2018-06-27 4:44</last-date>
// -----------------------------------------------------------------------

using Hybrid.Template.Identity.Entities;

using Hybrid.Identity;
using Hybrid.Mapping;


namespace Hybrid.Template.Identity.Dtos
{
    /// <summary>
    /// 输入DTO：用户信息
    /// </summary>
    [MapTo(typeof(User))]
    public class UserInputDto : UserInputDtoBase<int>
    { }
}