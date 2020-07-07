using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DiscountSalesAPI.Controllers
{
    [ApiController]    
    [Route("Discounts/DiscountSales")]
    //[Route("api/[controller]")]
    public class DiscountSalesController : ControllerBase
    {
       

        // POST: api/DiscountSales
        [HttpPost]
        [Route("ApplyDiscount")]
        public void Post([FromBody] string value)
        {


        }

       
    }
}
