using EducationMODEL.Infrastructure;
using EducationMODEL.linkModel;
using EducationMODEL.OrderManagement;
using EducationMODEL.organizational;
using EducationMODEL.students;
using EducationMODEL.TeacherManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace IEducation
{
    //学员管理
    public interface IStudentManagement
    {

        //学段年级
        List<Study> Xue(int id);
        //家长信息
        int DelPatrn(int id);
        //意向学员查询
        List<StudentLian> StudentShow(int jigou,string zi,string  zhi,int nian,string name,string iphone);
        //来源查询
        List<SourceMod> LaiShow();
        //添加家长信息
        int AddParetn(PatriarchMod p);

        //学生信息
        StudentMod ShowSan(int id);

        // 学员添加
        int StudentAdd(StudentMod s);
        //地区
        List<SitesMod> Dizhi(int id);
        //家长信息
        List<PatriarchMod> PartriarchShow(int id);

        //家长信息反填
        PatriarchMod FanParent(int id);

        //家长信息修改
        int UptParent(PatriarchMod pp);

    }
}
