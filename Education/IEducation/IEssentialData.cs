﻿using EducationMODEL.Infrastructure;
using EducationMODEL.linkModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace IEducation
{
    //基本数据管理
    public interface IEssentialData
    {
        //来源管理
        //显示
        List<SourceMod> SourceShow();
        //添加
        int SourceAdd(SourceMod s);
        //修改
        int SourceUpt(SourceMod s);
        //修改状态
        int SourceZtai(int ztai, int id);


        //教师类别管理
        //显示
        List<TeacherTypeMod> TeacherSortShow();
        //添加
        int TeacherSortAdd(TeacherTypeMod t);
        //修改
        int TeacherSortUpt(TeacherTypeMod t);
        //修改状态
        int TeacherSortZtai(int ztai, int id);

        //教师水平级别管理
        //显示
        List<TeachinglevelMod> TeacherLevelShow();
        //添加
        int TeacherLevelAdd(TeachinglevelMod t);
        //修改
        int TeacherLevelUpt(TeachinglevelMod t);
        //修改状态
        int TeacherLevelZtai(int ztai, int id);

        //教师教学风格管理
        //显示
        List<TeachingStyleMod> TeacherStyleShow();
        //添加
        int TeacherStyleAdd(TeachingStyleMod t);
        //修改
        int TTeacherStyleUpt(TeachingStyleMod t);
        //修改状态
        int TeacherStyleZtai(int ztai, int id);


        //课时类型管理
        //添加
        List<HourTypeMod> ClassTypeShow();
        //显示
        int ClassTypeAdd(HourTypeMod h);
        //修改
        int ClassTypeUpt(HourTypeMod h);
        //修改状态
        int ClassTypeZtai(int ztai, int id);

        //班型管理
        //显示
        List<ClassModelMod_BusinessTypeMod> ClasstypeManagementShow();

        //定价级别管理
        //显示
        List<PriceRankMod> PriceLevelShow();
        //添加
        int PriceLevelAdd(PriceRankMod p);
        //修改
        int PriceLevelUpt(PriceRankMod p);
        //修改状态
        int PriceLevelZtai(int ztai, int id);

        //定价管理
        //显示查询
        List<Subjects_HourT_Mod> PricingManagementShow(int price = -1, int studying = -1, int hour = -1, int? hourprice = null, int? pricehour = null);
    }
}
