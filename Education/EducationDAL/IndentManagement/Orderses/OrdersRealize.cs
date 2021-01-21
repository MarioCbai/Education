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
        public override List<OrderaViewModel> GetOrdersMods(string studentIphone = null, string studentName = null, int businessTypeId = -1, int classModelId = -1, int stID = -1, int orderStatus = -1, int stateOfPayment = -1, string consumerName = null, int organId = -1)
        {
            string sql = "select * from Orders orders join Student student on orders.StudentId = student.StudentId join BusinessType businessType on orders.BusinessTypeId = businessType.BusinessTypeId join ClassModel classmodel on orders.ClassModelId = classmodel.ClassModelId join Study study on orders.StID = study.StID join Organ organ on organ.OrganId = orders.RecursionId join Refund refund on refund.RefundId = orders.OrderId join HourType hourType on hourType.HourTypeId = orders.HourTypeId join PriceRank pricerank on pricerank.PriceRankId = orders.PriceRankId join Pricing pricing on pricing.PricingId = orders.PricingId where 1 =1";
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
            if (orderStatus>-1)
            {
                sql += " and orders.orderStatus=@OrderStatus";
            }
            if (stateOfPayment > -1)
            {
                sql += " and orders.stateOfPayment=@StateOfPayment";
            }
            if (!string.IsNullOrEmpty(consumerName))  //添加人姓名
            {
                sql += " and consumer.consumerName like concat('%',@ConsumerName,'%')";
            }
            if (organId > -1)
            {
                sql += " and Organ.OrganId=@OrganId";
            }

            return DapperHelper.Query<OrderaViewModel>(sql, new { StudentIphone = studentIphone, StudentName = studentName, BusinessTypeId = businessTypeId, ClassModelId = classModelId, StID = stID, OrderStatus= orderStatus , StateOfPayment = stateOfPayment , ConsumerName = consumerName , OrganId = organId });
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
        public override StudentViewModel GetStudentModsById(int id)
        {
            string sql = "select * from Student student join Study study on student.StID = study.StID join Organ organ on student.Institution = organ.OrganId where student.StudentId=@StudentId";
            return DapperHelper.QueryFirstOrDefault<StudentViewModel>(sql, new { StudentId=id });
        }
        /// <summary>
        /// 查询所有价格级别
        /// </summary>
        /// <returns></returns>
        public override List<PriceRankMod> GetPriceRanks()
        {
            return DapperHelper.Query<PriceRankMod>("select * from PriceRank", new { });
        }
        /// <summary>
        /// 根据id查询订单信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override List<OrderaViewModel> GetOrderaViews(int id)
        {
            string sql = "select  * from Orders orders join Student student on orders.StudentId = student.StudentId join BusinessType businessType on orders.BusinessTypeId = businessType.BusinessTypeId join ClassModel classmodel on orders.ClassModelId = classmodel.ClassModelId join Study study on orders.StID = study.StID join Organ organ on organ.OrganId = orders.RecursionId join Refund refund on refund.RefundId = orders.OrderId join HourType hourType on hourType.HourTypeId = orders.HourTypeId join PriceRank pricerank on pricerank.PriceRankId = orders.PriceRankId join Pricing pricing on pricing.PricingId = orders.PricingId where 1 =1";
            return DapperHelper.Query<OrderaViewModel>(sql, new { OrderId =id});
        }
        /// <summary>
        /// 订单审核的状态修改
        /// </summary>
        /// <param name="id"></param>
        /// <param name="orderStatus"></param>
        /// <returns></returns>
        public override int UpdateOrderStatus(OrdersMod orders)
        {
            return DapperHelper.Execute("update Orders Set AuditDateTime=@AuditDateTime,OrdersRemark=@OrdersRemark,OrderStatus=@OrderStatus where OrderId=OrderId", orders);
        }
        /// <summary>
        /// 根据id查询出订单信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override OrderaViewModel GetOrderaViewModelById(int id)
        {
            string sql = "select * from Orders orders join Student student on orders.StudentId = student.StudentId join BusinessType businessType on orders.BusinessTypeId = businessType.BusinessTypeId join ClassModel classmodel on orders.ClassModelId = classmodel.ClassModelId join Study study on orders.StID = study.StID join Payment payment on payment.PaymentOrderId = orders.OrderId join Organ organ on organ.OrganId = orders.RecursionId join Consumer consumer on consumer.ConsumerId = orders.ConsumerId join Refund refund on refund.RefundId = orders.OrderId join HourType hourType on hourType.HourTypeId = orders.HourTypeId join PriceRank pricerank on pricerank.PriceRankId = orders.PriceRankId join Pricing pricing on pricing.PricingId = orders.PricingId join SubjectsHourType subjectshourtype on subjectshourtype.HourType = HourType.HourTypeId join Subjects subjects on subjects.SubjectsId = subjectshourtype.Subjects where orders.OrderId=@OrderId";
            return DapperHelper.QueryFirstOrDefault<OrderaViewModel>(sql,new { OrderId =id});
        }
        /// <summary>
        /// 修改订单信息
        /// </summary>
        /// <param name="ovm"></param>
        /// <returns></returns>
        public override int EditOrders(OrdersMod  orders)
        {
            return DapperHelper.Execute("update Orders Set BusinessTypeId=@BusinessTypeId,PriceRankId=@PriceRankId,ClassModelId=@ClassModelId,StID=@StID,HourTypeId=@HourTypeId,PeriodNum=@PeriodNum,ComplimentaryPeriod=@ComplimentaryPeriod,CommodityPrice=@CommodityPrice,PreferentialPrice=@PreferentialPrice,OrdersRemark=@OrdersRemark where OrderId=@OrderId",orders);
        }
        /// <summary>
        /// 根据下拉框该变查询出课时单价
        /// </summary>
        /// <param name="priceRankId"></param>
        /// <param name="classModelId"></param>
        /// <param name="stID"></param>
        /// <param name="hourTypeId"></param>
        /// <returns></returns>
        public override PricingMod GetPricingMods(int priceRankId = -1, int classModelId = -1, int stID = -1, int hourTypeId = -1)
        {
            string sql = "select * from Pricing where 1=1";
            //判断参数是否符合
            if (priceRankId>-1)
            {
                sql += " and PriceRankId=@PriceRankId";
            }
            if (classModelId>-1)
            {
                sql += "  and ClassModelId=@ClassModelId";
            }
            if (stID>-1)
            {
                sql += " and StID=@StID ";
            }
            if (hourTypeId>-1)
            {
                sql += " and HourTypeId=@HourTypeId";
            }
            return DapperHelper.QueryFirstOrDefault<PricingMod>(sql,new { PriceRankId= priceRankId , ClassModelId=classModelId, StID=stID, HourTypeId=hourTypeId });
        }
        /// <summary>
        /// 添加订单信息
        /// </summary>
        /// <param name="orders"></param>
        /// <returns></returns>
        public override int AddOrders(OrdersMod orders)
        {
            return DapperHelper.Execute(" insert into Orders values(@OrderNo,@StudentId,@BusinessTypeId,@ClassModelId,@StID,@OrderAmount,@AmountPayable,@AmountActually,@OrderStatus,@StateOfPayment,@buyer,@RecursionId,@OrderTime,@AuditDateTime,@PriceRankId,@HourTypeId,@SubjectsId,@PricingId,@PeriodNum,@ComplimentaryPeriod,@CommodityPrice,@PreferentialPrice,@OrdersRemark)", orders);
        }
        
        

    }
}
