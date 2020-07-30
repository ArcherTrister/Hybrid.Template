// -----------------------------------------------------------------------
//  <copyright file="PackOutputDto.cs" company="Hybrid��Դ�Ŷ�">
//      Copyright (c) 2014-2018 Hybrid. All rights reserved.
//  </copyright>
//  <site>https://www.lxking.cn</site>
//  <last-editor>ArcherTrister</last-editor>
//  <last-date>2018-08-13 14:59</last-date>
// -----------------------------------------------------------------------

using Hybrid.Core.Packs;
using Hybrid.Entity;

using System.ComponentModel;

namespace LeXun.Demo.Systems.Dtos
{
    /// <summary>
    /// ���DTO��ģ�����Ϣ
    /// </summary>
    public class PackOutputDto : IOutputDto
    {
        /// <summary>
        /// ��ȡ������ ����
        /// </summary>
        [DisplayName("����")]
        public string Name { get; set; }

        /// <summary>
        /// ��ȡ������ ��ʾ����
        /// </summary>
        [DisplayName("��ʾ����")]
        public string Display { get; set; }

        /// <summary>
        /// ��ȡ������ ����·��
        /// </summary>
        [DisplayName("����·��")]
        public string Class { get; set; }

        /// <summary>
        /// ��ȡ������ ģ�鼶��
        /// </summary>
        [DisplayName("����")]
        public PackLevel Level { get; set; }

        /// <summary>
        /// ��ȡ������ ����˳��
        /// </summary>
        [DisplayName("����˳��")]
        public int Order { get; set; }

        /// <summary>
        /// ��ȡ������ �Ƿ�����
        /// </summary>
        [DisplayName("�Ƿ�����")]
        public bool IsEnabled { get; set; }
    }
}