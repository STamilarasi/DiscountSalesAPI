using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiscountSalesAPI.Models;
using log4net.Core;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DiscountSalesAPI.Controllers
{
    [ApiController]    
    [Route("Discounts/DiscountSales")]
    //[Route("api/[controller]")]
    public class DiscountSalesController : ControllerBase
    {

        private readonly IMediator _mediator;
        private readonly ILogger _logger;

        public DiscountSalesController(ILogger logger, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        // POST: api/DiscountSales
        [HttpPost]
        [Route("ApplyDiscount")]
        public async Task<ActionResult> Post([FromBody] DiscountSalesModel discountSalesModel)
        {

            try
            {
                //return await _mediator.Send(new DiscountSalesCommand { 

                
                //});
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

       
    }
}
