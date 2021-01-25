using EducationMODEL.AuthorityManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.AuthorityManagement.Users
{
    //用户方法声明
    public abstract class User
    {
        //查询用户表账号存不存在
        public abstract List<ConsumerMod> Register1(string ConsumerIPhone);
        //登录
        public abstract List<ConsumerMod> Register(string ConsumerIPhone, string ConsumerPwd);
        //忘记密码,修改密码
        public abstract int RetrievePassword(string ConsumerIPhone, string ConsumerPwd);
        //查询用户名
        public abstract List<ConsumerMod> Register2(string ConsumerIPhone);
    }
}
