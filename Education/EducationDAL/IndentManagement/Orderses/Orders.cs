using EducationDAL.InstitutionManagement.Organs;
using EducationMODEL.Infrastructure;
using EducationMODEL.linkModel;
using EducationMODEL.OrderManagement;
using EducationMODEL.organizational;
using EducationMODEL.students;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.IndentManagement.Orderses
{
    //订单
    public abstract class Orders
    {
        /// <summary>
        /// 订单的显示以及查询
        /// </summary>
        /// <returns></returns>
        public abstract List<OrderaViewModel> GetOrdersMods(string studentIphone = null, string studentName = null, int businessTypeId = -1, int classModelId = -1, int stID = -1);
        /// <summary>
        /// 查询出所有业务类型
        /// </summary>
        /// <returns></returns>
        public abstract List<BusinessTypeMod> GetBusinessTypeMods();
        /// <summary>
        /// 查询出所有的班型
        /// </summary>
        /// <returns></returns>
        public abstract List<ClassModelMod> GetClassModelMods();
        /// <summary>
        /// 查询出所有学段
        /// </summary>
        /// <returns></returns>
        public abstract List<Study> GetStudies();
        /// <summary>
        /// 查询出所有课时类型
        /// </summary>
        /// <returns></returns>
        public abstract List<HourTypeMod> GetTypeMods();
        /// <summary>
        /// 根据参数查询出是意向/正式学员
        /// </summary>
        /// <returns></returns>
        public abstract List<StudentViewModel> GetStudents(int studentKind= -1);
        /// <summary>
        /// 查询出所有的机构
        /// </summary>
        /// <returns></returns>
        public abstract List<OrganMod> GetOrganes();


    }
}
