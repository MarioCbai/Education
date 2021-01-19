using EducationMODEL.AuthorityManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.AuthorityManagement.Roles
{
    //角色方法声明
    public abstract class Role
    {
        //角色修改
        public abstract int UptPart(PartMod p);

        //角色状态修改
        public abstract void PartState(int id, int val);

        //角色条件查询
        public abstract List<PartMod> GetParts(string PartName,string PMState);
        //角色查看
        public abstract PartMod PartSel(int id);

        //角色查询
        public abstract List<PartMod> PartShow();
        //角色添加
        public abstract int AddPart(PartMod dt);

        //角色状态
        public abstract void RoleState(int id,int val);

        //角色删除
        public abstract int DelPart(int id);

    }
}
