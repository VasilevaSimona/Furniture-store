using EShop.Domain.DomainModels.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.Services.Interface
{
    public interface IShoppingCartService
    {
        ShoppingCartDto getShoppingCartInfo(string userId);
        bool DeleteProductFromShoppingCart(string userId, Guid id);
        bool OrderNow(string userId);
    }
}
