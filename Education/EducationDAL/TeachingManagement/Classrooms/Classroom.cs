using System;
using System.Collections.Generic;
using System.Text;
using EducationMODEL.linkModel;
namespace EducationDAL.TeachingManagement.Classrooms
{
    //课堂管理
    public abstract class Classroom
    {
        //课堂管理显示
        public abstract List<ClassroomManagement> ManagementShow();

    }
}
