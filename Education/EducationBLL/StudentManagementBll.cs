using EducationDAL.StudentManagement;
using EducationMODEL.Infrastructure;
using EducationMODEL.linkModel;
using EducationMODEL.OrderManagement;
using EducationMODEL.organizational;
using EducationMODEL.students;
using EducationMODEL.TeacherManagement;
using IEducation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationBLL
{
    //学员管理
    public class StudentManagementBll: IStudentManagement
    {
        Student students = new StudentPlant();

        //添加家长
        public int AddParetn(PatriarchMod p)
        {
            return students.Parents().AddParent(p);
        }



        //删除家长信息
        public int DelPatrn(int id)
        {
            return students.Parents().DelParents(id);
        }

        //地址
        public List<SitesMod> Dizhi(int id)
        {
            return students.Students().Dizhi(id);
        }

        /// <summary>
        /// 家长信息反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PatriarchMod FanParent(int id)
        {
            return students.Parents().FanParent(id);
        }

        /// <summary>
        /// 来源显示
        /// </summary>
        /// <returns></returns>
        public List<SourceMod> LaiShow()
        {
            return students.Students().LaiShow();
        }

        /// <summary>
        /// 家长信息显示
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<PatriarchMod> PartriarchShow(int id)
        {
            return students.Parents().ParentsShow(id);
        }

        //添加课表
        public int ScheduleAdd(AuditionMod aa)
        {
            return students.Students().ScheduleAdd(aa);
        }

        //学员详细信息
        public StudentLian SelStudent(int id)
        {
            return students.Students().SelStudent(id);
        }

        //正式学员显示
        public List<StudentLian> ShowOfficial(int jigou, string zi, string zhi, int nian, string name, string iphone)
        {
            return students.Students().ShowOfficial(jigou, zi, zhi, nian, name, iphone);
        }

        //学员信息
        public StudentMod ShowSan(int id)
        {
            return students.Students().ShowSan(id);
        }

        /// <summary>
        /// 学员添加
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int StudentAdd(StudentMod s)
        {
            return students.Students().StudentAdd(s);
        }

        /// <summary>
        /// 意向学员显示
        /// </summary>
        /// <param name="jigou"></param>
        /// <param name="zi"></param>
        /// <param name="zhi"></param>
        /// <param name="nian"></param>
        /// <param name="name"></param>
        /// <param name="iphone"></param>
        /// <returns></returns>
        public List<StudentLian> StudentShow(int jigou, string zi, string zhi, int nian, string name, string iphone)
        {
            return students.Students().StudentShow(jigou,zi,zhi,nian,name,iphone);
        }

        //学员显示
        public List<StudentLian> StudentShow(int zhuang, int jigou, string zi, string zhi, int nian, string name, string iphone)
        {
            return students.Students().StudentShow(zhuang,jigou, zi, zhi, nian, name, iphone);
        }

        //试听课
        public List<StudentLian> TrialClass()
        {
            return students.Scheduling().TrialClass();
        }

        //正式课
        public List<StudentLian> TrialClasss()
        {
            return students.Scheduling().TrialClasss();
        }



        /// <summary>
        /// 家长信息修改
        /// </summary>
        /// <param name="pp"></param>
        /// <returns></returns>
        public int UptParent(PatriarchMod pp)
        {
            return students.Parents().UptParent(pp);
        }

        //学
        public List<Study> Xue(int id)
        {
            return students.Students().Xue(id);
        }
    }
}
