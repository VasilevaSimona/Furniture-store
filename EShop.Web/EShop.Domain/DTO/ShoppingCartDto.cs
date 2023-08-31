using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace  EShop.Domain.DomainModels.DTO
{
    public class ShoppingCartDto
    {
        public List<ProductInShoppingCart> Products { get; set; }
        public double TotalPrice { get; set; }
    }
}
