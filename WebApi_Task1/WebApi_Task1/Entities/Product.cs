﻿namespace WebApi_Task1.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }
    }
}

