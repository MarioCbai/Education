using EducationDAL.TeachingManagement;
using EducationMODEL.linkModel;
using EducationMODEL.TeachingManagement;
using IEducation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationBLL
{
    //教学管理
    public class TeachingManagementBll:ITeachingManagement
    {
        Teaching teachings = new TeachingPlant();
        //课堂管理显示
        public List<ClassroomManagement> ManagementShow(string OrganName = "", string BusinessTypeName = "", string ClassModelName = "", string AuditionType = "", string HourTypeName = "", string AuditionState = "", string StudyName = "", string SubjectsName = "", string OrganPhoneName = "", string TeacherName = "", DateTime? AuditionTime1 = null, DateTime? AuditionTime = null, string StudentName = "")
        {
            return teachings.Classroom().ManagementShow(OrganName, BusinessTypeName, ClassModelName, AuditionType, HourTypeName, AuditionState, StudyName, SubjectsName, OrganPhoneName, TeacherName, AuditionTime1, AuditionTime, StudentName);
        }
        //课堂管理查询
        public List<ClassroomManagement> Examine(string StudentId)
        {
            return teachings.Classroom().Examine(StudentId);
        }
        //下拉机构下拉
        public  List<Managethedrop_down> Organ()        {
    
            List<Managethedrop_down> list = teachings.Classroom().Organ();   
            return list;

        }
        //业务类型下拉
        public List<Managethedrop_down> BusinessType()
        {       
            List<Managethedrop_down> list = teachings.Classroom().BusinessType();    
            return list;
        }
        //班型下拉
        public List<Managethedrop_down> ClassModel()
        {       
            List<Managethedrop_down> list = teachings.Classroom().ClassModel();      
            return list;
        }
        //课时类型下拉
        public List<Managethedrop_down> HourType()
        { 
            List<Managethedrop_down> list = teachings.Classroom().HourType();        
            return list;
        }
        //年级下拉
        public List<Managethedrop_down> Study()
        {          
            List<Managethedrop_down> list = teachings.Classroom().Study();         
            return list;
        }
        //学科下拉
        public List<Managethedrop_down> Subjects()
        {         
            List<Managethedrop_down> list = teachings.Classroom().Subjects();
            return list;
        }
        //添加申请退款
        public  int DropClass(DropClassMod dt)
        {
            int i = teachings.Classroom().DropClass(dt);
            return i;
        }
        //退课申请单
        public  List<DropClassModShow> DropClassModShow()
        {
            List<DropClassModShow> list = teachings.Classroom().DropClassModShow();
            return list;
        }
        //返还课申请单
        public  List<ClassroomManagement> ReturnClass()
        {
            List<ClassroomManagement> lsit = teachings.Classroom().ReturnClass();
            return lsit;
        }
        //添加返还课
        public  int FAFSAAdd(FAFSAMod dt)
        {
            int i = teachings.Classroom().FAFSAAdd(dt);
            return i;
        }
        //查询反还课
        public  List<ClassroomManagement> FAFSAShow(string OrganName = "", string BusinessTypeName = "", string ClassModelName = "", string AuditionType = "", string HourTypeName = "", string AuditionState = "", string StudyName = "", string SubjectsName = "", string OrganPhoneName = "", string TeacherName = "", DateTime? AuditionTime1 = null, DateTime? AuditionTime = null, string StudentName = "")
        {
            return teachings.Classroom().FAFSAShow(OrganName, BusinessTypeName, ClassModelName, AuditionType, HourTypeName, AuditionState, StudyName, SubjectsName, OrganPhoneName, TeacherName, AuditionTime1, AuditionTime, StudentName);
        }
        //删除反填课
        public  int FAFSADel(int id)
        {
            return teachings.Classroom().FAFSADel(id);
        }
        //返还表的审核//修改
        public  int FAFSAUpt(int tate, string id)
        {
            return teachings.Classroom().FAFSAUpt(tate,id);
        }
    }
}
