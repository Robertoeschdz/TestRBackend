using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;
using TestRBackend.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<TestContext>(
    options =>
    {
        options.UseMySQL(builder.Configuration.GetConnectionString("TestDB"));
    });

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "CorsPolicy", policy =>
    {
        policy.WithOrigins("https://jade-meerkat-fffb8b.netlify.app");
        policy.AllowAnyMethod();
        policy.AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors("CorsPolicy");

app.Run();
