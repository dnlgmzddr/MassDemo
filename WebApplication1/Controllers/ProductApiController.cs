using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    //[RoutePrefix("api/products")]
    public class ProductsController :ApiController
    {
        [HttpGet]
        //[Route("")]
        public List<Product> All()
        {
            return new MassContext().Products.ToList();
        }

    }
}