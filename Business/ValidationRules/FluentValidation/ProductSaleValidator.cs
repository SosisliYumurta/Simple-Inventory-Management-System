using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductSaleValidator : AbstractValidator<Sale>
    {
        public ProductSaleValidator()
        {
            RuleFor(p=>p.ProductId).NotEmpty();
            RuleFor(p=>p.CustomerID).NotEmpty();
            RuleFor(p => p.Quantity).NotEmpty();
            RuleFor(p => p.Quantity).GreaterThan(0).WithMessage("Verilen Miktar 0 Olamaz");
            RuleFor(p => p.Date).NotEmpty();

            RuleFor(p => p).Must(MinusStock).WithMessage("Yeterli Stok Yok!");


        }

        private bool MinusStock(Sale sale)
        {
            return sale.Quantity >= 0;
        }
    }
}
