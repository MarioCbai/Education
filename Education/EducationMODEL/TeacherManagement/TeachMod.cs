using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.TeacherManagement
{
    public class TeachMod//教学信息表
    {
        public int TeachId { get; set; }//id

        public int TeacherType { get; set; }//教师类别(外键)

        public int TeacherRank { get; set; }//教师级别（外键）

        public string TeacherShowKe { get; set; }//可授课时

        public string TeacherLink { get; set; }//学段/学科/版本

        public int RecursionId { get; set; }//可授机构  所属机构绑定下拉(外键)

        public string TeacherYType { get; set; }//可授业务类型

        public int TeacherAge { get; set; }//老师教龄

        public string TeacherStyle { get; set; }//教学风格

        public int SubjectsId { get; set; }//学科外键

        public int VersionsId { get; set; }//版本外键

        public DateTime TeacherTime { get; set; }//注册时间

        public int Teacher { get; set; }//教师基本表外键
    }
}
