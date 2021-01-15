using EducationMODEL.AuthorityManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.AuthorityManagement.Users
{
    //用户方法实现
    public class UserRealize:User
    {
        public override List<ConsumerMod> Register(string ConsumerIPhone, string ConsumerPwd)
        {
            return DapperHelper.Query<ConsumerMod>("select *from Consumer where ConsumerIPhone=@ConsumerIPhone	and ConsumerPwd=@ConsumerPwd", new { ConsumerIPhone = ConsumerIPhone, ConsumerPwd = ConsumerPwd });
        }
    }
}
