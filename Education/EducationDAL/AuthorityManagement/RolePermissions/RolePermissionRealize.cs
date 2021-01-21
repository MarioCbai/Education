using EducationMODEL;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.AuthorityManagement.RolePermissions
{
    //角色权限方法实现
    public class RolePermissionRealize : RolePermission
    {
        //添加角色权限
        public override int AddPart(JueseP j)
        {
            int b=0;
            for (int i = 0; i < j.data.Length; i++)
            {
                b =DapperHelper.Execute("insert into PartMenu values(@PartMenuPartId,@PartMenuMenuId)", new { PartMenuPartId = j.id, PartMenuMenuId = int.Parse(j.data[i]) });
                if (b!=1)
                {
                    break;
                }
            }
            return b; 
        }

        //角色权限状态
        public override void CPState(int id, int val)
        {
            DapperHelper.Execute("update PartMenu set PMState=@Value where PartMenuId=@Id", new { Value = val, Id = id });
        }
    }
}
