using EducationMODEL.Infrastructure;
using EducationMODEL.linkModel;
using EducationMODEL.OrderManagement;
using EducationMODEL.organizational;
using EducationMODEL.students;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.StudentManagement.Studentes
{
    //学生方法实现
    public class StudentsRealize : Students
    {

        //地区
        public override List<SitesMod> Dizhi(int id)
        {
            return DapperHelper.Query<SitesMod>("select * from Sites where SitesId=@id", new { id });
        }

        //来源查询
        public override List<SourceMod> LaiShow()
        {
           return DapperHelper.Query<SourceMod>("select * from Source", new { });
        }

        //学员查询
        public override StudentMod ShowSan(int id)
        {
            return DapperHelper.QueryFirst<StudentMod>("select StudentName,StudentIphone,SourceId from Student where StudentId=@id", new {id });
        }

        //学员添加
        public override int StudentAdd(StudentMod s)
        {
            return DapperHelper.Execute("insert into Student values (@StudentName,@StudentIDNo,@StudentBirthday,@StID,@StudentWeChat,@StudentQQ,@StudentIphone,@StudentPwd,@StudentSex,@StudentSchool,@Province,@City,@County,@StudentSite,@StudentQuality,@Institution,@StudentKind,@Counselor,@SourceId)", s);
        }

        //查询学生
        public override List<StudentLian> StudentShow(int jigou, string zi, string zhi, int nian, string name, string iphone)
        {
            string sql = "select * from Student a join Organ b on a.Institution=b.OrganId join Study c on c.StID=a.StID where 1=1 and a.StudentKind=0";
            if (jigou!=0)
            {
                sql += " and a.Institution=@jigou";
            }
            if (zi!=null&&zi!="")
            {
                sql += " and a.Counselor like concat('%',@zi,'%')";
            }
            if (zhi!=null && zhi!="")
            {
                sql += " and a.StudentQuality=@zhi";
            }
            if (nian!=0)
            {
                sql += " and a.StID=@nian";
            }
            if (name!=null&&name!="")
            {
                sql += " and a.StudentName like concat('',@name,'')";
            }
            if (iphone!=null&& iphone!="")
            {
                sql += " and a.StudentIphone=@iphone";
            }
            return DapperHelper.Query<StudentLian>(sql, new { jigou, zi, zhi, nian ,name, iphone });

        }

        //学
        public override List<Study> Xue(int id)
        {
            return DapperHelper.Query<Study>("select * from  Study where StudyId=@id", new { id });
        }

        //添加试听课表
        public override int ScheduleAdd(AuditionMod aa)
        {
            int i = DapperHelper.QueryFirst<StudentMod>("select StudentKind from Student where StudentId=@StudentId", new { aa.StudentId }).StudentKind;
            if (i==1)
            {
                aa.AuditionType = "正式课";
            }
            else
            {
                aa.AuditionType = "试听课";
            }
            int b = 0;
            int a=DapperHelper.Execute("insert into Audition values(@AuditionType,@StID,@Grade,@AuditionClass,@AuditionDate,@AuditionTime,@AuditionState,@AuditionRemark,@TeacherId,@SubjectsId,@HourTypeId,@BusinessTypeId,@ClassModelId)", aa);
             int c =DapperHelper.QueryFirst<AuditionMod>("select max(AuditionID)as AuditionID from Audition", new { }).AuditionID;
            if (i == 1)
            {
                b = DapperHelper.Execute("insert into AuditionStudent values(@Audition,@SId,null,1)", new { Audition = c, SId = aa.StudentId });
            }
            else
            {
                b = DapperHelper.Execute("insert into AuditionStudent values(@Audition,@SId,null,3)", new { Audition = c, SId = aa.StudentId });
            }
            
            if (a>0&&b>0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            
        }

        //正式学员
        public override List<StudentLian> ShowOfficial(int jigou, string zi, string zhi, int nian, string name, string iphone)
        {
            string sql = "select * from Student a join Organ b on a.Institution=b.OrganId join Study c on c.StID=a.StID where 1=1 and a.StudentKind=1";
            if (jigou != 0)
            {
                sql += " and a.Institution=@jigou";
            }
            if (zi != null && zi != "")
            {
                sql += " and a.Counselor like concat('%',@zi,'%')";
            }
            if (zhi != null && zhi != "")
            {
                sql += " and a.StudentQuality=@zhi";
            }
            if (nian != 0)
            {
                sql += " and a.StID=@nian";
            }
            if (name != null && name != "")
            {
                sql += " and a.StudentName like concat('',@name,'')";
            }
            if (iphone != null && iphone != "")
            {
                sql += " and a.StudentIphone=@iphone";
            }
            return DapperHelper.Query<StudentLian>(sql, new { jigou, zi, zhi, nian, name, iphone });
        }

        //学员显示
        public override List<StudentLian> StudentShow(int zhuang, int jigou, string zi, string zhi, int nian, string name, string iphone)
        {
            string sql = "select * from Student a join Organ b on a.Institution=b.OrganId join Study c on c.StID=a.StID where 1=1";
            if (zhuang!=-1)
            {
                sql += " and a.StudentKind=@zhuang";
            }
            if (jigou != 0)
            {
                sql += " and a.Institution=@jigou";
            }
            if (zi != null && zi != "")
            {
                sql += " and a.Counselor like concat('%',@zi,'%')";
            }
            if (zhi != null && zhi != "")
            {
                sql += " and a.StudentQuality=@zhi";
            }
            if (nian != 0)
            {
                sql += " and a.StID=@nian";
            }
            if (name != null && name != "")
            {
                sql += " and a.StudentName like concat('',@name,'')";
            }
            if (iphone != null && iphone != "")
            {
                sql += " and a.StudentIphone=@iphone";
            }
            return DapperHelper.Query<StudentLian>(sql, new { zhuang,jigou, zi, zhi, nian, name, iphone });
        }

        //学员详细信息
        public override StudentLian SelStudent(int id)
        {
            return DapperHelper.QueryFirst<StudentLian>("select * from Student a join Organ b on a.Institution=b.OrganId join Study c on c.StID=a.StID where a.StudentId=@id", new { id });
        }
    }
}
