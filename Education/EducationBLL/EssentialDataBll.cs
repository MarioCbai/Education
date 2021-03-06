﻿using EducationDAL.EssentialData;
using EducationMODEL;
using EducationMODEL.Infrastructure;
using EducationMODEL.linkModel;
using EducationMODEL.OrderManagement;
using EducationMODEL.organizational;
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
        /// 来源表显示
        /// </summary>
        /// <returns></returns>
        public List<SourceMod> SourceShow()
        {
            return essentials.Source().SourceShow();
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
        /// //来源表根据id查询反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SourceMod SourceSelectById(int id)
        {
            return essentials.Source().SourceSelectById(id);
        }
        //来源管理判断名称唯一性
        public List<SourceMod> SourceShowName(string name)
        {
            return essentials.Source().SourceShowName(name);
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
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int SourceDelt(int id)
        {
            return essentials.Source().SourceDelt(id);
        }
        /// <summary>
        /// 来源表修改状态
        /// </summary>
        /// <param name="ztai"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int SourceZtai(int ztai, int id)
        {
            return essentials.Source().SourceZtai(ztai, id);
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
        //教师类别表根据id查询反填
        public TeacherTypeMod TeacherSortSelectById(int id)
        {
            return essentials.TeacherSort().TeacherSortSelectById(id);
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
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int TeacherSortDelt(int id)
        {
            return essentials.TeacherSort().TeacherSortDelt(id);
        }
        /// <summary>
        /// 教师类别修改状态
        /// </summary>
        /// <param name="ztai"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int TeacherSortZtai(int ztai, int id)
        {
            return essentials.TeacherSort().TeacherSortZtai(ztai, id);
        }
        //教师类别表判断名称唯一性
        public List<TeacherTypeMod> TeacherShow(string name)
        {
            return essentials.TeacherSort().TeacherShow(name);
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
        //教师水平表根据id查询反填
        public TeachinglevelMod TeacherLevelSelectById(int id)
        {
            return essentials.TeacherLevel().TeacherLevelSelectById(id);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int TeacherLevelDelt(int id)
        {
            return essentials.TeacherLevel().TeacherLevelDelt(id);
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
            return essentials.TeacherLevel().TeacherLevelZtai(ztai, id);
        }
        //教师水平表判断姓名唯一性
        public List<TeachinglevelMod> TeacherModShow(string name)
        {
            return essentials.TeacherLevel().TeacherModShow(name);
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
        //教师风格根据id查询反填
        public TeachingStyleMod TeacherStyleSelectById(int id)
        {
            return essentials.TeacherStyle().TeacherStyleSelectById(id);
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
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int TTeacherStyleDelt(int id)
        {
            return essentials.TeacherStyle().TTeacherStyleDelt(id);
        }
        /// <summary>
        /// 教师风格修改状态
        /// </summary>
        /// <param name="ztai"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int TeacherStyleZtai(int ztai, int id)
        {
            return essentials.TeacherStyle().TeacherStyleZtai(ztai, id);
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
        //教师风格表判断姓名唯一性
        public List<TeachingStyleMod> TeacherStyleShowName(string name)
        {
            return essentials.TeacherStyle().TeacherStyleShowName(name);
        }



        /// <summary>
        /// 课时类型添加
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        public int ClassTypeAdd(SubjectsHourTypeMod h)
        {
            return essentials.ClassType().ClassTypeAdd(h);
        }
        //课时表根据id查询反填
        public GG_SubjectsHourType ClassTypeSelectById(int id)
        {
            return essentials.ClassType().ClassTypeSelectById(id);
        }
        /// <summary>
        /// 课时表显示
        /// </summary>
        /// <returns></returns>
        public List<GG_SubjectsHourType> ClassTypeShow(string name = null, int xk = 0, int? bl = null)
        {
            return essentials.ClassType().ClassTypeShow(name,xk,bl);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int ClassTypeDelt(int id)
        {
            return essentials.ClassType().ClassTypeDelt(id);
        }
        /// <summary>
        /// 课时表修改
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        public int ClassTypeUpt(SubjectsHourTypeMod h)
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
            return essentials.ClassType().ClassTypeZtai(ztai, id);
        }
        //查询科目表绑定下拉
        public List<SubjectsMod> ClassTypeSelectAll()
        {
            return essentials.ClassType().ClassTypeSelectAll();
        }
        //查询课时表绑定下拉
        public List<HourTypeMod> HourTypeSelectAll()
        {
            return essentials.ClassType().HourTypeSelectAll();
        }
        /// <summary>
        /// 查询学科表绑定下拉
        /// </summary>
        /// <returns></returns>
        public List<SubjectsMod> SubjectsSelectAll()
        {
            return essentials.ClassType().SubjectsSelectAll();
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
        /// 价格级别表添加
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int PriceLevelAdd(PriceRankMod p)
        {
            return essentials.PriceLevel().PriceLevelAdd(p);
        }
        //价格级别表根据id查询反填
        public PriceRankMod PriceLevelSelectById(int id)
        {
            return essentials.PriceLevel().PriceLevelSelectById(id);
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
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int PriceLevelDelt(int id)
        {
            return essentials.PriceLevel().PriceLevelDelt(id);
        }
        /// <summary>
        /// 价格级别修改状态
        /// </summary>
        /// <param name="ztai"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int PriceLevelZtai(int ztai, int id)
        {
            return essentials.PriceLevel().PriceLevelZtai(ztai, id);
        }
        //价格级别表判断名称唯一性
        public List<PriceRankMod> PriceLevelShowName(string name)
        {
            return essentials.PriceLevel().PriceLevelShowName(name);
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
        public List<Subjects_HourT_Mod> PricingManagementShow(int ? hourprice =null, int ? pricehour =null, string name = null, int price = 0, int studying = 0, int hour = 0)
        {
            return essentials.PricingManagement().PricingManagementShow(hourprice, pricehour, name, price, studying, hour);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int PricingManagementDelt(int id)
        {
            return essentials.PricingManagement().PricingManagementDelt(id);
        }
        //查询价格级别表绑定下拉
        public List<PriceRankMod> SelectPriceRankModAll()
        {
            return essentials.PricingManagement().SelectPriceRankModAll();
        }
        //查询学段表绑定下拉
        public List<Study> SelectStudyModAll()
        {
            return essentials.PricingManagement().SelectStudyModAll();
        }
        //查询课时表绑定下拉
        public List<HourTypeMod> HourTypeModAll()
        {
            return essentials.PricingManagement().HourTypeModAll();
        }

        //修改课时单价
        public int PricingManagementUpt(PricingMod m)
        {
            return essentials.PricingManagement().PricingManagementUpt(m);
        }

        
    }
}
