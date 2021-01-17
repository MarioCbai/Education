using EducationMODEL;
using EducationMODEL.AuthorityManagement;
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
        //用户角色添加
        public override int UserAdd(UserPardMod u)
        {
            int o=DapperHelper.Execute("insert into Consumer values(@ConsumerName,@ConsumerIPhone,@ConsumerRemark,@ConsumerPwd,@ConsumerSection)", u);
            u.Consumer =DapperHelper.QueryFirst<ConsumerMod>("select max(ConsumerId) from Consumer",new { }).ConsumerId;
            int oo = 0;
            string[] strArray = u.Parts.Split(",");
            for (int i = 0; i < strArray.Length; i++)
            {
                u.Part = int.Parse(strArray[i]);
                oo+= DapperHelper.Execute("insert into ConsumerPart values (@Consumer,@Part,@CPState,@Createtime,@Handlers)", u);
            }
            if (oo== strArray.Length&& o>0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            
        }

        //用户角色显示
        public override List<UserPardMod> UserPartShow(int PageIndex, int PageSize, string name, string Iphone, string PartName, string State, DateTime? StartTime, DateTime? EndTime)
        {
            string str = "select ROW_NUMBER() over(order by CPId)num,* from ConsumerPart a join Consumer b on a.Consumer=b.ConsumerId join Part c on a.Part=c.PartId where 1=1";
            if (name!="")
            {
                str += " and b.ConsumerName like concat('%',@names,'%') ";
            }
            if (Iphone!="" && Iphone!=null)
            {
                str += " and b.ConsumerIPhone = @Iphones";
            }
            if (PartName!="" && PartName !=null && int.Parse(PartName)!=0)
            {
                str += " and c.PartId=@PartNames";
            }
            if (State!="全部")
            {
                str += " and a.CPState=@States";
            }
            if (StartTime!=null && EndTime!=null)
            {
                str += " and a.Createtime between @StartTimes and @EndTimes";
            }
            string sql = "select * from ("+ str + ")T where T.num between @PageIndex and @PageSize";
            List<UserPardMod> mm=  DapperHelper.Query<UserPardMod>(sql, new { names=name, Iphones=Iphone, PartNames=PartName, States= State, StartTimes= StartTime, EndTimes= EndTime, PageIndex = (PageIndex - 1) * PageSize + 1, PageSize = PageSize * PageIndex });
            return mm;
        }
        //用户角色数据总条数
        public override int UserPartShows(string name, string Iphone, string PartName, string State, DateTime? StartTime, DateTime? EndTime)
        {
            string sql = "select count(*) [Count] from ConsumerPart a join Consumer b on a.Consumer=b.ConsumerId join Part c on a.Part=c.PartId where 1=1";
            if (name != "")
            {
                sql += " and b.ConsumerName like concat('%',@names,'%')";
            }
            if (Iphone != ""&& Iphone !=null)
            {
                sql += " and b.ConsumerIPhone = @Iphones";
            }
            if (PartName != ""&& int.Parse(PartName)!=0)
            {
                sql += " and c.PartId=@PartNames";
            }
            if (State != "全部")
            {
                sql += " and a.CPState=@States";
            }
            if (StartTime != null && EndTime != null)
            {
                sql += " and a.Createtime between @StartTimes and @EndTimes";
            }
            UserPardMod a = DapperHelper.QueryFirst<UserPardMod>(sql,new { names= name, Iphones=Iphone, PartNames= PartName, States= State, StartTimes= StartTime, EndTimes= EndTime });
            return a.Count;
        }
    }
}
