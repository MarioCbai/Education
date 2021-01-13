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

        //班型管理表添加
        public abstract int ClasstypeManagementAdd(ClassModelMod_BusinessTypeMod c);

        //班型管理表编辑
        public abstract int ClasstypeManagementUpt(ClassModelMod_BusinessTypeMod c);

        //班型管理表状态修改
        public abstract int ClasstypeManagementZtai(int ztai, int id);
    }
}
