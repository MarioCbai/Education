using EducationMODEL.TeacherManagement;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EducationDAL.TeacherManagement.TeachingInformations
{
    //方法实现
    public class TeachingInformationRealize:TeachingInformation
    {
        //教学基本信息显示
        public override List<TeachMod> GetTeachMods()
        {
            return DapperHelper.Query<TeachMod>("select *from Teach", "");
        }
        //教学基本信息新增
        public override int AddTeachMod(TeachMod tea)
        {
            var result = DapperHelper.Execute("insert into teach values(@TeacherType,@TeacherRank,@TeacherShowKe,@TeacherLink,@RecursionId,@TeacherYType,@TeacherAge,@TeacherStyle,@SubjectsId,@TextbookId,@TeacherTime,@Teacher)", tea);
            return result;
        }
        //教学基本信息反填
        public override TeachMod ModifyIdTeachMod(int id)
        {
            return DapperHelper.Query<TeachMod>("select *from Teach where TeachId=@TeachId", new { TeachId =id}).FirstOrDefault();
        }
        //教学基本信息修改
        public override int ModifyTeachMod(TeachMod tea)
        {
            var result = DapperHelper.Execute("update Teach set TeacherType=@TeacherType,TeacherRank=@TeacherRank,TeacherShowKe=@TeacherShowKe,TeacherLink=@TeacherLink,RecursionId=@RecursionId,TeacherYType=@TeacherYType,TeacherAge=@TeacherAge,TeacherStyle=@TeacherStyle,SubjectsId=@SubjectsId,TextbookId=@TextbookId,Teacher=@Teacher where TeachId=@TeachId",
            new { tea.TeacherType, tea.TeacherRank, tea.TeacherShowKe, tea.TeacherLink, tea.RecursionId, tea.TeacherYType, tea.TeacherAge, tea.TeacherStyle, tea.SubjectsId, tea.TextbookId, tea.Teacher,tea.TeachId });
            return result;
        }
        //教学基本信息删除
        public override int DeleteTeachMod(int ids)
        {
            return DapperHelper.Execute("delete from Teach where TeachId=@TeachId", new { TeachId=ids });
        }
    }
}
