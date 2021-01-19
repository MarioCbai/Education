using EducationMODEL.linkModel;
using EducationMODEL.students;
using System;
using System.Collections.Generic;
using System.Text;

namespace IEducation
{
    //学员管理
    public interface IStudentManagement
    {
        //意向学员查询
        List<StudentLian> StudentShow(int jigou,string zi,string  zhi,int nian,string name,string iphone);
    }
}
