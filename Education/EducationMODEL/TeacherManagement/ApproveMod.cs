using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.TeacherManagement
{
    public class ApproveMod//教师认证信息
    {
        public int ApproveID { get; set; }//主键id

        public string IDnumberPic { get; set; }//身份证(正面上传)

        public string EducationPic { get; set; }//学历证书(上传)

        public string IdentificationPic { get; set; }//教师身份证明

        public int Teacher { get; set; }//教师基本表外键
        public string TeacherName { get; set; }//教师基本表外键
    }
}
