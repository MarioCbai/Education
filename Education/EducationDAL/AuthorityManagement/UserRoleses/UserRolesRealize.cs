using EducationMODEL;
using EducationMODEL.linkModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.AuthorityManagement.UserRoleses
{
    //角色用户方法实现
    public class UserRolesRealize : UserRoles
    {
        //用户角色显示
        public override List<UserPardMod> UserPartShow()
        {
            return   DapperHelper.Query<UserPardMod>("select * from ConsumerPart a join Consumer b on a.Consumer=b.ConsumerId join Part c on a.Part=c.PartId", new { });
        }
    }
}
