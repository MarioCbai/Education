using System;
using System.Collections.Generic;
using System.Text;
using EducationDAL.TeacherManagement.Credentialses;
using EducationDAL.TeacherManagement.Teachers;
using EducationDAL.TeacherManagement.TeachingInformations;
using EducationMODEL.TeacherManagement;

namespace EducationDAL.TeacherManagement
{
    //教师管理
    public class TeacherPlant : Teacher
    {
        /// <summary>
        /// 认证信息
        /// </summary>
        /// <returns></returns>
        public override Credentials Credentials()
        {
            //throw new NotImplementedException();
            return new CredentialsRealize();
        }

        /// <summary>
        /// 教师基本信息
        /// </summary>
        /// <returns></returns>
        public override Teacheres Teacheres()
        {
            return new TeacheresRealize();
        }


        /// <summary>
        /// 教师教学信息
        /// </summary>
        /// <returns></returns>
        public override TeachingInformation TeachingInformation()
        {
            return new TeachingInformationRealize();
        }



    }
}
