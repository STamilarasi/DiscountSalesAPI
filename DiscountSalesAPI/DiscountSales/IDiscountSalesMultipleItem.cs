﻿using DiscountSalesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscountSalesAPI.DiscountSales
{
    public interface IDiscountSalesMultipleItem
    {
        public Product CalculateDiscounts(TypeInfo typeInfo, DiscountSalesModel discountSalesModel, Product product);
    }
}
