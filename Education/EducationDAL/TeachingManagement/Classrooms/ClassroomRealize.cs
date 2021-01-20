using EducationMODEL.linkModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.TeachingManagement.Classrooms
{
    //课堂管理方法实现
    public class ClassroomRealize : Classroom
    {
        //业务类型
        public override List<Managethedrop_down> BusinessType()
        {
            return DapperHelper.Query<Managethedrop_down>("select *from BusinessType", new { });
        }
        //版型表
        public override List<Managethedrop_down> ClassModel()
        {
            return DapperHelper.Query<Managethedrop_down>(" select ClassModelId,ClassModelName  from ClassModel", new { });
        }
        //课时类型
        public override List<Managethedrop_down> HourType()
        {
            return DapperHelper.Query<Managethedrop_down>(" select HourTypeId,HourTypeName  from HourType", new { });
        }

        //课堂管理显示
        public override List<ClassroomManagement> ManagementShow(string OrganName = "", string BusinessTypeName = "", string ClassModelName = "", string AuditionType = "", string HourTypeName = "", string AuditionState = "", string StudyName = "", string SubjectsName = "", string OrganPhoneName = "", string TeacherName = "", DateTime? AuditionTime1 = null, DateTime? AuditionTime = null,string StudentName="")
        {
            string sql=" where 1=1 ";
            if (OrganName!=""&& OrganName!="-1"&&OrganName!=null)
            {
                sql += "and Organ.OrganId=@OrganName ";
            }
            if (BusinessTypeName != "" && BusinessTypeName != "-1" && BusinessTypeName != null)
            {
                sql += "and BusinessTypeName=@BusinessTypeName ";
            }
            if (ClassModelName != "" && ClassModelName != "-1" && ClassModelName != null)
            {
                sql += "and ClassModel.ClassModelId=@ClassModelName ";
            }
            if (AuditionType != "" && AuditionType != "-1" && AuditionType != null)
            {
                sql += "and Audition.AuditionType=@AuditionType";
            }
            if (HourTypeName != "" && HourTypeName != "-1" && HourTypeName != null)
            {
                sql += "and HourType.HourTypeId =@HourTypeName ";
            }
            if (AuditionState != "" && AuditionState != "-1" && AuditionState != null)
            {
                sql += "and Audition.AuditionState=@AuditionState ";
            }
            if (StudyName != "" && StudyName != "-1" && StudyName != null)
            {
                sql += "and Study.StID=@StudyName ";
            }
            if (SubjectsName != "" && SubjectsName != "-1" && SubjectsName != null)
            {
                sql += "and Subjects.SubjectsId=@SubjectsName";
            }
            if (OrganPhoneName != "" && OrganPhoneName != "-1" && OrganPhoneName != null)
            {
                sql += "and Organ.OrganPhoneName  like concat('%',@OrganPhoneName,'%')";
            }
            if (TeacherName != "" && TeacherName != "-1" && TeacherName != null)
            {
                sql += "and Teacher.TeacherName like concat('%',@TeacherName,'%') ";
            }
            if (AuditionTime1 != null && AuditionTime!=null)
            {
                sql += "and Audition.AuditionDate  between  @AuditionTime1  and @AuditionTime ";
            }
            if (StudentName != "" && StudentName != "-1" && StudentName != null)
            {
                sql += " and Student.StudentName like  concat('%',@StudentName,'%') ";
            }
            return DapperHelper.Query<ClassroomManagement>("select *from AuditionStudent join Audition on AuditionStudent.Audition=Audition.AuditionID  join Student on AuditionStudent.Student = Student.StudentId join Organ on Student.Institution = Organ.OrganId  join Study on Student.StID = Study.StID  join  Subjects on Audition.SubjectsId = Subjects.SubjectsId join Teacher on Audition.TeacherId = Teacher.TeacherId join HourType on  Audition.HourTypeId = HourType.HourTypeId  join BusinessType on Audition.BusinessTypeId = BusinessType.BusinessTypeId  join ClassModel on Audition.ClassModelId = ClassModel.ClassModelId "+ sql, new { OrganName= OrganName, BusinessTypeName= BusinessTypeName, ClassModelName= ClassModelName, AuditionType= AuditionType , HourTypeName = HourTypeName, AuditionState= AuditionState, StudyName= StudyName, SubjectsName= SubjectsName, OrganPhoneName= OrganPhoneName, TeacherName= TeacherName, AuditionTime1= AuditionTime1, AuditionTime= AuditionTime, StudentName= StudentName });
        }
        //课堂管理查询
        public override  List<ClassroomManagement> Examine(string StudentId)
        {
            string sql = " where 1=1 ";
            if (StudentId != "" && StudentId != "-1" && StudentId != null)
            {
                sql += " and Student.StudentId =@StudentId ";
            }
            return DapperHelper.Query<ClassroomManagement>("select *from AuditionStudent join Audition on AuditionStudent.Audition=Audition.AuditionID  join Student on AuditionStudent.Student = Student.StudentId join Organ on Student.Institution = Organ.OrganId  join Study on Student.StID = Study.StID  join  Subjects on Audition.SubjectsId = Subjects.SubjectsId join Teacher on Audition.TeacherId = Teacher.TeacherId join HourType on  Audition.HourTypeId = HourType.HourTypeId  join BusinessType on Audition.BusinessTypeId = BusinessType.BusinessTypeId  join ClassModel on Audition.ClassModelId = ClassModel.ClassModelId " + sql, new { StudentId= StudentId });

        }
        //机构表
        public override List<Managethedrop_down> Organ()
        {
            return DapperHelper.Query<Managethedrop_down>("select OrganId,OrganName from  Organ",new { });
        }
        //年级
        public override List<Managethedrop_down> Study()
        {
            return DapperHelper.Query<Managethedrop_down>("select StID,StudyName from  Study", new { });
        }
        //学科
        public override List<Managethedrop_down> Subjects()
        {
            return DapperHelper.Query<Managethedrop_down>("select *from Subjects", new { });
        }

       
    }
}
