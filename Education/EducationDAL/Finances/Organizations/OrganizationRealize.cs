using EducationMODEL.FinancialManagement;
using EducationMODEL.linkModel;
using EducationMODEL.organizational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EducationDAL.Finances.Organizations
{
    //机构账户实现
    public class OrganizationRealize : Organization
    {
        //机构审核表显示
        public override List<Organ_Inst_Organ> OrganizAauditShow()
        {
            return DapperHelper.Query<Organ_Inst_Organ>("select a.OrganizationName,a.OrganizationStratTime,a.OrganizationId,a.OrganizationCode,a.OrganizationMoney,b.OrganName,c.InstitutionalName,d.* from "
                                    +"Organization a join Organ b on a.OrganId = b.OrganId join Institutional  c on b.InstitutionalId = c.InstitutionalId join Aaudit d on a.OrganizationId = d.OrganizationId","");
        }

        //机构账户显示
        public override List<Organ_Inst_Organ> OrganizationShow(int? id = null, string dm = null, string name = null)
        {
            string sql = "select a.OrganizationId, a.OrganizationCode,a.OrganizationMoney,b.OrganName,c.InstitutionalName from Organization a join Organ b on a.OrganId=b.OrganId join Institutional  c on b.InstitutionalId=c.InstitutionalId where 1=1";
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
                sql += " and b.OrganName like concat('%',@OrganName,'%')";
            }
            return DapperHelper.Query<Organ_Inst_Organ>(sql,new { InstitutionalId=id, OrganizationCode=dm, OrganName =name});
        }
        //机构充值
        public override int OrganizationUpt(OrganizationMod or)
        {
            return DapperHelper.Execute("update Organization set OrganizationMoney+=@OrganizationMoney,OrganizationRemark=@OrganizationRemark where OrganizationId=@OrganizationId",or);
        }
        //查询机构类型表绑定下拉
        public override List<Institutional> SelectInstitutionalAll()
        {
            return DapperHelper.Query<Institutional>("select * from Institutional","");
        }
        //查询机构账户反填
        public override Organ_Inst_Organ SelectOrganization(int id)
        {
            return DapperHelper.Query<Organ_Inst_Organ>("select a.OrganizationId,a.OrganizationCode,a.OrganizationMoney,b.OrganName,c.InstitutionalName from Organization a join Organ b on a.OrganId=b.OrganId join Institutional  c on b.InstitutionalId=c.InstitutionalId where OrganizationId=@OrganizationId", new { OrganizationId=id }).FirstOrDefault();
        }
        

    }
}
