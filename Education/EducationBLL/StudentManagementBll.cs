using EducationDAL.StudentManagement;
using EducationMODEL.linkModel;
using EducationMODEL.students;
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
    }
}
