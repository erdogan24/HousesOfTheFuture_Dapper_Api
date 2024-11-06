using HousesOfTheFuture_Dapper_Api.Models.DapperContext;
using HousesOfTheFuture_Dapper_Api.Repositories.BottomGridRepositories;
using HousesOfTheFuture_Dapper_Api.Repositories.CategoryRepository;
using HousesOfTheFuture_Dapper_Api.Repositories.EmployeeRepositories;
using HousesOfTheFuture_Dapper_Api.Repositories.PopularLocationRepositories;
using HousesOfTheFuture_Dapper_Api.Repositories.ProductRepository;
using HousesOfTheFuture_Dapper_Api.Repositories.ServiceRepository;
using HousesOfTheFuture_Dapper_Api.Repositories.TestimonialRepositories;
using HousesOfTheFuture_Dapper_Api.Repositories.WhoWeAreRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddTransient<Context>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<IWhoWeAreDetailRepository, WhoWeAreDetailRepository>();
builder.Services.AddTransient<IServiceRepository, ServiceRepository>();
builder.Services.AddTransient<IBottomGridRepository, BottomGridRepository>();
builder.Services.AddTransient<IPopularLocationRepository, PopularLocationRepository>();
builder.Services.AddTransient<ITestimonialRepository, TestimonialRepository>();
builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();



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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
