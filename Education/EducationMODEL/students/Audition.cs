using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.students
{
    public class Audition//试听表正式课表排课表
    {
        public int AuditionID { get; set; }//主键

        public int AuditionType { get; set; }//课程类别 试听课和正式课

        public int StID { get; set; }//学段（外键）

        public int Grade { get; set; }//年级（外键）

        public string AuditionClass { get; set; }//上课主题

        public DateTime AuditionDate { get; set; }//上课日期

        public DateTime AuditionTime { get; set; }//上课时间

        public int AuditionState { get; set; }//课堂状态 ,1已上课，2已排课，3以备课，4以上课，5未上课，6已取消，7以退课,8返还课

        public string AuditionRemark { get; set; }//备注

        public int TeacherId { get; set; }//教师

        public int SubjectsId { get; set; }//学科

        public int HourTypeId { get; set; }//课时类型

        public int BusinessTypeId { get; set; }//业务类型 线上线下

        public int ClassModelId { get; set; }//班型表
    }
}
