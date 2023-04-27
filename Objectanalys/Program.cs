using Microsoft.EntityFrameworkCore;
using Objectanalys.Contexts;
using Objectanalys.Repositories;
using Objectanalys.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddScoped<ArticlesAddService>();
builder.Services.AddScoped<ArticleRepository>();
builder.Services.AddScoped<ArticlesService>();
builder.Services.AddScoped<ContentTypesService>();


builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Sql")));



https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();