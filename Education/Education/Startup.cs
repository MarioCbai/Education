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
            //swagger����
            services.AddSwaggerSetup();
            services.AddSwaggerGen();
            services.AddTransient<IIndentManagement, IndentManagementBll>(); //��������ע��
            services.AddTransient<IAuthorityManagement, AuthorityManagementBll>();//Ȩ�޹���ע��
            services.AddTransient<IEssentialData, EssentialDataBll>();//�������ݹ���
            services.AddTransient<IFinances, FinancesBll>();//�������
            services.AddTransient<IInstitutionManagement, InstitutionManagementBll>();//��������
            services.AddTransient<IStudentManagement, StudentManagementBll>();//ѧԱ����
            services.AddTransient<ITeacherManagement, TeacherManagementBll>();//��ʦ����
            services.AddTransient<ITeachingManagement, TeachingManagementBll>();//��ѧ����
            services.AddCors(options =>
            {
                options.AddPolicy("any", builder =>
                {
                    builder.WithMethods("GET", "POST", "HEAD", "PUT", "DELETE", "OPTIONS").AllowAnyHeader()   //����дAllowAnyHeader����ǰ�˵����� 
                    //.AllowCredentials()//ָ������cookie
                .AllowAnyOrigin(); //�����κ���Դ����������
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

                //·�����ã�����Ϊ�գ���ʾֱ���ڸ�������localhost:8001�����ʸ��ļ�,ע��localhost:8001/swagger�Ƿ��ʲ����ģ�ȥlaunchSettings.json��launchUrlȥ����������뻻һ��·����ֱ��д���ּ��ɣ�����ֱ��дc.RoutePrefix = "doc";
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
