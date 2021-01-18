using EducationMODEL.organizational;
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
        public abstract List<ClassRoomMod> GetClassRooms();
        //添加班级管理信息
        public abstract int AddClassRooms(ClassRoomMod Room);
        //反填班级管理信息
        public abstract ClassRoomMod ModifyIdClassRoomMod(int id);
        //修改班级管理信息
        public abstract int ModifyClassRoomMod(ClassRoomMod Room);
        //删除班级管理信息
        public abstract int DeleteClassRoomMod(int ids);
    }
}
