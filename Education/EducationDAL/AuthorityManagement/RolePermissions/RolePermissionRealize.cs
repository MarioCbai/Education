using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.AuthorityManagement.RolePermissions
{
    //角色权限方法实现
    public class RolePermissionRealize : RolePermission
    {
        //角色权限状态
        public override void CPState(int id, int val)
        {
            DapperHelper.Execute("update PartMenu set PMState=@Value where PartMenuId=@Id", new { Value = val, Id = id });
        }
    }
}
