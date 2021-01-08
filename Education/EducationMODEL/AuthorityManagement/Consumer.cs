using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.AuthorityManagement
{
    public class Consumer//用户表  
    {
        public int ConsumerId { get; set; }//主键

        public string ConsumerName { get; set; }//姓名

        public string ConsumerIPhone { get; set; }//手机

        public string ConsumerRemark { get; set; }//备注

        public string ConsumerPwd { get; set; }//密码

        public int ConsumerSection { get; set; }//权限部门，按照机构来
    }
}
