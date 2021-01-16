using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.linkModel
{
    public class UserPardMod
    {
        public int CPId { get; set; }//主键id
        public string  date { get; set; }//日期
        public int Count { get; set; }//数量
        public string Zhuang { get; set; }//状态
        public int Consumer { get; set; }//用户表（外键）

        public int Part { get; set; }//角色表（外键）
        public int CPState { get; set; }//状态
        public DateTime Createtime { get; set; }//创建时间
        public string Handlers { get; set; }//操作人
        public int ConsumerId { get; set; }//主键

        public string ConsumerName { get; set; }//姓名

        public string ConsumerIPhone { get; set; }//手机

        public string ConsumerRemark { get; set; }//备注

        public string ConsumerPwd { get; set; }//密码

        public int ConsumerSection { get; set; }//权限部门，按照机构来
        public int PartId { get; set; }//角色id

        public string PartName { get; set; }//角色名称

        public string PartDescribe { get; set; }//角色描述
    }
}
