using EducationMODEL.Infrastructure;
using EducationMODEL.linkModel;
using EducationMODEL.OrderManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.EssentialData.PricingManagements
{
    //定价管理
    public abstract class PricingManagement
    {
        //定价管理增删改查
        //定价表显示
        public abstract List<Subjects_HourT_Mod> PricingManagementShow(int ? hourprice =null, int ? pricehour =null, string name=null,int price=0,int studying=0,int hour=0);
        //查询价格级别表绑定下拉
        public abstract List<PriceRankMod> SelectPriceRankModAll();
        //查询学段表绑定下拉
        public abstract List<Study> SelectStudyModAll();
        //查询课时表绑定下拉
        public abstract List<HourTypeMod> HourTypeModAll();
        //修改课时单价
        public abstract int PricingManagementUpt(PricingMod m);
    }
}
