﻿using Proyecto_Factura_V3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Repositories
{
    public interface IProductRepository
    {
        Task<Product> GetId(int id);
        Task<List<Product>> GetAll();

        Task<Product> AddEntity(Product entity);

        Task<Product> UpdateEntity(Product entity);

        Task DeleteEntity(Product entity);
        Task DeleteId(int id);
    }
}
