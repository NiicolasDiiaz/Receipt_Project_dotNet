﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proyecto_Factura_V3.DataAccess;
using Proyecto_Factura_V3.Models;

namespace Proyecto_Factura_V3.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly IDDBBContext _context;

        public CompanyRepository(IDDBBContext context)
        {
            _context = context;
        }

        public async Task<Company> GetId(int id)
        {
            return await _context.Companies.Include(x => x.Branches).Where(x => x.CompanyId == id).FirstOrDefaultAsync();
        }

        public async Task<List<Company>> GetAll()
        {
            return await _context.Companies.Include(x => x.Branches).Select(x => x).ToListAsync();
        }


        public async Task<Company> AddEntity (Company entity)
        {
            _context.Companies.Add(entity);
            await _context.SaveChangesAsync();
            return await GetId(entity.CompanyId);
        }

        public async Task<Company> UpdateEntity(Company entity)
        {
            _context.Companies.Update(entity);
            await _context.SaveChangesAsync();
            return await GetId(entity.CompanyId);
        }


        public async Task DeleteEntity(Company entity)
        {
            _context.Companies.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteId(int id)
        {
            var model = await GetId(id);
            await DeleteEntity(model);
        }
    }
}
