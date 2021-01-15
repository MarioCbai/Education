using EducationMODEL.AuthorityManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.AuthorityManagement.Users
{
    //用户方法声明
    public abstract class User
    {
        public abstract List<ConsumerMod> Register(string ConsumerIPhone, string ConsumerPwd);
    }
}
