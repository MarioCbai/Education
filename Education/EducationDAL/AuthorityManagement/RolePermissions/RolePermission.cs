using EducationMODEL;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.AuthorityManagement.RolePermissions
{
    //角色权限方法声明
    public abstract class RolePermission
    {
        //角色权限状态
        public abstract void CPState(int id, int val);

        public abstract int AddPart(JueseP j); 
    }
}
