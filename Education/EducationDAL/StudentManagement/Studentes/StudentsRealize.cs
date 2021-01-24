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
            return DapperHelper.Execute("insert into Student values (@StudentName,@StudentIDNo,@StudentBirthday,@StID,@StudentWeChat,@StudentQQ,@StudentIphone,@StudentPwd,@StudentSex,@StudentSchool,@Province,@City,@County,@StudentSite,@Counselor,@StudentQuality,@Institution,@StudentKind,@SourceId)", s);
        }

        //查询学生
        public override List<StudentLian> StudentShow(int jigou, string zi, string zhi, int nian, string name, string iphone)
        {
            string sql = "select * from Student a join Organ b on a.Institution=b.OrganId join Study c on c.StID=a.StID where 1=1";
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
    }
}
