using EducationMODEL.linkModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.EssentialData.ClasstypeManagements
{
    //班型管理
    public abstract class ClasstypeManagement
    {
        //班型管理增删改查
        //班型管理表显示
        public abstract List<ClassModelMod_BusinessTypeMod> ClasstypeManagementShow();

    }
}
