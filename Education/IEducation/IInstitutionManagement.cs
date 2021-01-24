using EducationMODEL.OrderManagement;
using EducationMODEL.organizational;
using EducationMODEL.students;
using System;
using System.Collections.Generic;
using System.Text;

namespace IEducation
{
    //机构管理
    public interface IInstitutionManagement
    {
        #region 机构管理
        //机构管理显示
        List<OrganMod> GetOrganMods();
        //机构管理下拉
        List<OrganMod> OrganMods();
        //添加机构信息
        int AddOrganes(OrganMod organ);
        //反填机构管理信息
        OrganMod ModiyIdOrganes(int orgid);
        //修改机构管理信息
        int ModiyOrganes(OrganMod organ);
        //单删除机构管理信息
        int DeleteOrganes(int ids);
        //修改机构管理状态
        int ModiyStates(int status, int orgid);

        //绑定上级机构
        List<OrganMod> GetOrganName();

        //查询顶级节点
        List<OrganMod> GetList();
        //查询子节点
        List<OrganMod> Gets(int id);
        //机构类型表
        List<InstitutionalMod> GetInstitutionalMods();
        //绑定省
        List<OrganMod> GetProvinceId();
        //绑定市
        List<OrganMod> GetCity();
        //绑定区
        List<OrganMod> GetDistrict();
        #endregion
        #region 班级管理
        //班级管理显示
        List<ClassRoomMod> GetClassRooms(string roomname = null, int sub = 0, int xq = 0);
        //添加班级管理信息
        int AddClassRooms(ClassRoomMod Room);
        //反填班级管理信息
        ClassRoomMod ModifyIdClassRoomMod(int id);
        //修改班级管理信息
        int ModifyClassRoomMod(ClassRoomMod Room);
        //删除班级管理信息
        int DeleteClassRoomMod(int ids);
        //绑定班级下拉
        List<Study> GetRoomStudys();
        //绑定版本下拉
        List<TextbookMod> GetTextbookMod();
        #endregion
        #region 科目表
        //科目表显示
        List<SubjectsMod> GetSubjects();
        #endregion
        #region 学期表
        //学期表显示
        List<SemesterMod> GetSemesters();
        #endregion
        #region 课时包
        //课时包显示
        List<HourTableMod> HourTableMods();
        //课时包反填
        HourTableMod ModifyIdHourTableMods(int id);
        //课时包修改
        int ModifyHourTableMods(HourTableMod hour);
        #endregion
    }
}
