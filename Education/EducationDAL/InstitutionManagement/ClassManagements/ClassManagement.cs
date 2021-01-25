using EducationMODEL.OrderManagement;
using EducationMODEL.organizational;
using EducationMODEL.students;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.InstitutionManagement.ClassManagements
{
    //班级管理
    public abstract class ClassManagement
    {
        //班级管理增删改查
        //班级管理显示
        public abstract List<ClassRoomMod> GetClassRooms(string roomname,int sub,int jigou, int stid, DateTime? HourBeginTime, DateTime? HourEngTime);
        //添加班级管理信息
        public abstract int AddClassRooms(ClassRoomMod Room);
        //反填班级管理信息
        public abstract ClassRoomMod ModifyIdClassRoomMod(int id);
        //修改班级管理信息
        public abstract int ModifyClassRoomMod(ClassRoomMod Room);
        //删除班级管理信息
        public abstract int DeleteClassRoomMod(int ids);
        //绑定年级下拉
        public abstract List<Study> GetRoomStudys();
        //绑定版本下拉
        public abstract List<TextbookMod> GetTextbookMod();
    }
}
