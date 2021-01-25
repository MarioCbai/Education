using EducationMODEL;
using EducationMODEL.Infrastructure;
using EducationMODEL.linkModel;
using EducationMODEL.OrderManagement;
using EducationMODEL.organizational;
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
        //来源表根据id查询反填
        public abstract SourceMod SourceSelectById(int id);
        public abstract List<SourceMod> SourceShowName(string name);

        //教师类别管理
        //显示
        List<TeacherTypeMod> TeacherSortShow();
        //添加
        int TeacherSortAdd(TeacherTypeMod t);
        //修改
        int TeacherSortUpt(TeacherTypeMod t);
        //修改状态
        int TeacherSortZtai(int ztai, int id);
        //教师类别表根据id查询反填
        public abstract TeacherTypeMod TeacherSortSelectById(int id);
        public abstract List<TeacherTypeMod> TeacherShow(string name);

        //教师水平级别管理
        //显示
        List<TeachinglevelMod> TeacherLevelShow();
        //添加
        int TeacherLevelAdd(TeachinglevelMod t);
        //修改
        int TeacherLevelUpt(TeachinglevelMod t);
        //修改状态
        int TeacherLevelZtai(int ztai, int id);
        //来源表根据id查询反填
        public abstract TeachinglevelMod TeacherLevelSelectById(int id);
        public abstract List<TeachinglevelMod> TeacherModShow(string name);

        //教师教学风格管理
        //显示
        List<TeachingStyleMod> TeacherStyleShow();
        //添加
        int TeacherStyleAdd(TeachingStyleMod t);
        //修改
        int TTeacherStyleUpt(TeachingStyleMod t);
        //修改状态
        int TeacherStyleZtai(int ztai, int id);
        //教师风格根据id查询反填
        public abstract TeachingStyleMod TeacherStyleSelectById(int id);
        public abstract List<TeachingStyleMod> TeacherStyleShowName(string name);

        //课时类型管理
        //添加
        List<Subjects_HourT_Mod> ClassTypeShow();
        //显示
        int ClassTypeAdd(SubjectsHourTypeMod h);
        //修改
        int ClassTypeUpt(SubjectsHourTypeMod h);
        //修改状态
        int ClassTypeZtai(int ztai, int id);
        //课时表根据id查询反填
        public abstract SubjectsHourTypeMod ClassTypeSelectById(int id);
        //查询科目表绑定下拉
        public abstract List<SubjectsMod> ClassTypeSelectAll();
        //查询课时表绑定下拉
        public abstract List<HourTypeMod> HourTypeSelectAll();

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
        //价格级别表根据id查询反填
        public abstract PriceRankMod PriceLevelSelectById(int id);
        //修改课时单价
        public abstract int PricingManagementUpt(PricingMod m);
        public abstract List<PriceRankMod> PriceLevelShowName(string name);

        //定价管理
        //显示查询
        List<Subjects_HourT_Mod> PricingManagementShow(int hourprice = 0, int pricehour = 0, string name=null,int price =0, int studying =0, int hour =0);
        //查询价格级别表绑定下拉
        public abstract List<PriceRankMod> SelectPriceRankModAll();
        //查询学段表绑定下拉
        public abstract List<Study> SelectStudyModAll();
        //查询课时表绑定下拉
        public abstract List<HourTypeMod> HourTypeModAll();
    }
}
