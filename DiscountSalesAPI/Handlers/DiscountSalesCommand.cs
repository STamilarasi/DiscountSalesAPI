using DiscountSalesAPI.DiscountSales;
using DiscountSalesAPI.Models;
using MediatR;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DiscountSalesAPI.Handlers
{
    public class DiscountSalesCommand : IRequestHandler<Requ, AfterDiscount>
    {
        
        private  IDiscountSalesOneItem _discount;
        private readonly ILogger _logger;

        public DiscountSalesCommand(IDiscountSalesOneItem discountSales, ILogger logger)
        {            
            _discount = discountSales;
            _logger = logger;
        }

        public async  Task<AfterDiscount> Handle(Requ request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Started to calculate the discount of the products.");
            try
            {
                //Read from the JSON file
               var discountSalesModel = JsonConvert.DeserializeObject<Discounts>(JsonConvert.SerializeObject(
               JObject.Parse(File.ReadAllText("Discount.json")),Formatting.Indented));

                foreach(var discount in discountSalesModel.DiscountModel)
                {
                    if(discount.Type == TypeInfo.OneItem.ToString())
                    {
                        _discount = new DiscountSalesOneItem();


                    }

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }


    public class Requ : IRequest<AfterDiscount>
    {
        public DiscountSalesResponse Response { get; set; }
    }
}
