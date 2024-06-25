//���������ģʽ
//WebApplication  �ܷ��࣬���ܱ��̳�
//CreateBuilder ��̬���������ڴ���WebApplicationBuilderʵ��
//Build ����WebApplicationʵ��
using BD.Tms.Respository;
using BD.Tms.IRespository;
using Microsoft.EntityFrameworkCore;
using BD.Tms.IServices.UserInfo;
using BD.Tms.Services;
using BD.Tms.ResporityAdo;

var builder = WebApplication.CreateBuilder(args);

//IOC����--���Ʒ�ת
// Add services to the container.
//��ӷ�������������--�ֵ䣩

//����������ӵ����񼯺���
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//���Swagger
builder.Services.AddEndpointsApiExplorer();
//���SwaggerUI
builder.Services.AddSwaggerGen();
//��� EF������
//����Զ��� �ӿڷ���
//����Զ��� ҵ���߼�����
builder.Services.AddDbContext<TmsDbContext>(option => { 
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

//ע��
// Scoped ��������������--����ÿ������ʱ����һ���µ�ʵ��
builder.Services.AddScoped<IUserRespositry, UserRespositry>();
builder.Services.AddScoped<IUserServices, UserServices>();
//����--����Ӧ�ó�������ʱ����һ��ʵ��
//builder.Services.AddSingleton<IUserService, UserService>();
// Transient ˲ʱ�������� --ÿ��ʹ��ʱ����һ���µ�ʵ��--���꼴�ͷ�
//builder.Services.AddTransient<IOrderService, OrderService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
//����HTTP����ܵ��������м����

//�жϿ��绷�� �������������Swagger
if (app.Environment.IsDevelopment())
{
    //�鿴swagger
    app.UseSwagger();
    app.UseSwaggerUI();
}
//��̬�ļ�
app.UseStaticFiles();

//�����м��
app.UseCors(x => x
    //.WithOrigins("http://localhost:5000")  //��������http://localhost:5000������
   .AllowAnyOrigin()  //�����κ�����Դ
   .AllowAnyMethod()  //�����κ����󷽷� get post put delete
   .AllowAnyHeader()  //�����κ�����ͷ Content-Type
   );

//��Ȩ�м��
app.UseAuthentication();
//��Ȩ�м��
app.UseAuthorization();

//���п�����
app.MapControllers();
//����
app.Run();
