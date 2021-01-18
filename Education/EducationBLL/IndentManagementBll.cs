using EducationDAL.IndentManagement;
using EducationMODEL.Infrastructure;
using EducationMODEL.linkModel;
using EducationMODEL.OrderManagement;
using EducationMODEL.organizational;
using EducationMODEL.students;
using IEducation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationBLL
{
    //订单管理
    public class IndentManagementBll: IIndentManagement
    {
        Indent indents = new IndentPlant();
        /// <summary>
        /// 查询所有业务类型的数据
        /// </summary>
        /// <returns></returns>
        public List<BusinessTypeMod> GetBusinessTypeMods()
        {
            return indents.Orders().GetBusinessTypeMods();
        }

        /// <summary>
        /// 查询出所有的班型
        /// </summary>
        /// <returns></returns>
        public List<ClassModelMod> GetClassModelMods()
        {
            return indents.Orders().GetClassModelMods();
        }

        /// <summary>
        /// 订单的显示以及查询
        /// </summary>
        /// <returns></returns>
        public List<OrderaViewModel> GetOrdersMods(string studentIphone = null, string studentName = null, int businessTypeId = -1, int classModelId = -1, int stID = -1)
        {
            return indents.Orders().GetOrdersMods(studentIphone, studentName, businessTypeId, classModelId, stID);
        }
        /// <summary>
        /// 查询出所有的机构
        /// </summary>
        /// <returns></returns>
        public List<OrganMod> GetOrganes()
        {
            return indents.Orders().GetOrganes();
        }

        /// <summary>
        /// 退款信息的显示
        /// </summary>
        /// <returns></returns>
        public List<OrderaViewModel> GetRefundMod()
        {
            return indents.Refund().GetRefundMod();
        }
        /// <summary>
        /// 根据参数查询出是意向/正式学员
        /// </summary>
        /// <returns></returns>
        public List<StudentViewModel>  GetStudentMods(int studentKind = -1)
        {
            return indents.Orders().GetStudents(studentKind);
        }
        /// <summary>
        /// 根据id查学生
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<StudentViewModel> GetStudentModsById(int id)
        {
            return indents.Orders().GetStudentModsById(id);
        }

        /// <summary>
        /// 查询出所有学段
        /// </summary>
        /// <returns></returns>
        public List<Study> GetStudies()
        {
            return indents.Orders().GetStudies();
        }
        /// <summary>
        /// 查询出所有的课时类型
        /// </summary>
        /// <returns></returns>
        public List<HourTypeMod> GetTypeMods()
        {
            return indents.Orders().GetTypeMods();
        }
    }
}
