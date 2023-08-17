using Business.Abstract;
using Business.Utilities;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    internal class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void Add(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll().ToList();
        }

        public List<ProductDetailDto> GetProdcutsDetailsByProductName(string productName)
        {
            return _productDal.GetProductDetails(p => p.ProductName.ToLower().Contains(productName)).ToList();
        }

        public Product GetProduct(int id)
        {
            return _productDal.Get(p => p.ProductId == id);
        }

        public List<ProductDetailDto> GetProductDetail()
        {
            return _productDal.GetProductDetails();
        }

        public List<ProductDetailDto> GetProductsDetailsByCategoryName(string categoryName)
        {
            return _productDal.GetProductDetails(p => p.CategoryName == categoryName).ToList();
        }

        public void Update(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Update(product);
        }

    }
}
