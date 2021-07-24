﻿using Proyecto_Factura_V3.Models;
using Proyecto_Factura_V3.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Services
{
    public interface IProductService
    {
        Task<Product> GetId(int id);
        List<Product> GetAll();

        Task<Product> AddEntity(ProductRequest entity);

        Task<Product> UpdateEntity(Product entity);

        Task DeleteEntity(Product entity);
        Task DeleteId(int id);
    }
}
