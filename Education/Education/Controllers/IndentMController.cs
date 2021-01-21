using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationDAL.IndentManagement.Orderses;
using EducationMODEL.Infrastructure;
using EducationMODEL.linkModel;
using EducationMODEL.OrderManagement;
using EducationMODEL.organizational;
using EducationMODEL.students;
using IEducation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Education.Controllers
{
    /// <summary>
    /// 订单管理
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class IndentMController : ControllerBase
    {
        #region 控制反转以及日志
        private readonly ILogger<IndentMController> _logger;
        private IIndentManagement _indentManagement;
        /// <summary>
        /// 订单管理接口
        /// </summary>
        /// <param name="indentManagement"></param>
        public IndentMController(IIndentManagement indentManagement, ILogger<IndentMController> logger)
        {
            _logger = logger;
            _indentManagement = indentManagement;
        }
        #endregion

        #region 检索需要用到的下拉绑定
        /// <summary>
        /// 查询出所有的班型
        /// </summary>
        /// <returns></returns>
        [Route("/api/GetClassModel")]
        [HttpGet]
        public string GetClassModel()
        {
            _logger.LogInformation("班型的显示(绑定下拉)");
            List<ClassModelMod> list = _indentManagement.GetClassModelMods();
            return JsonConvert.SerializeObject(list);
        }
        /// <summary>
        /// 业务类型的显示(绑定下拉)
        /// </summary>
        /// <returns></returns>
        [Route("/api/GetBusinessType")]
        [HttpGet]
        public string GetBusinessType()
        {
            _logger.LogInformation("业务类型的显示(绑定下拉)");
            List<BusinessTypeMod> list = _indentManagement.GetBusinessTypeMods();
            return JsonConvert.SerializeObject(list);
        }
        /// <summary>
        /// 学段的显示(绑定下拉)
        /// </summary>
        /// <returns></returns>
        [Route("/api/GetStudy")]
        [HttpGet]
        public string GetStudy()
        {
            _logger.LogInformation("学段的显示(绑定下拉)");
            List<Study> list = _indentManagement.GetStudies();
            return JsonConvert.SerializeObject(list);
        }
        /// <summary>
        /// 查询出所有的机构
        /// </summary>
        /// <returns></returns>
        [Route("/api/GetOrgane")]
        [HttpGet]
        public string GetOrgane()
        {
            _logger.LogInformation("机构的显示(绑定下拉)");
            List<OrganMod> list = _indentManagement.GetOrganes();
            return JsonConvert.SerializeObject(list);
        }
        /// <summary>
        /// 查询出所有的课时类型
        /// </summary>
        /// <returns></returns>
        [Route("/api/GetTypeMod")]
        [HttpGet]
        public string GetTypeMod()
        {
            _logger.LogInformation("课时类型的显示(绑定下拉)");
            List<HourTypeMod> list = _indentManagement.GetTypeMods();
            return JsonConvert.SerializeObject(list);
        }
        /// <summary>
        /// 根据参数查询出是意向/正式学员
        /// </summary>
        /// <returns></returns>
        [Route("/api/GetStudent")]
        [HttpGet]
        public string GetStudent(int studentKind = -1)
        {
            _logger.LogInformation("根据参数查询出是意向/正式学员(添加)");
            List<StudentViewModel> list = _indentManagement.GetStudentMods(studentKind);
            var JsonData = new
            {
                code = 0, //解析接口状态
                msg = "", //解析提示文本
                count = list.Count, //解析数据长度
                data = list//解析数据列表
            };
            return JsonConvert.SerializeObject(JsonData);
        }
        #endregion

        #region  订单的操作
        /// <summary>
        /// 显示以及查询
        /// </summary>
        /// <returns></returns>
        [Route("/api/GetOrders")]
        [HttpGet]
        public string GetOrders(string studentIphone = null, string studentName = null, int businessTypeId = -1, int classModelId = -1, int stID = -1, int orderStatus = -1, int stateOfPayment = -1, string consumerName = null, int organId = -1)
        {
            _logger.LogInformation("订单的显示以及查询记录");
            List<OrderaViewModel> list = _indentManagement.GetOrdersMods(studentIphone, studentName, businessTypeId, classModelId, stID);
            //layui显示的转换
            var JsonData = new
            {
                code = 0, //解析接口状态
                msg = "", //解析提示文本
                count = list.Count, //解析数据长度
                data = list//解析数据列表
            };
            return JsonConvert.SerializeObject(JsonData);
        }
        /// <summary>
        /// 根据id查学生
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("/api/GetStudentsById")]
        [HttpGet]
        public string GetStudentsById(int id)
        {
            _logger.LogInformation("反填学生信息");
            StudentViewModel list = _indentManagement.GetStudentModsById(id);
            return JsonConvert.SerializeObject(list);
        }
        /// <summary>
        /// 查询所有价格级别
        /// </summary>
        /// <returns></returns>
        [Route("/api/GetPriceRank")]
        [HttpGet]
        public string GetPriceRanks()
        {
            _logger.LogInformation("查询所有价格级别");
            List<PriceRankMod> list = _indentManagement.GetPriceRanks();
            return JsonConvert.SerializeObject(list);
        }
        /// <summary>
        /// 根据id查询订单信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("/api/GetOrderaViews")]
        [HttpGet]
        public string GetOrderaViews(int id)
        {
            _logger.LogInformation("根据id查询订单信息");
            List<OrderaViewModel> list = _indentManagement.GetOrderaViews(id);
            var JsonData = new
            {
                code = 0, //解析接口状态
                msg = "", //解析提示文本
                count = list.Count, //解析数据长度
                data = list//解析数据列表
            };
            return JsonConvert.SerializeObject(JsonData);
        }
        /// <summary>
        /// 订单审核的状态修改
        /// </summary>
        /// <param name="id"></param>
        /// <param name="orderStatus"></param>
        /// <returns></returns>
        [Route("/api/UpdateOrderStatus")]
        [HttpPost]
        public int UpdateOrderStatus(OrdersMod orders)
        {
            orders.AuditDateTime = DateTime.Now;
            _logger.LogInformation("订单的审核操作");
            int row = _indentManagement.UpdateOrderStatus(orders);
            return row;
        }
        /// <summary>
        /// 根据id查询出订单信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("/api/GetOrderaViewModelById")]
        [HttpGet]
        public string GetOrderaViewModelById(int id)
        {
            _logger.LogInformation("根据id查询出订单信息");
            OrderaViewModel list = _indentManagement.GetOrderaViewModelById(id);
            return JsonConvert.SerializeObject(list);
        }
        /// <summary>
        /// 修改订单信息
        /// </summary>
        /// <param name="ovm"></param>
        /// <returns></returns>  
        [Route("/api/EditOrder")]
        [HttpPost]
        public int EditOrders(OrdersMod orders)
        {
            _logger.LogInformation("订单的编辑操作");
            int row = _indentManagement.EditOrders(orders);
            return row;
        }
        /// <summary>
        /// 根据下拉框该变查询出课时单价
        /// </summary>
        /// <param name="priceRankId"></param>
        /// <param name="classModelId"></param>
        /// <param name="stID"></param>
        /// <param name="hourTypeId"></param>
        /// <returns></returns>
        [Route("/api/GetPricing")]
        [HttpGet]
        public string GetPricingMods(int priceRankId = -1, int classModelId = -1, int stID = -1, int hourTypeId = -1)
        {
            _logger.LogInformation("根据下拉查询课时单价");
           PricingMod list = _indentManagement.GetPricingMods(priceRankId,classModelId,stID,hourTypeId);
            return JsonConvert.SerializeObject(list);
        }
        /// <summary>
        /// 添加订单信息
        /// </summary>
        /// <param name="orders"></param>
        /// <returns></returns>
        [Route("/api/AddOrders")]
        [HttpPost]
        public int AddOrders(OrdersMod orders)
        {
            Random random = new Random();
            if (orders.BusinessTypeId==1)
            {
                string name = "XS";
                string year = DateTime.Now.ToString("yyyy");
                string month= DateTime.Now.ToString("MM");
                string day = DateTime.Now.ToString("dd");
                int num = random.Next(1000000);
                orders.OrderNO = name + year+month+day+num;
            }
            else
            {
                string name = "XX";
                string year = DateTime.Now.ToString("yyyy");
                string month = DateTime.Now.ToString("MM");
                string day = DateTime.Now.ToString("dd");
                int num = random.Next(1000000);
                orders.OrderNO = name + year + month + day + num;
            }
            orders.OrderStatus = 0;  //订单状态
            orders.StateOfPayment = 0;//支付状态
            orders.buyer = "田七";    //下单人
            orders.OrderTime = DateTime.Now;   //下单时间
            orders.AuditDateTime = DateTime.Now;   //审核时间
            orders.SubjectsId = 1;   //科目表主键
            _logger.LogInformation("添加订单信息");
            int row = _indentManagement.AddOrders(orders);
            return row;
        }
        #endregion

        #region  退款操作
        /// <summary>
        /// 退款信息的显示
        /// </summary>
        /// <returns></returns>
        [Route("/api/GetRefund")]
        [HttpGet]
        public string GetRefundMod()
        {
            _logger.LogInformation("退款订单的显示以及查询记录");
            List<OrderaViewModel> list = _indentManagement.GetRefundMod();
            var JsonData = new
            {
                code = 0, //解析接口状态
                msg = "", //解析提示文本
                count = list.Count, //解析数据长度
                data = list//解析数据列表
            };
            return JsonConvert.SerializeObject(JsonData);
        }

        /// <summary>
        /// 根据id查询退款信息信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("/api/GetRefundById")]
        [HttpGet]
        public string GetRefundMod(int id)
        {
            _logger.LogInformation("退款订单的显示以及查询记录");
            List<OrderaViewModel> list = _indentManagement.GetRefundMod(id);
            var JsonData = new
            {
                code = 0, //解析接口状态
                msg = "", //解析提示文本
                count = list.Count, //解析数据长度
                data = list//解析数据列表
            };
            return JsonConvert.SerializeObject(JsonData);
        }
        /// <summary>
        /// 添加退款订单
        /// </summary>
        /// <param name="refund"></param>
        /// <returns></returns>
        [Route("/api/AddRefund")]
        [HttpPost]
        public int AddRefund(RefundMod refund)
        {
            _logger.LogInformation("添加退款订单");
            refund.RefundTime = DateTime.Now;
            refund.Refundperson = "李四";
            refund.RefundState = 0;
            int row = _indentManagement.AddRefund(refund);
            return row;
        }
        /// <summary>
        /// 退款商品的审核
        /// </summary>
        /// <param name="refundId"></param>
        /// <param name="refundAmount"></param>
        /// <param name="RefundRemark"></param>
        /// <returns></returns>
        [Route("/api/EditRefund")]
        [HttpPost]
        public int EditRefund(RefundMod refund)
        {
            _logger.LogInformation("编辑退款订单的审核状态");
            int row = _indentManagement.EditRefund(refund);
            return row;
        }




        #endregion




    }
}
