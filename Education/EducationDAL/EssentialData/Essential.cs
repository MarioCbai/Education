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
    //基础数据管理
    public abstract class Essential
    {
        /// <summary>
        /// 来源管理
        /// </summary>
        /// <returns></returns>
        public abstract Source Source();
        /// <summary>
        /// 教师类别管理
        /// </summary>
        /// <returns></returns>
        public abstract TeacherSort TeacherSort();
        /// <summary>
        /// 教师水平级别管理
        /// </summary>
        /// <returns></returns>
        public abstract TeacherLevel TeacherLevel();
        /// <summary>
        /// 教师教学风格管理
        /// </summary>
        /// <returns></returns>
        public abstract TeacherStyle TeacherStyle();
        /// <summary>
        /// 课时类型管理
        /// </summary>
        /// <returns></returns>
        public abstract ClassType ClassType();
        /// <summary>
        /// 价格级别管理
        /// </summary>
        /// <returns></returns>
        public abstract PriceLevel PriceLevel();
        /// <summary>
        /// 定价管理
        /// </summary>
        /// <returns></returns>
        public abstract PricingManagement PricingManagement();
        /// <summary>
        /// 课型管理
        /// </summary>
        /// <returns></returns>
        public abstract ClasstypeManagement ClasstypeManagement();
    }
}
