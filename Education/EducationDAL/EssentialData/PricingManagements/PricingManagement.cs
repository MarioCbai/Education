using EducationMODEL.Infrastructure;
using EducationMODEL.linkModel;
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
        public abstract List<Subjects_HourT_Mod> PricingManagementShow(int price=-1,int studying=-1,int hour=-1,int ? hourprice=null,int ? pricehour=null);
    }
}
