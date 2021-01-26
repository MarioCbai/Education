using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.linkModel
{
   public  class QuickNavigation   //快速导航表
    {
        public int Quickid { get; set; }
        public int id { get { return Quickid; } }
        public string title { get; set; }
        public string href { get; set; }
        public string QuickIName { get; set; }

        public string value { get { return title; } }

    }
}
