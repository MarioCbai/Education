using EducationDAL.TeacherManagement;
using EducationMODEL.TeacherManagement;
using IEducation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationBLL
{
    //教师管理
    public class TeacherManagementBll: ITeacherManagement
    {
        Teacher teachers = new TeacherPlant();
        //教师管理显示
        public List<TeachMod> GetTeaches()
        {
            return teachers.Teacheres().GetTeaches();
        }
        //教师管理显示1
        public  List<TeacherMod> GetTeacherMods()
        {
            return teachers.Teacheres().GetTeacherMods();
        }
        //添加教师管理信息
        public int AddTeacherMod(TeacherMod t)
        {
            return teachers.Teacheres().AddTeacherMod(t);
        }
        //删除教师管理信息
        public int DeleteTeacherMod(int ids)
        {
            return teachers.Teacheres().DeleteTeacherMod(ids);
        }
        //反填教师管理信息
        public TeacherMod ModifyIdTeacherMod(int id)
        {
            return teachers.Teacheres().ModifyIdTeacherMod(id);
        }
        //修改教师管理信息
        public int ModifyTeacherMod(TeacherMod t)
        {
            return teachers.Teacheres().ModifyTeacherMod(t);
        }
    }
}
