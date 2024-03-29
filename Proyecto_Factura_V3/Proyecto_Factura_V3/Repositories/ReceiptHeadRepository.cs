﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proyecto_Factura_V3.DataAccess;
using Proyecto_Factura_V3.Models;

namespace Proyecto_Factura_V3.Repositories
{
    public class ReceiptHeadRepository : IReceiptHeadRepository
    {
        private readonly IDDBBContext _context;

        public ReceiptHeadRepository(IDDBBContext context)
        {
            _context = context;
        }

        public async Task<ReceiptHead> GetId(int id)
        {
            return await _context.ReceiptHeads.Include(x => x.Branch).Include(x => x.Customer).Include(x => x.ReceiptDetails).Where(x => x.ReceiptHeadId == id).FirstOrDefaultAsync();
        }

        public async Task<List<ReceiptHead>> GetAll()
        {
            return await _context.ReceiptHeads.Include(x => x.Branch).Include(x => x.Customer).Include(x => x.ReceiptDetails).Select(x => x).ToListAsync();
        }


        public async Task<ReceiptHead> AddEntity (ReceiptHead entity)
        {
            _context.ReceiptHeads.Add(entity);
            await _context.SaveChangesAsync();
            return await GetId(entity.ReceiptHeadId);
        }

        public async Task<ReceiptHead> UpdateEntity(ReceiptHead entity)
        {
            _context.ReceiptHeads.Update(entity);
            await _context.SaveChangesAsync();
            return await GetId(entity.ReceiptHeadId);
        }


        public async Task DeleteEntity(ReceiptHead entity)
        {
            _context.ReceiptHeads.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteId(int id)
        {
            var model = await GetId(id);
            await DeleteEntity(model);
        }
    }
}
