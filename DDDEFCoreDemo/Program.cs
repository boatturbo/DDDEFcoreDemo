using Infrastructure.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ModelDbContext>(opt => {
    string connectionString = builder.Configuration.GetConnectionString("MySQLConnection");
    var serverVersion = ServerVersion.AutoDetect(connectionString);
    opt.UseMySql(connectionString, serverVersion);
});

//添加完上面的DbContext依赖注入后：
//Codefrist 将代码映射到数据库:
//点击工具 ->NUGET包管理器 -> 程序包管理器控制台 ->"默认项目"选择DbContext所在项目(本解决方案是在Infrastructure项目，要安装Microsoft.EntityFrameworkCore.Tools)
//依次执行Add-Migration init、Update-Database

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

