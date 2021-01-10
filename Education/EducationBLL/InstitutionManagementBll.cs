using EducationDAL.InstitutionManagement;
using IEducation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationBLL
{
    //机构管理
    public  class InstitutionManagementBll: IInstitutionManagement
    {
        Institution institutions = new InstitutionPlant();
    }
}
