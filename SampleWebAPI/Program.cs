using Core;
using Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Repository;
using SampleWebAPI.Service.Implements;
using SampleWebAPI.Service.Interfaces;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDbContext>(opts => opts.UseSqlServer(builder.Configuration.GetConnectionString("SQLCon")));

builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:key"]));
    var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["JWT:Issuer"],
        ValidateLifetime = true,
        IssuerSigningKey = creds.Key,
        ValidAudience = builder.Configuration["JWT:Audience"],
        ValidateAudience = true,
        ClockSkew = TimeSpan.FromMinutes(30)
    };
});

builder.Services.AddAuthorization();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    //c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    //{
    //    In = ParameterLocation.Header,
    //    Description = "Please insert JWT with 'Bearer' into field",
    //    Name = "Authorization",
    //    Type = SecuritySchemeType.ApiKey
    //});


});

//Configure Repository Wrapper
builder.Services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();

builder.Services.AddTransient<IFacilityService, FacilityService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
