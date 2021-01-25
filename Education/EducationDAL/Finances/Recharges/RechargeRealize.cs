using EducationMODEL.FinancialManagement;
using EducationMODEL.linkModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.Finances.Recharges
{
    //充值方法实现
    public class RechargeRealize : Recharge
    {
        //机构账户充值
        public override int AauditAdd(AauditMod am)
        {
            return DapperHelper.Execute("insert into Aaudit values(@AauditName,@AauditDateTiem,@CPrice,@AauditLimit,@AauditZtai,@SHerName,null,@BeiZu,@OrganizationId)",am);
        }
        //充值方法
        public override int AauditOrganUpt(int price, int id)
        {
            return DapperHelper.Execute("update Organization set OrganizationMoney+=@OrganizationMoney where OrganizationId=@OrganizationId",new { OrganizationMoney=price, OrganizationId=id });
        }

        //充值审核
        public override int AauditSHerUpt(AauditMod am)
        {
            return DapperHelper.Execute("update Aaudit set AauditZtai=@AauditZtai,SHerName=@SHerName,SHerDatetiem=@SHerDatetiem where AauditId=@AauditId", am);
        }

        //机构充值审核显示和查询
        public override List<Aaudit_OrganiMod> AauditShow(int ? id =null, string dm = null, string name = null, DateTime? time = null)
        {
            string sql = "select a.*,b.OrganizationCode,c.OrganName,d.InstitutionalName from Aaudit a join Organization b on a.OrganizationId=b.OrganizationId join Organ c on b.OrganId=c.OrganId join "
                            + " Institutional d on c.InstitutionalId = d.InstitutionalId where 1=1";
            if (id!=null)
            {
                sql += " and d.InstitutionalId=@InstitutionalId";
            }
            if (!string.IsNullOrEmpty(dm))
            {
                sql += " and b.OrganizationCode like concat('%',@OrganizationCode,'%')";
            }
            if (!string.IsNullOrEmpty(name))
            {
                sql += " and c.OrganName like concat('%',@OrganName,'%')";
            }
            if (time!=null)
            {
                sql += " and a.AauditDateTiem like concat('%',@AauditDateTiem,'%')";
            }
            return DapperHelper.Query<Aaudit_OrganiMod>(sql,new { InstitutionalId =id, OrganizationCode =dm, OrganName=name, AauditDateTiem =time});
        }
    }
}
