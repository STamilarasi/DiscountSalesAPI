using DiscountSalesAPI.DiscountSales;
using DiscountSalesAPI.Models;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DiscountSalesAPI.Handlers
{
    public class DiscountSalesCommand : IRequestHandler<Requ, AfterDiscount>
    {
        
        private readonly IDiscountSales _discount;
        private readonly ILogger _logger;

        public DiscountSalesCommand(IDiscountSales discountSales, ILogger logger)
        {            
            _discount = discountSales;
            _logger = logger;
        }

        public async  Task<AfterDiscount> Handle(Requ request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Started to calculate the discount of the products.");
            try
            {

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }


    public class Requ : IRequest<AfterDiscount>
    {
        public DiscountSalesResponse CartOrderContratContract { get; set; }
    }
}
