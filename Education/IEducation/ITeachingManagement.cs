using EducationMODEL.linkModel;
using EducationMODEL.TeachingManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace IEducation
{
    //教学管理
    public interface ITeachingManagement
    {
        //课堂管理显示
         List<ClassroomManagement> ManagementShow(string OrganName = "", string BusinessTypeName = "", string ClassModelName = "", string AuditionType = "", string HourTypeName = "", string AuditionState = "", string StudyName = "", string SubjectsName = "", string OrganPhoneName = "", string TeacherName = "", DateTime? AuditionTime1 = null, DateTime? AuditionTime = null, string StudentName = "");
        //查看
         List<ClassroomManagement> Examine(string StudentId);
        //下拉机构下拉
        List<Managethedrop_down> Organ();

        //业务类型下拉
        List<Managethedrop_down> BusinessType();

        //班型下拉
        List<Managethedrop_down> ClassModel();

        //课时类型下拉
        List<Managethedrop_down> HourType();

        //年级下拉
        List<Managethedrop_down> Study();

        //学科下拉
        List<Managethedrop_down> Subjects();
        //添加申请退款
        int DropClass(DropClassMod dt);
        //退课申请单
        List<DropClassModShow> DropClassModShow();
        //返还课申请单
        List<ClassroomManagement> ReturnClass();
        //添加返还课
        int FAFSAAdd(FAFSAMod dt);
        //查询反填课
        List<ClassroomManagement> FAFSAShow(string OrganName = "", string BusinessTypeName = "", string ClassModelName = "", string AuditionType = "", string HourTypeName = "", string AuditionState = "", string StudyName = "", string SubjectsName = "", string OrganPhoneName = "", string TeacherName = "", DateTime? AuditionTime1 = null, DateTime? AuditionTime = null, string StudentName = "");
        //删除反填课
        int FAFSADel(int id);
        //返还表的审核//修改
        int FAFSAUpt(int tate, string id);

    }
}
