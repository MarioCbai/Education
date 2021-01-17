using EducationMODEL.AuthorityManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.AuthorityManagement.Users
{
    //用户方法声明
    public abstract class User
    {
        //登录
        public abstract List<ConsumerMod> Register(string ConsumerIPhone, string ConsumerPwd);
        //忘记密码,修改密码
        public abstract int RetrievePassword(string ConsumerIPhone, string ConsumerPwd);

    }
}
