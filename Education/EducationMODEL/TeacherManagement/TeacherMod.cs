using System;
using System.Collections.Generic;
using System.Text;

namespace EducationMODEL.TeacherManagement
{
    public class TeacherMod//教师表
    {
        public int TeacherId { get; set; }//教师表序号主键

        public int OrganId { get; set; }//机构外键
        public string OrganName { get; set; }//机构外键

        public string TeacherName { get; set; }//教师名称

        public string TeacherOuter { get; set; }//对外显示姓名

        public int TeacherSex { get; set; }//性别

        public int TeachereducationId { get; set; }//学历  中专，大专，本科，硕士，博士，其他
        public string TeachereducationName { get; set; }//学历  中专，大专，本科，硕士，博士，其他

        public string TeacherQQ { get; set; }//老师QQ

        public string TeacherWeChat { get; set; }//微信

        public int ProvinceId { get; set; }//省Id

        public int City { get; set; }//市Id地区绑定三级联动

        public int District { get; set; }//区Id

        public string TeacherTitle { get; set; }//老师职称教师助教1教师2助教

        public string TeacherPhone { get; set; }//手机号

        public string TeacherIDnumber { get; set; }//身份证号

        public string TeacherGraduate { get; set; }//毕业学校

        public string TeacherCom { get; set; }//邮箱

        public int TeacherCard { get; set; }//教师资格证

        public string TeacherPwd { get; set; }//密码

        public string TeacherResume { get; set; }//个人简介

        public int TeacherState { get; set; }//用户状态1启用 0禁用

        public int TeacherTypeId { get; set; }//主键Id

        public string TeacherTypeName { get; set; }//教师类别名称

        public int Sort { get; set; }//排序

        public int Ztai { get; set; }//状态
        public int LevelId { get; set; }//主键

        public string LeveName { get; set; }//教师级别名称

        public int TeachId { get; set; }//id

        public int TeacherType { get; set; }//教师类别(外键)

        public int TeacherRank { get; set; }//教师级别（外键）

        public string TeacherShowKe { get; set; }//可授课时

        public string TeacherLink { get; set; }//学段/学科/版本

        public int RecursionId { get; set; }//可授机构  所属机构绑定下拉(外键)

        public string TeacherYType { get; set; }//可授业务类型

        public int TeacherAge { get; set; }//老师教龄

        public string TeacherStyle { get; set; }//教学风格

        public int SubjectsId { get; set; }//学科外键
        public string SubjectsName { get; set; }//学科名称

        public int TextbookId { get; set; }//版本外键
        public string TextbookName { get; set; }//版本名称

        public DateTime TeacherTime { get; set; }//注册时间

        public int Teacher { get; set; }//教师基本表外键
    }
}
