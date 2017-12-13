using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ICT13580024B3.Api.Data;
using Microsoft.AspNetCore.Hosting;
using ICT13580024B3.Api.Models;

namespace ICT13580024B3.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Product")]
    public class ProductController : Controller
    {
        MyDbContext db;
        IHostingEnvironment env;

        public ProductController(MyDbContext db, IHostingEnvironment env)
        {
            this.db = db;
            this.env = env;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return db.Products;
        }

    }
}