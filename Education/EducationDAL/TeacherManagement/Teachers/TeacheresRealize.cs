using EducationMODEL.TeacherManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.TeacherManagement.Teachers
{
    //教师方法实现
    public class TeacheresRealize:Teacheres
    {
        //教师管理显示
        public override List<TeachMod> GetTeaches()
        {
            return DapperHelper.Query<TeachMod>("select *from Teach tea join Teacher ter on tea.Teacher=ter.TeacherId", "");
        }
    }
}
