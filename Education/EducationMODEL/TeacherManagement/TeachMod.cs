using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.TeacherManagement
{
    public class TeachMod//教学信息表
    {
        public int TeachId { get; set; }//id

        public int TeacherType { get; set; }//教师类别(外键)
        public string TeacherTypeName { get; set; }//教师类别(外键)
        public int TeacherRank { get; set; }//教师级别（外键）

        public string TeacherShowKe { get; set; }//可授课时

        public string TeacherLink { get; set; }//学段/学科/版本

        public int RecursionId { get; set; }//可授机构  所属机构绑定下拉(外键)

        public string TeacherYType { get; set; }//可授业务类型

        public int TeacherAge { get; set; }//老师教龄

        public string TeacherStyle { get; set; }//教学风格

        public int SubjectsId { get; set; }//学科外键
        public string SubjectsName { get; set; }//学科名称

        public int TextbookId { get; set; }//版本外键
        public string TextbookName { get; set; }//版本名称

        public DateTime TeacherTime { get; set; }//注册时间

        public int Teacher { get; set; }//教师基本表外键
        public string TeacherName { get; set; }//教师基本表外键
        public int OrganId { get; set; }//机构表外键
        public string OrganName { get; set; }//教师基本表外键
        public string TeacherPhone { get; set; }//手机号
        public int TeacherState { get; set; }//用户状态1启用 0禁用
        public string TeacherTitle { get; set; }//老师职称教师助教1教师0助教

    }
}
