using EducationMODEL.TeacherManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.TeacherManagement.Credentialses
{
    //认证信息
    public abstract class Credentials
    {
        //增删改查
        //认证信息显示
        public abstract List<ApproveMod> GetApproveMods();
        //认证信息添加
        public abstract int AddApproveMod(ApproveMod ap);
        //认证信息的反填
        public abstract ApproveMod ModifyIdApproveMod(int id);
        //认证信息的修改
        public abstract int ModifyApproveMod(ApproveMod ap);
    }
}
