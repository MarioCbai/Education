using EducationMODEL.organizational;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.InstitutionManagement.HourTables
{
    //课时包表增删改查
    public abstract class HourTable
    {
        //课时包显示
        public abstract List<HourTableMod> HourTableMods();
        //课时包反填
        public abstract HourTableMod ModifyIdHourTableMods(int id);
        //课时包修改
        public abstract int ModifyHourTableMods(HourTableMod hour);
    }
}
