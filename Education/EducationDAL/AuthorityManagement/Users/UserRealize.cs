﻿using EducationMODEL.AuthorityManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.AuthorityManagement.Users
{
    //用户方法实现
    public class UserRealize:User
    {  
        //登录
        public override List<ConsumerMod> Register(string ConsumerIPhone, string ConsumerPwd)
        {
            return DapperHelper.Query<ConsumerMod>("select *from Consumer where ConsumerIPhone=@ConsumerIPhone	and ConsumerPwd=@ConsumerPwd", new { ConsumerIPhone = ConsumerIPhone, ConsumerPwd = ConsumerPwd });
        }
        //查询用户名
        public override List<ConsumerMod> Register2(string ConsumerIPhone)
        {
            return DapperHelper.Query<ConsumerMod>("select *from Consumer where ConsumerIPhone=@ConsumerIPhone", new { ConsumerIPhone = ConsumerIPhone });
        }
        //查询用户表
        public override List<ConsumerMod> Register1(string ConsumerIPhone)
        {
            return DapperHelper.Query<ConsumerMod>("select *from Consumer where ConsumerIPhone=@ConsumerIPhone", new { ConsumerIPhone = ConsumerIPhone });
        }

        //修改密码
        public override int RetrievePassword(string ConsumerIPhone, string ConsumerPwd)
        {
            int i= DapperHelper.Execute("update Consumer set ConsumerPwd=@ConsumerPwd  where ConsumerIPhone=@ConsumerIPhone",new { ConsumerPwd= ConsumerPwd, ConsumerIPhone= ConsumerIPhone });
            return i;        
        }
    }
}
