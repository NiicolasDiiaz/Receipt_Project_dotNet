﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proyecto_Factura_V3.Models;
using Proyecto_Factura_V3.Request;
using Proyecto_Factura_V3.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly ILogger<CustomersController> _logger;

        private readonly ICustomerService _service;

        public CustomersController(ICustomerService service, ILogger<CustomersController> logger)
        {
            _service = service;

            _logger = logger;
        }

        [HttpGet("{id}")]
        public async Task<Customer> Get(int id) //Deberia ser (int? id) ? Acepto null y lidio con eso
        {
            return await _service.GetId(id);
        }
        
        [HttpGet]
        public async Task<List<Customer>> Get() //Deberia ser (int? id) ? Acepto null y lidio con eso
        {
            return await _service.GetAll();
        }


        [HttpPost]
        public async Task<Customer> Post([FromBody] CustomerRequest request)
        {
            return await _service.AddEntity(request);
        }


        [HttpPut("{id}")]
        public async Task<Customer> Put(int id, [FromBody] CustomerRequest request)
        {
            return await _service.UpdateEntity(id, request);
        }


        [HttpDelete("{id}")]
        public async Task Delete(int id) 
        {
            await _service.DeleteId(id);
        }
    }
}
