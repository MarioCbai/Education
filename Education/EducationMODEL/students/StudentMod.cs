using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.students
{
   public class StudentMod//学员表
    {
        public int StudentId { get; set; }//主键Id

        public string StudentName { get; set; }//学员姓名

        public string StudentIDNo { get; set; }//学员身份证号

        public DateTime StudentBirthday { get; set; }//生日

        public int StID { get; set; }//学段年纪递归表

        public string StudentWeChat { get; set; }//学员微信

        public string StudentQQ { get; set; }//学员QQ

        public string StudentIphone { get; set; }//学员手机号 

        public string StudentPwd { get; set; }//学员密码

        public bool StudentSex { get; set; }//学员性别

        public string StudentSchool { get; set; }//学员学校

        public int Province { get; set; }//省ID

        public int City { get; set; }//市ID

        public int County { get; set; }//区县ID

        public string StudentSite { get; set; }//学员地址

        public string StudentQuality { get; set; }//质量度		ABCDEF

        public int Institution { get; set; }//所+属机构

        public int StudentKind { get; set; }//学员状态是否成单：1成 0意向
    }
}
