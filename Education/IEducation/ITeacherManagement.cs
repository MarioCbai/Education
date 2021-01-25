using EducationMODEL.linkModel;
using EducationMODEL.TeacherManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace IEducation
{
    //教师管理
    public interface ITeacherManagement
    {
        #region 教师管理
        //教师管理显示
        List<TeachMod> GetTeaches(string teaname, string phone, int jigou, int sub, int bookid, int state);
        //教师管理显示1
        List<TeacherMod> GetTeacherMods(string teaname, string phone, int jigou, int tduid);
        //添加教师管理信息
        int AddTeacherMod(TeacherMod t);
        //删除教师管理信息
        int DeleteTeacherMod(int ids);
        //反填教师管理信息
        TeacherMod ModifyIdTeacherMod(int teacherid);
        //修改教师管理信息
        int ModifyTeacherMod(TeacherMod t);
        //修改教师管理状态
        int ModifyTeacherState(int status, int teaid);
        #endregion
        #region 教学基本信息
        //教学基本信息显示
        List<TeachMod> GetTeachMods();
        //教学基本信息新增
        int AddTeachMod(TeachMod tea);
        //教学基本信息反填
        TeachMod ModifyIdTeachMod(int id);
        //教学基本信息修改
        int ModifyTeachMod(TeachMod tea);
        //教学基本信息删除
        int DeleteTeachMod(int ids);
        #endregion
        #region 认证信息
        //认证信息显示
        List<ApproveMod> GetApproveMods();
        //认证信息添加
        int AddApproveMod(ApproveMod ap);
        //认证信息的反填
        ApproveMod ModifyIdApproveMod(int id);
        //认证信息的修改
        int ModifyApproveMod(ApproveMod ap);
        #endregion
        //教师
        List<TeacherMod> TeacherShow(int jibie , int leibie , string iphone , string name );
        #region 学历管理
        //学历表
        List<TeachereducationMod> GetTeachereducations();
        #endregion

    }
}
