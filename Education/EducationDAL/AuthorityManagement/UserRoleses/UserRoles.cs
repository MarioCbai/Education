using EducationMODEL;
using EducationMODEL.linkModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.AuthorityManagement.UserRoleses
{
    //角色用户方法声明
    public abstract class UserRoles
    {
        //用户角色显示分页
        public abstract List<UserPardMod> UserPartShow(int PageIndex, int PageSize, string name, string Iphone, string PartName, string State, DateTime? StartTime, DateTime? EndTime);
        //用户角色状态
        public abstract void State(int id,int val);
        //用户角色总条数
        public abstract int UserPartShows(string name, string Iphone, string PartName, string State, DateTime? StartTime, DateTime? EndTime);
    }
}
