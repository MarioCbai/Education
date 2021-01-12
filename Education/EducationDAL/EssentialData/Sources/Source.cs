using EducationMODEL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.EssentialData.Sources
{
    //来源抽象类
    public abstract class Source
    {
        //来源增删改声明
        //来源表显示
        public abstract List<SourceMod> Show();

        //来源表添加
        public abstract int Add(SourceMod s);

        //来源表编辑
        public abstract int Upt(SourceMod s);

    }
}
