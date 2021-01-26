using EducationMODEL.linkModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.StudentManagement.Schedulings
{
    //排课增删改方法声明
    public abstract class Scheduling
    {
        //试听课
        public abstract List<StudentLian> TrialClass();
        //正式课
        public abstract List<StudentLian> TrialClasss();
        //修改状态
        public abstract int xiugai(int i,int id);
        //删除正式课
        public abstract int shanchu(int id);
    }
}
