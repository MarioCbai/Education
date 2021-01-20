using EducationMODEL.OrderManagement;
using EducationMODEL.organizational;
using EducationMODEL.students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EducationDAL.InstitutionManagement.ClassManagements
{
    //班级管理的实现
    public class ClassManagementRealize:ClassManagement
    {
        //班级管理显示
        public override List<ClassRoomMod> GetClassRooms()
        {

            return DapperHelper.Query<ClassRoomMod>("select *from ClassRoom cls " +
                 "join Study st on cls.StID = st.StID " +
                 "join Subjects sub on cls.SubjectsId = sub.SubjectsId " +
                 "join Textbook tex on cls.TextbookId = tex.TextbookId " +
                 "join Semester sem on cls.SemesterId = sem.SemesterId " +
                 "join Teacher tea on cls.TeacherId = tea.TeacherId " +
                 "join HourTable hou on cls.HourId = hou.HourId " +
                 "join Organ org on cls.OrganId = org.OrganId", "");
        }
        //添加班级管理信息
        public override int AddClassRooms(ClassRoomMod Room)
        {
            var result = DapperHelper.Execute("insert into ClassRoom values(@ClassRoomName,@StID,@SubjectsId,@TextbookId,@SemesterId,@TeacherId,@HourId,@OrganId)",
            new { Room.ClassRoomName, Room.StID, Room.SubjectsId, Room.TextbookId, Room.SemesterId, Room.TeacherId, Room.HourId, Room.OrganId });
            return result;
        }
        //反填班级管理信息
        public override ClassRoomMod ModifyIdClassRoomMod(int id)
        {
            return DapperHelper.Query<ClassRoomMod>("select *from ClassRoom where ClassRoomId=@ClassRoomId", new { ClassRoomId = id }).FirstOrDefault();
        }
        //修改班级管理信息
        public override int ModifyClassRoomMod(ClassRoomMod Room)
        {
            var result = DapperHelper.Execute("update ClassRoom set ClassRoomName=@ClassRoomName,StID=@StID,SubjectsId=@SubjectsId,TextbookId=@TextbookId,SemesterId=@SemesterId,TeacherId=@TeacherId,HourId=@HourId,OrganId=@OrganId where ClassRoomId=@ClassRoomId",
            new { Room.ClassRoomName, Room.StID, Room.SubjectsId, Room.TextbookId, Room.SemesterId, Room.TeacherId, Room.HourId, Room.OrganId, Room.ClassRoomId });
            return result;
        }
        //删除班级管理信息
        public override int DeleteClassRoomMod(int ids)
        {
            return DapperHelper.Execute("delete from ClassRoom where ClassRoomId=@ClassRoomId", new { ClassRoomId = ids });
        }
        //绑定年级下拉
        public override List<Study> GetRoomStudys()
        {
            return DapperHelper.Query<Study>("select *from Study where StudyId!=0", "");
        }
        //绑定版本下拉
        public override List<TextbookMod> GetTextbookMod()
        {
            return DapperHelper.Query<TextbookMod>("select *from Textbook", "");
        }

    }
}
