using EducationMODEL.linkModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.Finances.Organizations
{
    //机构账户实现
    public class OrganizationRealize : Organization
    {
        //机构账户显示
        public override List<Organ_Inst_Organ> OrganizationShow(int? id = null, string dm = null, string name = null)
        {
            string sql = "select a.OrganizationCode,a.OrganizationMoney,b.OrganName,c.InstitutionalName from Organization a join Organ b on a.OrganId=b.OrganId join Institutional  c on b.InstitutionalId=c.InstitutionalId where 1=1";
            if (id!=null)
            {
                sql += " and c.InstitutionalId=@InstitutionalId";
            }
            if (!string.IsNullOrEmpty(dm))
            {
                sql += " and a.OrganizationCode like concat('%',@OrganizationCode,'%')";
            }
            if (!string.IsNullOrEmpty(name))
            {
                sql += " and b.OrganName like concact('%',@OrganName,'%')";
            }
            return DapperHelper.Query<Organ_Inst_Organ>(sql,new { InstitutionalId=id, OrganizationCode=dm, OrganName =name});
        }
        //机构充值
        public override int OrganizationUpt(int id, int price)
        {
            return DapperHelper.Execute("update Organization set OrganizationMoney+=@OrganizationMoney where OrganizationId=@OrganizationId",new { @OrganizationId =id, OrganizationMoney =price});
        }
    }
}
