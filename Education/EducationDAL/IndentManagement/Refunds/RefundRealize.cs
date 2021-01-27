using EducationMODEL.linkModel;
using EducationMODEL.OrderManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationDAL.IndentManagement.Refunds
{
    //退款
    public class RefundRealize:Refund
    {
        /// <summary>
        /// 退款信息的显示
        /// </summary>
        /// <returns></returns>
        public override List<OrderaViewModel> GetRefundMod(string studentIphone = null, string studentName = null, string refundperson = null, int refundState = -1, int recursionId = -1, string refundTime = null)
        {
            string sql = " select * from Refund a join Orders b on a.OrderId=b.OrderId join Student c on b.StudentId=c.StudentId join Organ d on b.RecursionId=d.OrganId where 1 =1";
            if (!string.IsNullOrEmpty(studentIphone)) //学生账号(手机号)
            {
                //LIKE '%@Title%' 会解析成'%'@Title'%' 这里用拼接也是不行的'%'+@Title+'%' 只能用MySQL函数方法拼接
                sql += " and c.StudentIphone like  concat('%',@StudentIphone,'%')";
            }
            if (!string.IsNullOrEmpty(studentName))  //学生姓名
            {
                sql += " and c.StudentName like concat('%',@StudentName,'%')";
            }
            if (!string.IsNullOrEmpty(refundperson))  //申请人
            {
                sql += " and a.Refundperson like concat('%',@Refundperson,'%')";
            }
            if (refundState > -1)   //退款状态
            {
                sql += " and a.RefundState=@RefundState";
            }
            if (recursionId > -1)   //所属机构
            {
                sql += " and d.OrganId=@OrganId";
            }
            if (!string.IsNullOrEmpty(refundTime))  //申请退款时间
            {
                sql += " and a.RefundTime like concat('%',@RefundTime,'%')";
            }
            return DapperHelper.Query<OrderaViewModel>(sql, new { StudentIphone = studentIphone, StudentName= studentName, Refundperson = refundperson , RefundState = refundState, OrganId = recursionId , RefundTime= refundTime });
        }
        /// <summary>
        /// 根据id查询退款信息信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override List<OrderaViewModel> GetRefundMod(int id)
        {
            string sql = " select * from Refund a  join Orders b on a.OrderId=b.OrderId join Student c on b.StudentId=c.StudentId join Organ d on b.RecursionId=d.OrganId join Study e on b.StID=e.StID where a.RefundId=@RefundId";
            return DapperHelper.Query<OrderaViewModel>(sql, new { RefundId=id });
        }
        /// <summary>
        /// 添加退款订单
        /// </summary>
        /// <param name="refund"></param>
        /// <returns></returns>
        public override int AddRefund(RefundMod refund)
        {
            return DapperHelper.Execute("insert into Refund values(@OrderId,@RefundAmount,@RefundRemark,@Refundperson,@Verifier,@RefundTime,@RefundState)", refund);
        }
        /// <summary>
        /// 退款商品的审核
        /// </summary>
        /// <param name="refundId"></param>
        /// <param name="refundAmount"></param>
        /// <param name="RefundRemark"></param>
        /// <returns></returns>
        public override int EditRefund(RefundMod refund)
        {
            return DapperHelper.Execute("update Refund Set RefundAmount=@RefundAmount,RefundRemark=@RefundRemark,Verifier=@Verifier,RefundState=@RefundState where RefundId=@RefundId", refund);
        }
        /// <summary>
        /// 首页显示课时小于十五的学生信息
        /// </summary>
        /// <returns></returns>
        public override List<OrderaViewModel> GetStudentOrder()
        {
            string sql = "select student.StudentIphone,student.StudentName,organ.OrganName,audition.AuditionClass,orders.PeriodNum  from Student student join AuditionStudent auditionStudent on student.StudentId = auditionStudent.Student join Audition audition on auditionStudent.Audition = audition.AuditionID join Organ organ on organ.OrganId = student.Institution join Orders orders on student.StudentId = orders.StudentId where orders.PeriodNum < 15";
            return DapperHelper.Query<OrderaViewModel>(sql,new { });
        }
        /// <summary>
        /// 本月退款
        /// </summary>
        /// <returns></returns>
        public override List<RefundMod> GetRefunds()
        {
            return DapperHelper.Query<RefundMod>("select * from Refund where datediff(Month,RefundTime,getdate())=0 and RefundState=2 or RefundState=1", new { });
        }
    }
}
