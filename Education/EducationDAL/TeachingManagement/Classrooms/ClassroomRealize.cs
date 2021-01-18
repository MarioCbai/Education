using EducationMODEL.linkModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.TeachingManagement.Classrooms
{
    //课堂管理方法实现
    public class ClassroomRealize : Classroom
    {
        //课堂管理显示
        public override List<ClassroomManagement> ManagementShow()
        {
            return DapperHelper.Query<ClassroomManagement>("select *from AuditionStudent join Audition on AuditionStudent.Audition=Audition.AuditionID  join Student on AuditionStudent.Student = Student.StudentId join Organ on Student.Institution = Organ.OrganId  join Study on Student.StID = Study.StID  join  Subjects on Audition.SubjectsId = Subjects.SubjectsId join Teacher on Audition.TeacherId = Teacher.TeacherId join HourType on  Audition.HourTypeId = HourType.HourTypeId  join BusinessType on Audition.BusinessTypeId = BusinessType.BusinessTypeId  join ClassModel on Audition.ClassModelId = ClassModel.ClassModelId", new { });
        }
    }
}
