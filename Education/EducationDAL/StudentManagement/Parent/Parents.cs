using EducationMODEL.students;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.StudentManagement.Parent
{
    //家长增删改查声明
    public abstract class Parents
    {
        //家长信息显示
        public abstract List<PatriarchMod> ParentsShow(int id);


        //删除家长信息
        public abstract int DelParents(int id);

        //家长信息反填

        public abstract PatriarchMod FanParent(int id);
        //家长信息修改
        public abstract int UptParent(PatriarchMod p);

        //家长添加
        public abstract int AddParent(PatriarchMod p);

    }
}
