using EducationBLL;
using EducationDAL;
using IEducation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Education
{
    /// <summary>
    /// 
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        /// <summary>
        /// 
        /// </summary>
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            //swagger配置
            services.AddSwaggerSetup();
            services.AddSwaggerGen();
            services.AddTransient<IIndentManagement, IndentManagementBll>(); //订单管理注入
            services.AddTransient<IAuthorityManagement, AuthorityManagementBll>();//权限管理注入
            services.AddTransient<IEssentialData, EssentialDataBll>();//基本数据管理
            services.AddTransient<IFinances, FinancesBll>();//财务管理
            services.AddTransient<IInstitutionManagement, InstitutionManagementBll>();//机构管理
            services.AddTransient<IStudentManagement, StudentManagementBll>();//学员管理
            services.AddTransient<ITeacherManagement, TeacherManagementBll>();//教师管理
            services.AddTransient<ITeachingManagement, TeachingManagementBll>();//教学管理
            services.AddCors(options =>
            {
                options.AddPolicy("any", builder =>
                {
                    builder.WithMethods("GET", "POST", "HEAD", "PUT", "DELETE", "OPTIONS").AllowAnyHeader()   //必须写AllowAnyHeader否则前端掉不了 
                    //.AllowCredentials()//指定处理cookie
                .AllowAnyOrigin(); //允许任何来源的主机访问
                });
            });
            services.AddControllers();

            services.Add(new ServiceDescriptor(typeof(DapperHelper), new DapperHelper(Configuration["ConnectionString:locastr"])));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors("any");
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint($"/swagger/V1/swagger.json", "WebApi.Core V1");

                //路径配置，设置为空，表示直接在根域名（localhost:8001）访问该文件,注意localhost:8001/swagger是访问不到的，去launchSettings.json把launchUrl去掉，如果你想换一个路径，直接写名字即可，比如直接写c.RoutePrefix = "doc";
                c.RoutePrefix = "";
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }

}
