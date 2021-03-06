﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.organizational
{
    public class OrganMod//机构表递归
    {
        public int OrganId { get; set; }//机构表主键

        public string OrganEncod { get; set; }//机构编码

        public string OrganName { get; set; }//机构名称
        public string aa { get; set; } //顶级机构名称

        public int InstitutionalId { get; set; }//机构类型外键

        public string InstitutionalName { get; set; }//机构类型名称

        public int PriceRankId { get; set; }//价格级别表外键
        public string PriceRankName { get; set; }//价格级别名称

        public string OrganPhoneName { get; set; }//联系人

        public string OrganPhone { get; set; }//联系电话

        public int ProvinceId { get; set; }//省Id

        public int City { get; set; }//市Id地区绑定三级联动

        public string SitesName { get; set; }//省Id名称
        public int District { get; set; }//区Id --地区表外键 绑定下拉

        public string OrganRemark { get; set; }//备注

        public int OrganStatus { get; set; }//状态 启用禁用

        public DateTime OrganBeginTime { get; set; }//创建时间 获取当前时间

        public int PId { get; set; }//递归表编号PId上级机构

        public string OrganAddress { get; set; }//具体地址
        public string title { get { return OrganName; } }//标题名称
        public List<OrganMod> children { get; set; }//子节点
    }
}
