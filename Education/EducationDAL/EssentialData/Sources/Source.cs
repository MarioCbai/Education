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
        public abstract List<SourceMod> SourceShow();

        //来源表添加
        public abstract int SourceAdd(SourceMod s);

        //来源表编辑
        public abstract int SourceUpt(SourceMod s);

        //来源表状态修改
        public abstract int SourceZtai(int ztai,int id);

        //来源表根据id查询反填
        public abstract SourceMod SourceSelectById(int id);

        public abstract List<SourceMod> SourceShowName(string name);
    }
}
