using EducationDAL.TeachingManagement;
using EducationMODEL.linkModel;
using IEducation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationBLL
{
    //教学管理
    public class TeachingManagementBll:ITeachingManagement
    {
        Teaching teachings = new TeachingPlant();
        //课堂管理显示
        public List<ClassroomManagement> ManagementShow()
        {
            return teachings.Classroom().ManagementShow();
        }
    }
}
