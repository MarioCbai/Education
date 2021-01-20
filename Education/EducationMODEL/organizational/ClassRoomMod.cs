using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.organizational
{
    public class ClassRoomMod//班级管理表
    {
        public int ClassRoomId { get; set; }//序号

        public string ClassRoomName { get; set; }//班级名称

        public int StID { get; set; }//年级 年级表外键

        public int SubjectsId { get; set; }//科目 科目表外键

        public int TextbookId { get; set; }//版本 版本表外键

        public int SemesterId { get; set; }//学期 学期表外键

        public int TeacherId { get; set; }//任课老师 教师表外键 	

        public int HourId { get; set; }//课时 课时包表外键 

        public int OrganId { get; set; }//机构  机构表外键

        public string HourName { get; set; }//课时包名称
        public DateTime HourBeginTime { get; set; }//课时包表有效期开始时间

        public DateTime HourEngTime { get; set; }//课时包表有效期结束时间
        public string SemesterName { get; set; }//学期表名称
        public string SubjectsName { get; set; }//科目名称
        public string TeacherName { get; set; }//教师名称
        public string StudyName { get; set; }//年级名称
        public string TextbookName { get; set; }//版本名称
        public string OrganName { get; set; }//机构名称

    }
}
