using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.organizational
{
    public class ClassRoom//班级管理表
    {
        public int ClassRoomId { get; set; }//序号

        public string ClassRoomName { get; set; }//班级名称

        public int StID { get; set; }//年级 年级表外键

        public int SubjectsId { get; set; }//科目 科目表外键

        public int VersionsId { get; set; }//版本 版本表外键

        public int SemesterId { get; set; }//学期 学期表外键

        public int TeacherId { get; set; }//任课老师 教师表外键 	

        public int HourId { get; set; }//课时 课时包表外键 

        public int OrganId { get; set; }//机构  机构表外键
    }
}
