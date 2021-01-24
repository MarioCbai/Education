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
    }
}
