using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.students
{
    public class PatriarchMod//家长表
    {
        public int PatriarchId { get; set; }//主键id

        public string PatriarchName { get; set; }//家长姓名

        public string PatriarchIphone { get; set; }//家长手机号

        public string PatriarchRelation { get; set; }//与孩子关系父亲、母亲、爷爷、奶奶、外公、外婆、监护人

        public string PatriarchOccupation { get; set; }//职业

        public int PatriarchAge { get; set; }//年龄

        public string PatriarchWeChat { get; set; }//微信

        public string PatriarchRemark { get; set; }//备注

        public int Student { get; set; }//学员表
    }
}
