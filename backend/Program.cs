

using backend.Configuration;
using backend.Models;
using backend.Repository.Classes;
using backend.Repository.Interfaces;
using backend.Services.Classes;
using backend.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("DBConnection");
builder.Services.AddDbContext<DBFormContext>(options => options.UseSqlServer(connString));
builder.Services.AddAutoMapper(typeof(MapperConfig));


//builder.Services.AddScoped<IUserRepository,UserRepository>();
builder.Services.AddControllers();

//user scoped
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserServices, UserServices>();

//form scoped

builder.Services.AddScoped<IFormRepository, FormRepository>();
builder.Services.AddScoped<IFormServices, FormServices>();

//cmp scoped

builder.Services.AddScoped<ICmpoRepository, CmpRepository>();
builder.Services.AddScoped<ICmpServices, CmpServices>();

//details scoped

builder.Services.AddScoped<IDetailRepository, DetailRepository>();
builder.Services.AddScoped<IDetailServices, DetailServices>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient();

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
    builder => builder.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());
});

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("CorsPolicy");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Run();
