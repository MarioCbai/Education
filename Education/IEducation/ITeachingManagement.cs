using EducationMODEL.linkModel;
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
    }
}
