using EducationMODEL.organizational;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EducationDAL.InstitutionManagement.HourTables
{
    //课时包表实现
    public class HourTableRealize: HourTable
    {
        //课时包显示
        public override List<HourTableMod> HourTableMods()
        {
            return DapperHelper.Query<HourTableMod>("select *from HourTable", "");
        }
        //课时包反填
        public override HourTableMod ModifyIdHourTableMods(int id)
        {
            return DapperHelper.Query<HourTableMod>("select *from HourTable where HourId=@HourId",new { HourId=id}).FirstOrDefault();
        }
        //课时包修改
        public override int ModifyHourTableMods(HourTableMod hour)
        {
            var result = DapperHelper.Execute("update HourTable set HourName=@HourName,HourBeginTime=@HourBeginTime,HourEngTime=@HourEngTime where HourId=@HourId",
            new { hour.HourName, hour.HourBeginTime, hour.HourEngTime, hour.HourId });
            return result;
        }

    }
}
