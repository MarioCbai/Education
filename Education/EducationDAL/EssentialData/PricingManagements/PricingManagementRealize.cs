using EducationMODEL.Infrastructure;
using EducationMODEL.linkModel;
using EducationMODEL.OrderManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.EssentialData.PricingManagements
{
    //定价管理表实现
    public class PricingManagementRealize : PricingManagement
    {
        //查询课时表绑定下拉
        public override List<HourTypeMod> HourTypeModAll()
        {
            return DapperHelper.Query<HourTypeMod>("select * from HourType", "");
        }

        public override List<Subjects_HourT_Mod> PricingManagementShow(int hourprice=0, int pricehour=0,string name=null,int price =0, int studying =0, int hour =0)
        {
            string sql = "select a.*,b.PriceRankName,c.ClassModelName,d.StudyName,e.HourTypeName " +
                "from Pricing a join PriceRank b on a.PriceRankId = b.PriceRankId join " +
                "ClassModel c on a.ClassModelId = c.ClassModelId join Study d on a.StID = d.StID " +
                "join HourType e on a.HourTypeId = e.HourTypeId where 1=1";
            if (price>0)
            {
                sql += " and a.PriceRankId=@PriceRankId";
            }
            if (studying>0)
            {
                sql += " and d.StID=@StID";
            }
            if (hour>0)
            {
                sql += " and e.HourTypeId=@HourTypeId";
            }

            if (hourprice>0 && pricehour>0)
            {
                sql += " and a.PricingPrice >=@PriceReigth and a.PricingPrice <= @PriceLefght";
            }
           else  if (hourprice>0)
            {
                sql += " and a.PricingPrice>=@PriceLefght";
            }
            else if (pricehour>0)
            {
                sql += " and a.PricingPrice<=@PriceReigth";
            }
            if (!string.IsNullOrEmpty(name))
            {
                sql += " and c.ClassModelName=@ClassModelName";
            }
            return DapperHelper.Query<Subjects_HourT_Mod>(sql,new { PriceLefght = hourprice, PriceReigth = pricehour, ClassModelName=name,PriceRankId= price, StID= studying, HourTypeId= hour });
        }
        //修改课时单价
        public override int PricingManagementUpt(PricingMod m)
        {
            return DapperHelper.Execute("update Pricing set PricingPrice=@PricingPrice  where PricingId=@PricingId", m);
        }


        //查询价格级别表绑定下拉
        public override List<PriceRankMod> SelectPriceRankModAll()
        {
            return DapperHelper.Query<PriceRankMod>("select * from PriceRank", "");
        }
        //查询学段表绑定下拉
        public override List<Study> SelectStudyModAll()
        {
            return DapperHelper.Query<Study>("select * from Study","");
        }
    }
}
