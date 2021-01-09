using System;
using System.Collections.Generic;
using System.Text;
using EducationDAL.InstitutionManagement.ClassManagements;
using EducationDAL.InstitutionManagement.FieldGrades;
using EducationDAL.InstitutionManagement.HourTables;
using EducationDAL.InstitutionManagement.Semesters;
using EducationDAL.InstitutionManagement.Subjects;
using EducationDAL.InstitutionManagement.Versions;
using EducationDAL.InstitutionManagement.Organs;
using EducationDAL.InstitutionManagement.OrganesTypes;
using EducationDAL.InstitutionManagement.Regions;


namespace EducationDAL.InstitutionManagement
{
    //机构管理
    public abstract class Institution
    {
        /// <summary>
        /// 班级管理
        /// </summary>
        /// <returns></returns>
        public abstract ClassManagement ClassManagement();
        /// <summary>
        /// 年级学段
        /// </summary>
        /// <returns></returns>
        public abstract FieldGrade FieldGrade();
        /// <summary>
        /// 科目表
        /// </summary>
        /// <returns></returns>
        public abstract Subject Subject();
        /// <summary>
        /// 版本表
        /// </summary>
        /// <returns></returns>
        public abstract Versiones Version();
        /// <summary>
        /// 学期
        /// </summary>
        /// <returns></returns>
        public abstract Semester Semester();
        /// <summary>
        /// 课时包表
        /// </summary>
        /// <returns></returns>
        public abstract HourTable HourTable();
        /// <summary>
        /// 机构树表
        /// </summary>
        /// <returns></returns>
        public abstract Organes Organ();
        /// <summary>
        /// 机构类型表
        /// </summary>
        /// <returns></returns>
        public abstract OrganesType OrganesType();
        /// <summary>
        /// 地区表
        /// </summary>
        /// <returns></returns>
        public abstract Region Region();

        

    }
}
