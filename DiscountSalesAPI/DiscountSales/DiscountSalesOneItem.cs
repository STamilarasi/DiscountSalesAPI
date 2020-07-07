using DiscountSalesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscountSalesAPI.DiscountSales
{
    public class DiscountSalesOneItem : IDiscountSalesOneItem
    {
        public Product CalculateDiscounts(TypeInfo typeInfo, DiscountSalesModel discountSalesModel, Product product)
        {
            Product  prod = new Product();
            if (typeInfo  ==  TypeInfo.OneItem)
            {
                
            }
            return prod;
        }
    }
}
