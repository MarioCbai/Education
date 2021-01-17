using EducationMODEL.organizational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EducationDAL.InstitutionManagement.Organs
{
    //机构表实现
    public class OrganRealize:Organes
    {
        //机构管理显示
        public override List<OrganMod> GetOrganMods()
        {
            return DapperHelper.Query<OrganMod>("select * from Organ", " ");
        }

        //添加机构管理信息
        public override int AddOrganes(OrganMod organ)
        {
            var result = DapperHelper.Execute("insert into Organ values(@OrganEncod,@OrganName,@InstitutionalId,@PriceRankId,@OrganPhoneName,@OrganPhone,@ProvinceId,@City,@District,@OrganRemark,@OrganStatus,@OrganBeginTime,@PId)",
            new { organ.OrganEncod, organ.OrganName, organ.InstitutionalId, organ.PriceRankId, organ.OrganPhoneName, organ.OrganPhone, organ.ProvinceId, organ.City, organ.District, organ.OrganRemark, organ.OrganStatus, organ.OrganBeginTime, organ.PId });
            return result;
        }
        //反填机构管理信息
        public override OrganMod ModiyIdOrganes(int orgid)
        {
            return DapperHelper.Query<OrganMod>("select *from Organ where OrganId=@OrganId", new { OrganId = orgid }).FirstOrDefault();
        }
        //修改机构管理信息
        public override int ModiyOrganes(OrganMod organ)
        {
            var result = DapperHelper.Execute("update Organ set OrganEncod=@OrganEncod,OrganName=@OrganName,InstitutionalId=@InstitutionalId,PriceRankId=@PriceRankId,OrganPhoneName=@OrganPhoneName,OrganPhone=@OrganPhone,ProvinceId=@ProvinceId,City=@City,District=@District,OrganRemark=@OrganRemark,OrganStatus=@OrganStatus,OrganBeginTime=@OrganBeginTime,PId=@PId where OrganId=@OrganId",
            new { organ.OrganEncod, organ.OrganName, organ.InstitutionalId, organ.PriceRankId, organ.OrganPhoneName, organ.OrganPhone, organ.ProvinceId, organ.City, organ.District, organ.OrganRemark, organ.OrganStatus, organ.OrganBeginTime, organ.PId, organ.OrganId });
            return result;
        }
        //单删除机构管理信息
        public override int DeleteOrganes(int ids)
        {
            return DapperHelper.Execute("delete from Organ where OrganId=@OrganId", new { OrganId = ids });
        }
    }
}
