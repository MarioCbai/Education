using EducationMODEL.linkModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace IEducation
{
    //教学管理
    public interface ITeachingManagement
    {
        //课堂管理显示
        public abstract List<ClassroomManagement> ManagementShow();
    }
}
