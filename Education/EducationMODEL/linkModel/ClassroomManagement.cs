using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.linkModel
{
    //课堂管理/好几表联查
   public class ClassroomManagement
    {
        //试听表正式课表
        public int AuditionID { get; set; }//主键

        public string AuditionType { get; set; }//课程类别 试听课和正式课

        public int StID { get; set; }//学段（外键）

        public int Grade { get; set; }//年级（外键）
        public string Data { get; set; }//年级（外键）

        public string AuditionClass { get; set; }//上课主题

        public DateTime AuditionDate { get; set; }//上课日期

        public object AuditionTime { get; set; }//上课时间
      

        public int AuditionState { get; set; }//课堂状态 ,1已上课，2已排课，3以备课，4以上课，5未上课，6已取消，7以退课,8返还课

        public string AuditionRemark { get; set; }//备注

        public int TeacherId { get; set; }//教师

        public int SubjectsId { get; set; }//学科

        public int HourTypeId { get; set; }//课时类型

        public int BusinessTypeId { get; set; }//业务类型 线上线下

        public int ClassModelId { get; set; }//班型表

        public int PeriodNum { get; set; } //课时数
        //试听课学生关系表课堂管理
        public int ASID { get; set; }
        public int Audition { get; set; }
        public int Student { get; set; }
 

        //学员表
        public int StudentId { get; set; }//主键Id

        public string StudentName { get; set; }//学员姓名

        public string StudentIDNo { get; set; }//学员身份证号

        public DateTime StudentBirthday { get; set; }//生日      

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

        //机构表递归
        public int OrganId { get; set; }//机构表主键

        public string OrganEncod { get; set; }//机构编码

        public string OrganName { get; set; }//机构名称

        public int InstitutionalId { get; set; }//机构类型外键

        public int PriceRankId { get; set; }//价格级别表外键

        public string OrganPhoneName { get; set; }//联系人

        public string OrganPhone { get; set; }//联系电话

        public int ProvinceId { get; set; }//省Id

        public int District { get; set; }//区Id --地区表外键 绑定下拉

        public string OrganRemark { get; set; }//备注

        public bool OrganStatus { get; set; }//状态 启用禁用

        public DateTime OrganBeginTime { get; set; }//创建时间 获取当前时间

        public int PId { get; set; }//递归表编号PId上级机构
        //学段年级递归表 
        public string StudyName { get; set; }  //年级
        //科目表
        public string SubjectsName { get; set; } //科目名称
       //教师基本信息表       

        public string TeacherName { get; set; }//教师名称

        public string TeacherOuter { get; set; }//对外显示姓名

        public bool TeacherSex { get; set; }//性别

        public string Teachereducation { get; set; }//学历  中专，大专，本科，硕士，博士，其他

        public string TeacherQQ { get; set; }//老师QQ

        public string TeacherWeChat { get; set; }//微信
   

        public bool TeacherTitle { get; set; }//老师职称教师助教1教师0助教

        public string TeacherPhone { get; set; }//手机号

        public string TeacherIDnumber { get; set; }//身份证号

        public string TeacherGraduate { get; set; }//毕业学校

        public string TeacherCom { get; set; }//邮箱

        public bool TeacherCard { get; set; }//教师资格证

        public string TeacherPwd { get; set; }//密码

        public string TeacherResume { get; set; }//个人简介

        public bool TeacherState { get; set; }//用户状态1启用 0禁用
        //课时类型管理表 
        public string HourTypeName { get; set; } //课时类别名称
        public int Sort { get; set; }            //排序
        public decimal Proportion { get; set; }  //比例
        public int Ztai { get; set; }         //状态
        //业务类型表      
        public string BusinessTypeName { get; set; } //业务名称
        //班型管理表
        public string ClassModelName { get; set; } //班型名称
        public string ClassModels { get; set; }  //进入课堂形式
        public int ClassModelNumber { get; set; }  //容纳学员人数  

        public string Auditor { get; set; }//审核人

    
        public string AuditorPTime { get; set; }//审核时间

        public int AuditStatus { get; set; }//审核状态
        public string FAFSAremark { get; set; } //备注
        public string FAFStype { get; set; } //申请类型
        public string Audittime { get; set; }  //申请时间

        public int StudyId { get; set; }
    }
}
