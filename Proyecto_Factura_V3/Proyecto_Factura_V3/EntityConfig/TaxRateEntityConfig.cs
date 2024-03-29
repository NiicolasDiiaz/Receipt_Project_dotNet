﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto_Factura_V3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.EntityConfig
{
    public class TaxRateEntityConfig
    {
        public static void SetTaxRateEntityConfig(EntityTypeBuilder<TaxRate> entityBuilder)
        {
            entityBuilder.HasKey(x => x.TaxRateId);
            entityBuilder.Property(x => x.Rate).IsRequired();
        }
    }
}
