﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL
{
   public class ConsumerPartMod//角色用户关系表
    {
        public int CPId	 { get; set; }//主键id

        public int Consumer { get; set; }//用户表（外键）

        public int Part { get; set; }//角色表（外键）
        public int CPState { get; set; }//状态
        public DateTime Createtime { get; set; }//创建时间
        public string Handlers { get; set; }//操作人
    }
}
