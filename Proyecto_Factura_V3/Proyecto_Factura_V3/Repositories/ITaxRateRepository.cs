﻿using Proyecto_Factura_V3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Repositories
{
    public interface ITaxRateRepository
    {
        Task<TaxRate> GetId(int id);
        Task<List<TaxRate>> GetAll();

        Task<TaxRate> AddEntity(TaxRate entity);

        Task<TaxRate> UpdateEntity(TaxRate entity);

        Task DeleteEntity(TaxRate entity);
        Task DeleteId(int id);
    }
}
