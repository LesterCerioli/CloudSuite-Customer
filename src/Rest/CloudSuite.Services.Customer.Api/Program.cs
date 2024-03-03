using AutoMapper;
using CloudSuite.Application.Services.Contracts;
using CloudSuite.Application.Services.Implementations;
using CloudSuite.Infrastructure.Context;
using CloudSuite.Infrastructure.CrossCutting.DependencyInjector;
using CloudSuite.Infrastructure.CrossCutting.HealthChecks;
using CloudSuite.Infrastructure.CrossCutting.Middlewares;
using CloudSuite.Infrastructure.Repositories;
using CloudSuite.Modules.Domain.Contracts;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CustomerDbContext>(options =>
	options.UseSqlServer(builder.Configuration.GetConnectionString("AZURE_SQL_CONECTIONSTRING")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddMediator();
builder.Services.AddLogger();
builder.Services.AddHealthCheckConfigurations();
builder.Services.AddSwaggerDocVersion();
builder.Services.AddTransient<ExceptionHandlingMiddleware>();
//builder.Services.AddDatabaseConfiguration(builder.Configuration);


var mapperConfig = new MapperConfiguration(cfg =>
{
	// Aqui você pode definir os mapeamentos entre suas entidades e DTOs, se necessário
	// Por exemplo:
	// cfg.CreateMap<SourceClass, DestinationClass>();
});

builder.Services.AddTransient<ICompanyAppService, CompanyAppService>();
builder.Services.AddTransient<ICompanyRepository, CompanyRepository>();
IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

builder.Services.AddCors(options =>
{
	options.AddPolicy("my-cors",
						  policy =>
						  {
							  policy
							  .AllowAnyOrigin()
							  .AllowAnyHeader()
							  .AllowAnyMethod();
						  });
});

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
	app.UseHttpLogging();
}
//app.UseMiddleware<ExceptionHandlingMiddleware>();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseCors("my-cors");

app.Run();

