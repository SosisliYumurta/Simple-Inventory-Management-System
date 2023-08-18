using Entities;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        List<Product> GetAll();
        Product GetProduct(int id);
        List<ProductDetailDto> GetProductDetail();
        List<ProductDetailDto> GetProdcutsDetailsByProductName(string productName);
        List<ProductDetailDto> GetProductsDetailsByCategoryName(string categoryName);
        List<ProductInventoryDto> productInventories();


    }
}
