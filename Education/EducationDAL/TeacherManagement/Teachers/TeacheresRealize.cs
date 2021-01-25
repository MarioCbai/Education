using EducationMODEL.TeacherManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EducationDAL.TeacherManagement.Teachers
{
    //教师方法实现
    public class TeacheresRealize : Teacheres
    {
        //教师管理显示
        public override List<TeachMod> GetTeaches()
        {
            return DapperHelper.Query<TeachMod>("select *from Teach tea join Teacher ter on tea.Teacher = ter.TeacherId join Organ org on ter.OrganId = org.OrganId", "");
        }
        //教师管理显示1
        public override List<TeacherMod> GetTeacherMods()
        {
            return DapperHelper.Query<TeacherMod>("select * from Teacher ter join  Teachereducation  duc on ter.TeachereducationId=duc.TeachereducationId join  Organ  org on org.OrganId = ter.OrganId", "");
        }
        //添加教师管理信息
        public override int AddTeacherMod(TeacherMod t)
        {            
           var result = DapperHelper.Execute("insert into Teacher values(@OrganId,@TeacherName,@TeacherOuter,@TeacherSex,@TeachereducationId,@TeacherQQ,@TeacherWeChat,@ProvinceId, @City, @District, @TeacherTitle, @TeacherPhone, @TeacherIDnumber, @TeacherGraduate, @TeacherResume, @TeacherCom,@TeacherPwd,@TeacherState, @TeacherCard)", 
           new {t.OrganId,t.TeacherName,t.TeacherOuter, t.TeacherSex, t.TeachereducationId,t.TeacherQQ,t.TeacherWeChat,t.ProvinceId,t.City,t.District,t.TeacherTitle,t.TeacherPhone,t.TeacherIDnumber,t.TeacherGraduate, t.TeacherResume, t.TeacherCom, t.TeacherCard,t.TeacherPwd,t.TeacherState });
           return result;
        }
        //删除教师管理信息
        public override int DeleteTeacherMod(int ids)
        {
            return DapperHelper.Execute("delete from Teacher where TeacherId=@TeacherId", new { TeacherId = ids });
        }
        //反填教师管理信息
        public override TeacherMod ModifyIdTeacherMod(int teacherid)
        {
            return DapperHelper.Query<TeacherMod>("select *from Teacher where TeacherId=@TeacherId", new { TeacherId = teacherid }).FirstOrDefault();
        }
        //修改教师管理信息
        public override int ModifyTeacherMod(TeacherMod t)
        {
            var result = DapperHelper.Execute("update Teacher set OrganId=@OrganId,TeacherName=@TeacherName,TeacherOuter=@TeacherOuter,TeacherSex=@TeacherSex,TeachereducationId=@TeachereducationId,TeacherQQ=@TeacherQQ,TeacherWeChat=@TeacherWeChat," +
                "ProvinceId=@ProvinceId,City=@City,District=@District,TeacherTitle=@TeacherTitle,TeacherPhone=@TeacherPhone,TeacherIDnumber=@TeacherIDnumber,TeacherGraduate=@TeacherGraduate,TeacherResume=@TeacherResume,TeacherCom=@TeacherCom,TeacherCard=@TeacherCard,TeacherPwd=@TeacherPwd,TeacherState=@TeacherState where TeacherId=@TeacherId",
            new { t.OrganId, t.TeacherName, t.TeacherOuter, t.TeacherSex, t.TeachereducationId, t.TeacherQQ, t.TeacherWeChat, t.ProvinceId, t.City, t.District, t.TeacherTitle, t.TeacherPhone, t.TeacherIDnumber, t.TeacherGraduate, t.TeacherResume, t.TeacherCom, t.TeacherCard,t.TeacherId,t.TeacherPwd,t.TeacherState });
            return result;
        }
        //修改教师管理状态
        public override int ModifyTeacherState(int status, int teaid)
        {
            return DapperHelper.Execute("update Teacher set TeacherState=@TeacherState  where TeacherId=@TeacherId", new { TeacherState = status, TeacherId = teaid });
        }

        /// <summary>
        /// 教师显示
        /// </summary>
        /// <returns></returns>
        public override List<TeacherMod> TeacherShow()
        {
            return DapperHelper.Query<TeacherMod>("select * from Teacher a join Teach b on a.TeacherId=b.Teacher join TeacherType c on b.TeacherType=c.TeacherTypeId join Teachinglevel d on d.LevelId=b.TeacherRank", new { });
        }
    }
}
