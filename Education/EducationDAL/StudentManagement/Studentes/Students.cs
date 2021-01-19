using EducationMODEL.linkModel;
using EducationMODEL.students;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.StudentManagement.Studentes
{
    //学员增删改查 声明
    public abstract class Students
    {
        //意向学员方法的声明
        public abstract List<StudentLian> StudentShow(int jigou, string zi, string  zhi, int nian, string name, string iphone);
    }
}
