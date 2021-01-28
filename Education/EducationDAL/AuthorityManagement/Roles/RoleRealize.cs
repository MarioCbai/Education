using EducationMODEL.AuthorityManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.AuthorityManagement.Roles
{
    //角色方法实现
    public class RoleRealize : Role
    {
        //角色添加
        public override int AddPart(PartMod dt)
        {
            int i = DapperHelper.Execute("insert into Part values (@PartName,@PartDescribe)", dt);
            return i;
        }

        //角色删除
        public override int DelPart(int id)
        {
            DapperHelper.Execute("delete ConsumerPart where Part==@id", new { id });
            DapperHelper.Execute("delete PartMenu where PartMenuPartId==@id", new { id });
            return DapperHelper.Execute("delete Part where PartId=@id", new { id });
        }

        //角色条件查询
        public override List<PartMod> GetParts(string PartName, string PMState)
        {
            string sql= "select * from Part where  1=1";
            if (PartName!=null && PartName!="")
            {
                sql += " and PartName=@PartName";
            }
            if (PMState!=null && PartName!="")
            {
                sql += " and PMState=@PMState";
            }
            return DapperHelper.Query<PartMod>(sql, new { PartName, PMState });
        }

        //角色查看
        public override PartMod PartSel(int id)
        {
            return DapperHelper.QueryFirst<PartMod>("select * from Part where PartId=@id", new { id });
        }

        //全部角色
        public override List<PartMod> PartShow()
        {
           return  DapperHelper.Query<PartMod>("select * from Part",new { });
        }

        
        public override void PartState(int id, int val)
        {
            DapperHelper.Execute("update Part set PMState=@Value where PartId=@Id", new { Value = val, Id = id });
        }

        //角色状态修改
        public override void RoleState(int id, int val)
        {
            DapperHelper.Execute("update Part set PMState=@Value where PartId=@Id", new { Value = val, Id = id });
        }

        //角色修改
        public override int UptPart(PartMod p)
        {
            return DapperHelper.Execute("update Part set PartName=@PartName,PartDescribe=@PartDescribe,PMState=@PMState where PartId=@PartId", p);
        }
    }
}
