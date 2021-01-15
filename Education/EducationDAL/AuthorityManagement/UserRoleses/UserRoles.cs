using EducationMODEL;
using EducationMODEL.linkModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.AuthorityManagement.UserRoleses
{
    //角色用户方法声明
    public abstract class UserRoles
    {
        //用户角色显示
        public abstract List<UserPardMod> UserPartShow();
    }
}
