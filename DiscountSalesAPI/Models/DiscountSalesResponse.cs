﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscountSalesAPI.Models
{
    public class DiscountSalesResponse
    {
        public List<Product> CartOrder { get; set; }
    }   

    public class Product
    {
        public string Id { get; set; }
        public int Quantity { get; set; }
        public double ProductCost { get; set; }
        public double TotalCost { get; set; }        
    }

    public class AfterDiscount
    {
        public List<Product> ProcessedCartOrder { get; set; }
    }
}
