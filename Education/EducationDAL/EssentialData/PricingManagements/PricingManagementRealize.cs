using EducationMODEL.Infrastructure;
using EducationMODEL.linkModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.EssentialData.PricingManagements
{
    //定价管理表实现
    public class PricingManagementRealize : PricingManagement
    {
        public override List<Subjects_HourT_Mod> PricingManagementShow(int price =0, int studying =0, int hour =0, int? hourprice=null , int? pricehour =null)
        {
            string sql = "select a.*,b.PriceRankName,c.ClassModelName,d.StudyName,e.HourTypeName " +
                "from Pricing a join PriceRank b on a.PriceRankId = b.PriceRankId join " +
                "ClassModel c on a.ClassModelId = c.ClassModelIdjoin Study d on a.StID = d.StID " +
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

            if (hourprice != null && pricehour != null)
            {
                sql += " and a.PricingPrice between @PriceReigth and @PriceLefght";
            }
            else if (hourprice != null)
            {
                sql += " and a.PricingPrice>=@PriceLefght";
            }
            else if (pricehour != null)
            {
                sql += " and a.PricingPrice<=@PriceReigth";
            }
            return DapperHelper.Query<Subjects_HourT_Mod>(sql,new { PriceRankId= price, StID= studying, HourTypeId= hour, PriceLefght= hourprice, PriceReigth= pricehour });
        }
    }
}
