using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiscountSalesAPI.Handlers;
using DiscountSalesAPI.Models;
//using log4net.Core;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace DiscountSalesAPI.Controllers
{
    [ApiController]
    [Route("Discounts/DiscountSales")]
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
        [Route("ApplyDiscountForItems")]
        public async Task<ActionResult> Post([FromBody] DiscountSalesModel discountSalesModel)
        {
            try
            {
                _logger.LogInformation("Discount Sales Started.");

                var req = JsonConvert.DeserializeObject<DiscountSalesResponse>(discountSalesModel.ToString());
                if (!(req.Order.Any()))
                {
                    return StatusCode(404, "No item is there to Apply Discount.");
                }

                var result = await _mediator.Send(new Requ
                {
                    Response = req
                });

                return Ok(result);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}
