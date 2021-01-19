using EducationMODEL.TeacherManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace IEducation
{
    //教师管理
    public interface ITeacherManagement
    {
        //教师管理显示
        List<TeachMod> GetTeaches();
        //教师管理显示1
        List<TeacherMod> GetTeacherMods();
        //添加教师管理信息
        int AddTeacherMod(TeacherMod t);
        //删除教师管理信息
        int DeleteTeacherMod(int ids);
        //反填教师管理信息
        TeacherMod ModifyIdTeacherMod(int id);
        //修改教师管理信息
        int ModifyTeacherMod(TeacherMod t);
        
    }
}
