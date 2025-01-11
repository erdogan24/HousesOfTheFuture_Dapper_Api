﻿namespace HousesOfTheFuture_Dapper_UI.DTOS.ProductDtos
{
    public class CreateProductDto
    {

        public string Title { get; set; }
        public int Price { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string CoverImage { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public bool DealOfTheDay { get; set; }
        public DateTime AdvertisementDate { get; set; }
        public bool ProductStatus { get; set; }
        public int ProductCategory { get; set; }
        public int EmployeeID { get; set; }
    }
}
