using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscountSalesAPI.Models
{
  
    public class DiscountSalesModel
    {
        [JsonProperty("Id")]
        public string Identifier { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Product")]
        public Dictionary<string, string> ProductInfo { get; set; }

        [JsonProperty("Operation")]
        public Dictionary<string, string> OperationInfo { get; set; }

        [JsonProperty("Quantity")]
        public Dictionary<string, int> QuantityInfo { get; set; }

        [JsonProperty("Cost")]
        public Dictionary<string, int> CostInfo { get; set; }

    }


    public class Discounts
    {
        public DiscountSalesModel[] DiscountModel { get; set; }
    }

    public enum Type
    {
        OneItem = 0,
        MultipleItems = 1       
    }
}
