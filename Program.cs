using Packing3.Services;
using Packing3.Services.Impl;
using SnapObjects.Data;
using SnapObjects.Data.SqlServer;
using Packing3;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDataContext<Produccion_2022DataContext>(m => m.UseSqlServer(builder.Configuration, "Produccion_2023"));
builder.Services.AddScoped<IEmbalajesprodService, EmbalajesprodService>();
builder.Services.AddScoped<IEnvasesService, EnvasesService>();
builder.Services.AddScoped<IGtin_Dun14Service, Gtin_Dun14Service>();
builder.Services.AddScoped<ICorrelfolioService, CorrelfolioService>();
builder.Services.AddScoped<ITipopallembaService, TipopallembaService>();
builder.Services.AddScoped<ICalibresEnvaseService, CalibresEnvaseService>();
builder.Services.AddScoped<ISpro_TimbresdespachoService, Spro_TimbresdespachoService>();
builder.Services.AddScoped<ICodigoOperacionalService, CodigoOperacionalService>();
builder.Services.AddScoped<ITimbreSAGService, TimbreSAGService>();
builder.Services.AddScoped<IProdcuartelesService, ProdcuartelesService>();


var key = Encoding.UTF8.GetBytes(SecretInfo.SECRET);
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(x =>
{
    x.RequireHttpsMetadata = true;
    x.SaveToken = true;
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});

var app = builder.Build();
app.UseAuthentication();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
