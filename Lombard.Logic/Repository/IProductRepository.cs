﻿using Lombard.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lombard.API.Repository
{
    public interface IProductRepository
    {
       List<Product> GetProducts();
       void AddProducts(IEnumerable<Product> products);
       void RemoveOrUpdateProducts(IEnumerable<Product> products);
       void DeleteProduct(int id);
       void UpdateProduct(Product product);
       Product SearchForProductById(int productId);
       List<Product> SerachForProductsByName(string productName);
    }
}
