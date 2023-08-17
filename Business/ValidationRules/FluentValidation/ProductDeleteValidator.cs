using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductDeleteValidator : AbstractValidator<Product>
    {
        public ProductDeleteValidator()
        {
            RuleFor(p => p.ProductId).NotEmpty().WithMessage("Silinecek Ürün bulunamadı veya bir ürün seçmediniz");
        }
    }
}
