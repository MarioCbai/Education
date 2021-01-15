using EducationDAL.EssentialData;
using EducationMODEL.Infrastructure;
using EducationMODEL.linkModel;
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
        /// <summary>
        /// 课时类型添加
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        public int ClassTypeAdd(HourTypeMod h)
        {
            return essentials.ClassType().ClassTypeAdd(h);
        }
        /// <summary>
        /// 班型显示
        /// </summary>
        /// <returns></returns>
        public List<ClassModelMod_BusinessTypeMod> ClasstypeManagementShow()
        {
            return essentials.ClasstypeManagement().ClasstypeManagementShow();
        }
        /// <summary>
        /// 课时表显示
        /// </summary>
        /// <returns></returns>
        public List<HourTypeMod> ClassTypeShow()
        {
            return essentials.ClassType().ClassTypeShow();
        }
        /// <summary>
        /// 课时表修改
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        public int ClassTypeUpt(HourTypeMod h)
        {
            return essentials.ClassType().ClassTypeUpt(h);
        }
        /// <summary>
        /// 课时表的修改状态
        /// </summary>
        /// <param name="ztai"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int ClassTypeZtai(int ztai, int id)
        {
            return essentials.ClassType().ClassTypeZtai(ztai,id);
        }
        /// <summary>
        /// 价格级别表添加
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int PriceLevelAdd(PriceRankMod p)
        {
            return essentials.PriceLevel().PriceLevelAdd(p);
        }

        /// <summary>
        /// 价格级别表显示
        /// </summary>
        /// <returns></returns>
        public List<PriceRankMod> PriceLevelShow()
        {
            return essentials.PriceLevel().PriceLevelShow();
        }
        /// <summary>
        /// 价格级别修改
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int PriceLevelUpt(PriceRankMod p)
        {
            return essentials.PriceLevel().PriceLevelUpt(p);
        }
        /// <summary>
        /// 价格级别修改状态
        /// </summary>
        /// <param name="ztai"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int PriceLevelZtai(int ztai, int id)
        {
            return essentials.PriceLevel().PriceLevelZtai(ztai,id);
        }
        /// <summary>
        /// 定价表显示
        /// </summary>
        /// <param name="price"></param>
        /// <param name="studying"></param>
        /// <param name="hour"></param>
        /// <param name="hourprice"></param>
        /// <param name="pricehour"></param>
        /// <returns></returns>
        public List<Subjects_HourT_Mod> PricingManagementShow(int price = -1, int studying = -1, int hour = -1, int? hourprice = null, int? pricehour = null)
        {
            return essentials.PricingManagement().PricingManagementShow(price, studying, hour, hourprice, pricehour);
        }
        /// <summary>
        /// 来源表添加
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int SourceAdd(SourceMod s)
        {
            return essentials.Source().SourceAdd(s);
        }
        /// <summary>
        /// 来源表显示
        /// </summary>
        /// <returns></returns>
        public List<SourceMod> SourceShow(string name = null)
        {
            return essentials.Source().SourceShow(name);
        }
        /// <summary>
        /// 来源表修改
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int SourceUpt(SourceMod s)
        {
            return essentials.Source().SourceUpt(s);
        }
        /// <summary>
        /// 来源表修改状态
        /// </summary>
        /// <param name="ztai"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int SourceZtai(int ztai, int id)
        {
            return essentials.Source().SourceZtai(ztai,id);
        }
        /// <summary>
        /// 教师水平表添加
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int TeacherLevelAdd(TeachinglevelMod t)
        {
            return essentials.TeacherLevel().TeacherLevelAdd(t);
        }
        /// <summary>
        /// 教师水平表显示
        /// </summary>
        /// <returns></returns>
        public List<TeachinglevelMod> TeacherLevelShow()
        {
            return essentials.TeacherLevel().TeacherLevelShow();
        }
        /// <summary>
        /// 教师水平表修改
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int TeacherLevelUpt(TeachinglevelMod t)
        {
            return essentials.TeacherLevel().TeacherLevelUpt(t);
        }
        /// <summary>
        /// 教师水平表修改状态
        /// </summary>
        /// <param name="ztai"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int TeacherLevelZtai(int ztai, int id)
        {
            return essentials.TeacherLevel().TeacherLevelZtai(ztai,id);
        }
        /// <summary>
        /// 教师类别添加
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int TeacherSortAdd(TeacherTypeMod t)
        {
            return essentials.TeacherSort().TeacherSortAdd(t);
        }
        /// <summary>
        /// 教师类别显示
        /// </summary>
        /// <returns></returns>
        public List<TeacherTypeMod> TeacherSortShow()
        {
            return essentials.TeacherSort().TeacherSortShow();
        }
        /// <summary>
        /// 教师类别修改
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int TeacherSortUpt(TeacherTypeMod t)
        {
            return essentials.TeacherSort().TeacherSortUpt(t);
        }
        /// <summary>
        /// 教师类别修改状态
        /// </summary>
        /// <param name="ztai"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int TeacherSortZtai(int ztai, int id)
        {
            return essentials.TeacherSort().TeacherSortZtai(ztai,id);
        }
        /// <summary>
        /// 教师风格添加
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int TeacherStyleAdd(TeachingStyleMod t)
        {
            return essentials.TeacherStyle().TeacherStyleAdd(t);
        }
        /// <summary>
        /// 教师风格显示
        /// </summary>
        /// <returns></returns>
        public List<TeachingStyleMod> TeacherStyleShow()
        {
            return essentials.TeacherStyle().TeacherStyleShow();
        }
        /// <summary>
        /// 教师风格修改状态
        /// </summary>
        /// <param name="ztai"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int TeacherStyleZtai(int ztai, int id)
        {
            return essentials.TeacherStyle().TeacherStyleZtai(ztai,id);
        }
        /// <summary>
        /// 教师风格修改
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int TTeacherStyleUpt(TeachingStyleMod t)
        {
            return essentials.TeacherStyle().TTeacherStyleUpt(t);
        }
    }
}
