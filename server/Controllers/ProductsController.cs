using System.Text.Json;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using server.Controllers;
using server.Extensions;
using server.RequestHelpers;

namespace API.Controllers 
{
    public class ProductsController: BaseApiController
    {
        private readonly StoreContex _context;
        public ProductsController(StoreContex context)
        {
             _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts([FromQuery]ProductParams productParams)
        {
            var query =  _context.Products
            .Sort(productParams.OrderBy)
            .Search(productParams.searchTerm)
            .Filter(productParams.Brands,productParams.Types)
            .AsQueryable ();

            var products = await PagedList<Product>.ToPagedList(query,productParams.PageNumber,productParams.PageSize);

            Response.AddPaginationHeader(products.MetaData);

            return products;
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            
            if(product == null) return NotFound();

            return product;
        }
    }
}