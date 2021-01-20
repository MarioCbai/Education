using System;
using System.Collections.Generic;
using System.Text;
using EducationMODEL.linkModel;
using EducationMODEL.OrderManagement;
using EducationMODEL.organizational;


namespace EducationDAL.TeachingManagement.Classrooms
{
    //课堂管理
    public abstract class Classroom
    {
        //课堂管理显示
        public abstract List<ClassroomManagement> ManagementShow(string OrganName = "", string BusinessTypeName = "", string ClassModelName = "", string AuditionType = "", string HourTypeName = "", string AuditionState = "", string StudyName = "", string SubjectsName = "", string OrganPhoneName = "", string TeacherName = "", DateTime? AuditionTime1 = null, DateTime? AuditionTime = null,string StudentName="");
        //查看
        public abstract List<ClassroomManagement> Examine(string StudentId);
        //机构表的查询
        public abstract List<Managethedrop_down> Organ();
        //业务类型  BusinessType
        public abstract List<Managethedrop_down> BusinessType();
        //班型   ClassModel
        public abstract List<Managethedrop_down> ClassModel();
        //课时类型  HourType
        public abstract List<Managethedrop_down> HourType();
        // 年级  Study
        public abstract List<Managethedrop_down> Study();
        //学科//科目  Subjects
        public abstract List<Managethedrop_down> Subjects();

    }
}
