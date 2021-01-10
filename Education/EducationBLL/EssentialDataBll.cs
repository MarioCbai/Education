using EducationDAL.EssentialData;
using IEducation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationBLL
{
    //基本数据管理
    public class EssentialDataBll: IEssentialData
    {
        Essential essentials = new EssentialDataPlant();
    }
}
