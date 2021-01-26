using EducationMODEL.linkModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.StudentManagement.Schedulings
{
    public class SchedulingRealize : Scheduling
    {

        //试听课显示
        public override List<StudentLian> TrialClass()
        {
            return DapperHelper.Query<StudentLian>("select a.*,b.AuditionClass,b.AuditionDate,b.AuditionState,d.TeacherName,b.AuditionType,e.StudyName,f.ClassModelName from AuditionStudent a join Audition b on a.Audition = b.AuditionID join Student c on a.Student = c.StudentId join Teacher d on d.TeacherId = b.TeacherId join Study e on e.StID = b.Grade join ClassModel f on f.ClassModelId=b.ClassModelId where b.AuditionType='试听课'",new { });
        }

        //正式课
        public override List<StudentLian> TrialClasss()
        {
            return DapperHelper.Query<StudentLian>("select a.*,b.AuditionClass,b.AuditionDate,b.AuditionState,d.TeacherName,b.AuditionType,e.StudyName,f.ClassModelName from AuditionStudent a join Audition b on a.Audition = b.AuditionID join Student c on a.Student = c.StudentId join Teacher d on d.TeacherId = b.TeacherId join Study e on e.StID = b.Grade join ClassModel f on f.ClassModelId=b.ClassModelId where b.AuditionType='正式课'", new { });
        }

        //修改状态
        public override int xiugai(int i,int id)
        {
            return DapperHelper.Execute("update AuditionStudent set AuditTime=GETDATE(), State=@i where ASID=@id", new { i, id });
             
        }
    }
}
