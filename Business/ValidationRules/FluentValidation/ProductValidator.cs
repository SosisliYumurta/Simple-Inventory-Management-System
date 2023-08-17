using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.CategoryId).NotEmpty();
            RuleFor(p => p.StockQuantity).NotEmpty();
            RuleFor(p => p).Must(MinusStockquantity).WithMessage("Yeterli stok yok");
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.DateAdded).NotEmpty();

        }
        
        private bool MinusStockquantity(Product product)
        {
            return product.StockQuantity >= 0;
        }
    }
}
