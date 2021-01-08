using System;
using System.Collections.Generic;
using System.Text;
using EducationDAL.EssentialData.ClasstypeManagements;
using EducationDAL.EssentialData.ClassTypes;
using EducationDAL.EssentialData.PriceLevels;
using EducationDAL.EssentialData.PricingManagements;
using EducationDAL.EssentialData.Sources;
using EducationDAL.EssentialData.TeacherLevels;
using EducationDAL.EssentialData.TeacherSorts;
using EducationDAL.EssentialData.TeacherStyles;

namespace EducationDAL.EssentialData
{
    //基础数据工厂工厂类
    public class EssentialDataPlant : Essential
    {
        //课型管理表
        public override ClasstypeManagement ClasstypeManagement()
        {
            return  new ClasstypeManagementRealize();
        }

        //课时类型
        public override ClassType ClassType()
        {
            return new ClassTypeRealize();
        }

        //价格级别管理
        public override PriceLevel PriceLevel()
        {
            return new PriceLevelRealize();
        }

        //定价管理
        public override PricingManagement PricingManagement()
        {
            return new PricingManagementRealize();
        }

        //来源管理
        public override Source Source()
        {
            return new SourceRealice();
        }
        //教师级别水平管理
        public override TeacherLevel TeacherLevel()
        {
            return new TeacherLevelRealize();
        }

        //教师类别管理
        public override TeacherSort TeacherSort()
        {
            return new TeacherSortRealize();
        }
        //教师教学风格管理
        public override TeacherStyle TeacherStyle()
        {
            return new TeacherStyleRealize();
        }

    }
}
