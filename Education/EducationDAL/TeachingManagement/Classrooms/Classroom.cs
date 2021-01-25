using System;
using System.Collections.Generic;
using System.Text;
using EducationMODEL.linkModel;
using EducationMODEL.OrderManagement;
using EducationMODEL.organizational;
using EducationMODEL.TeachingManagement;

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
        //添加申请退款
        public abstract int DropClass(DropClassMod dt);
        //退课申请单
        public abstract List<DropClassModShow> DropClassModShow();
        //返还课申请单
        public abstract List<ClassroomManagement> ReturnClass();
        //添加返还课
        public abstract int FAFSAAdd(FAFSAMod dt);
        //查询反填课
        public abstract List<ClassroomManagement> FAFSAShow(string OrganName = "", string BusinessTypeName = "", string ClassModelName = "", string AuditionType = "", string HourTypeName = "", string AuditionState = "", string StudyName = "", string SubjectsName = "", string OrganPhoneName = "", string TeacherName = "", DateTime? AuditionTime1 = null, DateTime? AuditionTime = null, string StudentName = "");
        //删除反填课
        public abstract int FAFSADel(int id);
        //返还表的审核//修改
        public abstract int FAFSAUpt(int tate, string id, string name);
    }
}
