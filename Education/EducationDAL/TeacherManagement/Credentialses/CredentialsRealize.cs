using EducationMODEL.TeacherManagement;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EducationDAL.TeacherManagement.Credentialses
{
    //认证信息实现
    public class CredentialsRealize: Credentials
    {
        //认证信息显示
        public override List<ApproveMod> GetApproveMods()
        {
            return DapperHelper.Query<ApproveMod>("select *from Approve app join Teacher tea on app.Teacher=tea.TeacherId", " ");
        }
        //认证信息添加
        public override int AddApproveMod(ApproveMod ap)
        {
            return DapperHelper.Execute("insert into Approve values(@IDnumberPic,@EducationPic,@IdentificationPic,@Teacher)", new { ap.IDnumberPic,ap.EducationPic,ap.IdentificationPic,ap.Teacher});
        }
        //认证信息的反填
        public override ApproveMod ModifyIdApproveMod(int id)
        {
            return DapperHelper.Query<ApproveMod>("select *from Approve where ApproveID=@ApproveID", new { ApproveID =id}).FirstOrDefault();
        }
        //认证信息的修改
        public override int ModifyApproveMod(ApproveMod ap)
        {
            return DapperHelper.Execute("update Approve set IDnumberPic=@IDnumberPic,EducationPic=@EducationPic,IdentificationPic=@IdentificationPic,Teacher=@Teacher where ApproveID=@ApproveID",
                new {ap.IDnumberPic,ap.EducationPic,ap.IdentificationPic,ap.Teacher,ap.ApproveID });
        }
    }
}
