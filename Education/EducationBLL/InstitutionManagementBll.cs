using EducationDAL.InstitutionManagement;
using EducationMODEL.OrderManagement;
using EducationMODEL.organizational;
using EducationMODEL.students;
using IEducation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationBLL
{
    //机构管理
    public  class InstitutionManagementBll: IInstitutionManagement
    {
        Institution institutions = new InstitutionPlant();
        #region 机构管理
        //机构管理显示
        public List<OrganMod> GetOrganMods(string name = null)
        {
            return institutions.Organ().GetOrganMods(name);
        }
        //机构管理下拉
        public List<OrganMod> OrganMods()
        {
            return institutions.Organ().OrganMods();
        }
        //添加机构管理
        public int AddOrganes(OrganMod organ)
        {
            return institutions.Organ().AddOrganes(organ);
        }
        //反填机构管理信息        
        public OrganMod ModiyIdOrganes(int orgid)
        {
            return institutions.Organ().ModiyIdOrganes(orgid);
        }
        //修改机构管理信息
        public int ModiyOrganes(OrganMod organ)
        {
            return institutions.Organ().ModiyOrganes(organ);
        }
        //单删除机构管理信息
        public int DeleteOrganes(int ids)
        {
            return institutions.Organ().DeleteOrganes(ids);
        }
        ////反填机构管理状态
        //public OrganMod ModiyIdStates(int orgids)
        //{
        //    return institutions.Organ().ModiyIdStates(orgids);
        //}
        //修改机构管理状态
        public int ModiyStates(int status, int orgid)
        {
            return institutions.Organ().ModiyStates(status, orgid);
        }
        //查询顶级节点
        public List<OrganMod> GetList()
        {
            return institutions.Organ().GetList();
        }
        //查询子节点
        public List<OrganMod> Gets(int id)
        {
            return institutions.Organ().Gets(id);
        }
        //绑定上级机构
        public List<OrganMod> GetOrganName()
        {
            return institutions.Organ().GetOrganName();
        }
        //绑定机构类型
        public List<InstitutionalMod> GetInstitutionalMods()
        {
            return institutions.OrganesType().GetInstitutionalMods();
        }
        //绑定省
        public List<OrganMod> GetProvinceId()
        {
            return institutions.Organ().GetProvinceId();
        }
        //绑定市
        public List<OrganMod> GetCity()
        {
            return institutions.Organ().GetCity();
        }
        //绑定区
        public List<OrganMod> GetDistrict()
        {
            return institutions.Organ().GetDistrict();
        }
        #endregion
        #region 班级管理
        //班级管理显示
        public List<ClassRoomMod> GetClassRooms(string roomname, int sub, int jigou, int stid, DateTime? HourBeginTime, DateTime? HourEngTime)
        {
            return institutions.ClassManagement().GetClassRooms(roomname,sub, jigou, stid,HourBeginTime,HourEngTime);
        }
        //添加班级管理数据
        public int AddClassRooms(ClassRoomMod Room)
        {
            return institutions.ClassManagement().AddClassRooms(Room);
        }
        //反填班级管理
        public ClassRoomMod ModifyIdClassRoomMod(int id)
        {
            return institutions.ClassManagement().ModifyIdClassRoomMod(id);
        }
        //修改班级管理数据
        public int ModifyClassRoomMod(ClassRoomMod Room)
        {
            return institutions.ClassManagement().ModifyClassRoomMod(Room);
        }
        //删除班级管理数据
        public int DeleteClassRoomMod(int ids)
        {
            return institutions.ClassManagement().DeleteClassRoomMod(ids);
        }
        //绑定年级下拉
        public  List<Study> GetRoomStudys()
        {
            return institutions.ClassManagement().GetRoomStudys();
        }
        //绑定版本下拉
        public  List<TextbookMod> GetTextbookMod()
        {
            return institutions.ClassManagement().GetTextbookMod();
        }
        #endregion
        #region 科目表
        //科目表显示
        public  List<SubjectsMod> GetSubjects()
        {
            return institutions.Subject().GetSubjects();
        }
        #endregion
        #region 学期表
        //学期表显示
        public  List<SemesterMod> GetSemesters()
        {
            return institutions.Semester().GetSemesters();
        }
        #endregion
        #region 课时包
        //课时包显示
        public  List<HourTableMod> HourTableMods()
        {
            return institutions.HourTable().HourTableMods();
        }
        //课时包反填
        public HourTableMod ModifyIdHourTableMods(int id)
        {
            return institutions.HourTable().ModifyIdHourTableMods(id);
        }
        //课时包修改
        public int ModifyHourTableMods(HourTableMod hour)
        {
            return institutions.HourTable().ModifyHourTableMods(hour);
        }
        #endregion
    }
}
