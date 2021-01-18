using EducationMODEL.AuthorityManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.AuthorityManagement.Roles
{
    //角色方法声明
    public abstract class Role
    {
        //角色查询
        public abstract List<PartMod> PartShow();
        //角色添加
        public abstract int AddPart(PartMod dt);

        //角色状态
        public abstract void RoleState(int id,int val);
    }
}
