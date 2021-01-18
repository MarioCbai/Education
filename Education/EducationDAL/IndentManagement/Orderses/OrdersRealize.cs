using EducationDAL.StudentManagement;
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
    //订单实现
    public class OrdersRealize : Orders
    {
        /// <summary>
        /// 查询出所有业务类型
        /// </summary>
        /// <returns></returns>
        public override List<BusinessTypeMod> GetBusinessTypeMods()
        {
            return DapperHelper.Query<BusinessTypeMod>("select * from BusinessType", new { });
        }
        /// <summary>
        /// 查询出所有的班型
        /// </summary>
        /// <returns></returns>
        public override List<ClassModelMod> GetClassModelMods()
        {
            return DapperHelper.Query<ClassModelMod>("select* from ClassModel", new { });
        }
        /// <summary>
        /// 查询出所有学段
        /// </summary>
        /// <returns></returns>
        public override List<Study> GetStudies()
        {
            return DapperHelper.Query<Study>("select * from Study where StudyId=0", new { });
        }
        /// <summary>
        /// 查询出所有业务类型
        /// </summary>
        /// <returns></returns>
        public override List<HourTypeMod> GetTypeMods()
        {
            return DapperHelper.Query<HourTypeMod>("select * from HourType", new { });
        }
        /// <summary>
        /// 订单的显示以及查询
        /// </summary>
        /// <returns></returns>
        public override List<OrderaViewModel> GetOrdersMods(string studentIphone = null, string studentName = null, int businessTypeId = -1, int classModelId = -1, int stID = -1)
        {
            string sql = "select * from Orders orders join Student student on orders.StudentId = student.StudentId join BusinessType businessType on orders.BusinessTypeId = businessType.BusinessTypeId join ClassModel classmodel on orders.ClassModelId = classmodel.ClassModelId join Study study on orders.StID = study.StID join Payment payment on payment.PaymentOrderId = orders.OrderId join Organ organ on organ.OrganId = orders.RecursionId join Consumer consumer on consumer.ConsumerId = orders.ConsumerId join Refund refund on refund.RefundId = orders.OrderId join HourType hourType on hourType.HourTypeId = orders.HourTypeId join PriceRank pricerank on pricerank.PriceRankId = orders.PriceRankId join Pricing pricing on pricing.PricingId = orders.PricingId join SubjectsHourType subjectshourtype on subjectshourtype.HourType = HourType.HourTypeId join Subjects subjects on subjects.SubjectsId = subjectshourtype.Subjects where 1 =1";
            //判断查询条件是否为空
            if (!string.IsNullOrEmpty(studentIphone)) //学生账号(手机号)
            {
                //LIKE '%@Title%' 会解析成'%'@Title'%' 这里用拼接也是不行的'%'+@Title+'%' 只能用MySQL函数方法拼接
                sql += " and student.StudentIphone like  concat('%',@StudentIphone,'%')";
            }
            if (!string.IsNullOrEmpty(studentName))  //学生姓名
            {
                sql += " and student.StudentName like concat('%',@StudentName,'%')";
            }
            if (businessTypeId > -1)   //业务类型的查询
            {
                sql += " and businessType.BusinessTypeId=@BusinessTypeId";
            }
            if (classModelId > -1)
            {
                sql += " and classmodel.BusinessTypeId=@ClassModelId";
            }
            if (stID > -1)
            {
                sql += " and study.StID=@StID";
            }

            return DapperHelper.Query<OrderaViewModel>(sql, new { StudentIphone = studentIphone, StudentName = studentName, BusinessTypeId = businessTypeId, ClassModelId = classModelId, StID = stID });
        }
        /// <summary>
        /// 根据参数查询出是意向/正式学员
        /// </summary>
        /// <returns></returns>
        public override List<StudentViewModel> GetStudents(int studentKind = -1)
        {
            string sql = "select * from Student student join Study study on student.StID = study.StID join Organ organ on student.Institution = organ.OrganId where 1 = 1 ";
            //判断传过来的参数
            if (studentKind>-1)
            {
                sql += " and student.StudentKind=@StudentKind";
            }
            return DapperHelper.Query<StudentViewModel>(sql, new {StudentKind=studentKind });
        }
        /// <summary>
        /// 查询出所有的机构
        /// </summary>
        /// <returns></returns>
        public override List<OrganMod> GetOrganes()
        {
            return DapperHelper.Query<OrganMod>("select * from Organ", new { });
        }
        /// <summary>
        /// 根据id查学生
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override List<StudentViewModel> GetStudentModsById(int id)
        {
            return DapperHelper.Query<StudentViewModel>("select * from Student student join Study study on student.StID = study.StID join Organ organ on student.Institution = organ.OrganId where student.StudentId=@StudentId", new { StudentId=id });
        }
    }
}
