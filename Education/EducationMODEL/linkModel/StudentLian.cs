using EducationMODEL.organizational;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.linkModel
{
    public class StudentLian
    {
        public string  shen { get; set; }//审核
        public string  kezhuang { get; set; }//课堂状态
        public string  tiem { get; set; }
        public string  zhuang { get; set; }

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
        public string Counselor { get; set; }//咨询师
        public string StudyName { get; set; }  //学段年级名称
        public int StudyId { get; set; }   //父级编号
        public int OrganId { get; set; }//机构表主键

        public string OrganEncod { get; set; }//机构编码

        public string OrganName { get; set; }//机构名称

        public int InstitutionalId { get; set; }//机构类型外键

        public int InstitutionalName { get; set; }//机构类型名称

        public int PriceRankId { get; set; }//价格级别表外键

        public string OrganPhoneName { get; set; }//联系人

        public string OrganPhone { get; set; }//联系电话

        public int ProvinceId { get; set; }//省Id


        public string SitesName { get; set; }//省Id名称
        public int District { get; set; }//区Id --地区表外键 绑定下拉

        public string OrganRemark { get; set; }//备注

        public bool OrganStatus { get; set; }//状态 启用禁用

        public DateTime OrganBeginTime { get; set; }//创建时间 获取当前时间

        public int PId { get; set; }//递归表编号PId上级机构
        public string OrganAddress { get; set; }//具体地址
        public int AuditionID { get; set; }//主键

        public string AuditionType { get; set; }//课程类别 试听课和正式课

        public string ClassModelName { get; set; } //班型

        public int Grade { get; set; }//年级（外键）

        public string AuditionClass { get; set; }//上课主题

        public string AuditionDate { get; set; }//上课日期

        public string AuditionTime { get; set; }//上课时间

        public int AuditionState { get; set; }//课堂状态 ,1已上课，2已排课，3以备课，4以上课，5未上课，6已取消，7以退课,8返还课

        public string AuditionRemark { get; set; }//备注

        public int TeacherId { get; set; }//教师
        public string TeacherName { get; set; }//教师名称
        public int ASID { get; set; }//主键

        public int SubjectsId { get; set; }//学科

        public int HourTypeId { get; set; }//课时类型

        public int BusinessTypeId { get; set; }//业务类型 线上线下

        public int ClassModelId { get; set; }//班型表

        public string title { get { return OrganName; } }//标题名称
        public List<OrganMod> children { get; set; }//子节点
        public int State { get; set; }//审核
    }
}
