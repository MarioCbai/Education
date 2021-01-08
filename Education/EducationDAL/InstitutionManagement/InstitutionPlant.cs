using System;
using System.Collections.Generic;
using System.Text;
using EducationDAL.InstitutionManagement.ClassManagements;
using EducationDAL.InstitutionManagement.FieldGrades;
using EducationDAL.InstitutionManagement.Subjects;
using EducationDAL.InstitutionManagement.Versions;
using EducationDAL.InstitutionManagement.Semesters;
using EducationDAL.InstitutionManagement.HourTables;
using EducationDAL.InstitutionManagement.Organs;
using EducationDAL.InstitutionManagement.OrganesTypes;
using EducationDAL.InstitutionManagement.Regions; 

namespace EducationDAL.InstitutionManagement
{
    //机构管理工厂
    public class InstitutionPlant : Institution
    {
        //班级管理
        public override ClassManagement ClassManagement()
        {
            return new ClassManagementRealize();
        }
        //学段年级
        public override FieldGrade FieldGrade()
        {
            return new FieldGradeRealize();
        }
        //课时包表
        public override HourTable HourTable()
        {
            return new HourTableRealize();
        }

        //机构树表
        public override Organes Organ()
        {
            return new OrganRealize();
        }
        //机构类型表
        public override OrganesType OrganesType()
        {
            return new OrganesTypeRealize();
        }
        //地区表
        public override Region Region()
        {
            return new RegionRealize();
        }

        //学期
        public override Semester Semester()
        {
            return new SemesterRealize();
        }

        //科目
        public override Subject Subject()
        {
            return new SubjectRealize();
        }

        //版本
        public override Versiones Version()
        {
            return new VersionRealize();
        }
    }
}
