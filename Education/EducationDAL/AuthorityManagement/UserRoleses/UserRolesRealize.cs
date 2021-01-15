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
        //用户状态修改
        public override void State(int id,int val)
        {
            DapperHelper.Execute("update ConsumerPart set CPState=@Value where CPId=@Id", new { Value = val, Id = id });
        }

        //用户角色显示
        public override List<UserPardMod> UserPartShow(int PageIndex, int PageSize)
        {
            return   DapperHelper.Query<UserPardMod>("select * from (select ROW_NUMBER() over(order by CPId)num,* from ConsumerPart a join Consumer b on a.Consumer=b.ConsumerId join Part c on a.Part=c.PartId)T where T.num between @PageIndex and @PageSize", new { PageIndex=(PageIndex-1)* PageSize+1, PageSize= PageSize * PageIndex });
        }
        //用户角色数据总条数
        public override int UserPartShows()
        {
            UserPardMod a = DapperHelper.QueryFirst<UserPardMod>("select count(*) [Count] from ConsumerPart",new { });
            return a.Count;
        }
    }
}
