using EducationMODEL.students;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.StudentManagement.Parent
{
    //家长方法实现
    public class ParentsRealize : Parents
    {
        //添加家长信息
        public override int AddParent(PatriarchMod p)
        {
            DapperHelper.Execute("insert into Patriarch values(@PatriarchName,@PatriarchIphone,@PatriarchRelation,@PatriarchOccupation,@PatriarchAge,@PatriarchWeChat,@PatriarchRemark)", p);
            int ss = DapperHelper.QueryFirst<PatriarchMod>("select max(PatriarchId) as PatriarchId from Patriarch", new { }).PatriarchId;
            int i =DapperHelper.Execute("insert into PatriarchStudent values(@Patriarch,@Student)", new { Patriarch = ss, Student = p.studentid });
            return i;
        }

        //删除家长信息
        public override int DelParents(int id)
        {
            int i = DapperHelper.Execute("delete PatriarchStudent where PSID=@id", new { id });
            return i;
        }

        //家长信息反填
        public override PatriarchMod FanParent(int id)
        {
            return DapperHelper.QueryFirst<PatriarchMod>("select * from Patriarch", new { });
        }

        //家长显示
        public override List<PatriarchMod> ParentsShow(int id)
        {
            List<PatriarchMod> list = DapperHelper.Query<PatriarchMod>("select * from PatriarchStudent a join Patriarch b on a.Patriarch= b.PatriarchId where a.Student=@id", new { id });
            return list;
        }

        //家长信息修改
        public override int UptParent(PatriarchMod p)
        {
            return DapperHelper.Execute("update Patriarch set PatriarchName=@PatriarchName,PatriarchIphone=@PatriarchIphone,PatriarchRelation=@PatriarchRelation,PatriarchOccupation=@PatriarchOccupation,PatriarchAge=@PatriarchAge,PatriarchWeChat=@PatriarchWeChat,PatriarchRemark=@PatriarchRemark where PatriarchId=@PatriarchId", p);
        }
    }
}
