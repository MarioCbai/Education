using EducationDAL.AuthorityManagement;
using EducationDAL.AuthorityManagement.Users;
using IEducation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationBLL
{
    //权限管理全部方法
    public class AuthorityManagementBll: IAuthorityManagement
    {
        //权限工厂类存入权限工厂的实例
        Authority authoritys = new AuthorityPlant();

    }
}
