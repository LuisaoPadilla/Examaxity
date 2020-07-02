using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamaxityApp.Models;
using ExamaxityApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExamaxityApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsRepository repository;
        public ProductsController(IProductsRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<List<Products>> Get()
        {
            return await repository.GetProducts();
        }
    }
}