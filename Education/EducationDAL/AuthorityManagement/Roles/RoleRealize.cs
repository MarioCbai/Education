using EducationMODEL.AuthorityManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.AuthorityManagement.Roles
{
    //角色方法实现
    public class RoleRealize : Role
    {
        //角色添加
        public override int AddPart(PartMod dt)
        {
            int i = DapperHelper.Execute("insert into Part values (@PartName,@PartDescribe)", dt);
            return i;
        }

        //全部角色
        public override List<PartMod> PartShow()
        {
           return  DapperHelper.Query<PartMod>("select * from Part",new { });
        }

        //角色状态修改
        public override void RoleState(int id, int val)
        {
            DapperHelper.Execute("update Part set PMState=@Value where PartId=@Id", new { Value = val, Id = id });
        }
    }
}
