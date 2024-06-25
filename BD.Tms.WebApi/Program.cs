//建造者设计模式
//WebApplication  密封类，不能被继承
//CreateBuilder 静态方法，用于创建WebApplicationBuilder实例
//Build 构建WebApplication实例
using BD.Tms.Respository;
using BD.Tms.IRespository;
using Microsoft.EntityFrameworkCore;
using BD.Tms.IServices.UserInfo;
using BD.Tms.Services;
using BD.Tms.ResporityAdo;

var builder = WebApplication.CreateBuilder(args);

//IOC容器--控制反转
// Add services to the container.
//添加服务到容器（集合--字典）

//将控制器添加到服务集合中
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//添加Swagger
builder.Services.AddEndpointsApiExplorer();
//添加SwaggerUI
builder.Services.AddSwaggerGen();
//添加 EF上下文
//添加自定义 接口服务
//添加自定义 业务逻辑服务
builder.Services.AddDbContext<TmsDbContext>(option => { 
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

//注入
// Scoped 作用域生命周期--请在每次请求时创建一个新的实例
builder.Services.AddScoped<IUserRespositry, UserRespositry>();
builder.Services.AddScoped<IUserServices, UserServices>();
//单例--请在应用程序启动时创建一个实例
//builder.Services.AddSingleton<IUserService, UserService>();
// Transient 瞬时生命周期 --每次使用时创建一个新的实例--用完即释放
//builder.Services.AddTransient<IOrderService, OrderService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
//配置HTTP请求管道（配置中间件）

//判断开如环境 开发环境下添加Swagger
if (app.Environment.IsDevelopment())
{
    //查看swagger
    app.UseSwagger();
    app.UseSwaggerUI();
}
//静态文件
app.UseStaticFiles();

//跨域中间件
app.UseCors(x => x
    //.WithOrigins("http://localhost:5000")  //允许来自http://localhost:5000的请求
   .AllowAnyOrigin()  //允许任何请求源
   .AllowAnyMethod()  //允许任何请求方法 get post put delete
   .AllowAnyHeader()  //允许任何请求头 Content-Type
   );

//鉴权中间件
app.UseAuthentication();
//授权中间件
app.UseAuthorization();

//导行控制器
app.MapControllers();
//运行
app.Run();
