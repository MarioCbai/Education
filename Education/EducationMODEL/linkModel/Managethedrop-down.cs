using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.linkModel
{
   public class Managethedrop_down
    {

        //机构表   Organ
        public int OrganId { get; set; }         //id
        public string OrganName { get; set; }     //机构名称
        //业务类型  BusinessType
        public int BusinessTypeId { get; set; }    
        public string BusinessTypeName { get; set; }   //业务类型名称
        //班型   ClassModel
        public int ClassModelId { get; set; }
        public string ClassModelName { get; set; }    //班型名称
        //课程类别  写死
        //课时类型  HourType
        public int HourTypeId { get; set; }
        public string HourTypeName { get; set; }  //课时类型名称
        //课堂状态   写死
        //年级  Study
        public int StID { get; set; }
        public string StudyName { get; set; }     //年级名称
        public int StudyId { get; set; }
        //学科//科目  Subjects
        public int SubjectsId { get; set; }
        public string SubjectsName { get; set; }   //科目名称    

        



    }
}
