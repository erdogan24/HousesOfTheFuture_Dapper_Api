﻿using Dapper;
using HousesOfTheFuture_Dapper_Api.Dtos.CategoryDtos;
using HousesOfTheFuture_Dapper_Api.Dtos.ProductDtos;
using HousesOfTheFuture_Dapper_Api.Models.DapperContext;

namespace HousesOfTheFuture_Dapper_Api.Repositories.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;

        public ProductRepository(Context context)
        {
            _context = context;
        }

        public async Task CreateProduct(CreateProductDto createProductDto)
        {
            string query = "insert into Product (Title, Price,City,District,CoverImage,Address,Description,DealOfTheDay,AdvertisementDate,ProductStatus,ProductCategory,EmployeeID ) values (@Title, @Price,@City,@District,@CoverImage,@Address,@Description,@DealOfTheDay,@AdvertisementDate,@ProductStatus,@ProductCategory,@EmployeeID)";
            var parameters = new DynamicParameters();
            parameters.Add("@Title", createProductDto.Title);
            parameters.Add("@Price", createProductDto.Price);
            parameters.Add("@City", createProductDto.City);
            parameters.Add("@District", createProductDto.District);
            parameters.Add("@CoverImage", createProductDto.CoverImage);
            parameters.Add("@Address", createProductDto.Address);
            parameters.Add("@Description", createProductDto.Description);
            parameters.Add("@DealOfTheDay", createProductDto.DealOfTheDay);
            parameters.Add("@AdvertisementDate", createProductDto.AdvertisementDate);
            parameters.Add("@ProductStatus", createProductDto.ProductStatus);
            parameters.Add("@ProductCategory", createProductDto.ProductCategory);
            parameters.Add("@EmployeeID", createProductDto.EmployeeID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultProductDto>> GetAllProductAsync()
        {
            string query = "Select * From Product ";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync()
        {
            string query = "Select ProductID, Title, Price, City , District,CategoryName,CoverImage,Address,DealOfTheDay  From Product inner join Category on Product.ProductCategory=Category.CategoryID";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductWithCategoryDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultLast5ProductWithCategoryDto>> GetLast5ProductAsync()
        {
            string query = "Select Top(5) ProductID,Title,Price,City,District,ProductCategory,CategoryName,AdvertisementDate From Product Inner Join Category On  Product.ProductCategory=Category.CategoryID Order By ProductID Desc";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultLast5ProductWithCategoryDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductAdvertListWithCategoryByEmployeeDto>> GetProductAdvertListByEmployeeAsyncByFalse(int id)
        {
            string query = "Select ProductID, Title, Price, City , District,CategoryName,CoverImage,Address,DealOfTheDay  From Product inner join Category on Product.ProductCategory=Category.CategoryID where EmployeeId=@employeeId and ProductStatus=0";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeId", id);

            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductAdvertListWithCategoryByEmployeeDto>(query, parameters);
                return values.ToList();
            }
        }


        public async Task<List<ResultProductAdvertListWithCategoryByEmployeeDto>> GetProductAdvertListByEmployeeAsyncByTrue(int id)
        {
            string query = "Select ProductID, Title, Price, City , District,CategoryName,CoverImage,Address,DealOfTheDay  From Product inner join Category on Product.ProductCategory=Category.CategoryID where EmployeeId=@employeeId and ProductStatus=1";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeId", id);

            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductAdvertListWithCategoryByEmployeeDto>(query, parameters);
                return values.ToList();
            }
        }

        public async void ProductDealOfTheDayStatusChangeToFalse(int id)
        {
            string query = "Update Product Set DealOfTheDay = 0 where ProductID = @productID ";
            var parameters = new DynamicParameters();
            parameters.Add("@productID", id);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void ProductDealOfTheDayStatusChangeToTrue(int id)
        {
            string query = "Update Product Set DealOfTheDay = 1 where ProductID = @productID ";
            var parameters = new DynamicParameters();
            parameters.Add("@productID", id);
       
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
