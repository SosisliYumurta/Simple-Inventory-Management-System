using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IEntityRepositoryBase<Product, StokTakipContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails(Expression<Func<ProductDetailDto, bool>> filter = null)
        {
            using (StokTakipContext context = new StokTakipContext())
            {

                if (filter == null)
                {
                    var result = from p in context.Products
                                 join c in context.Categories
                                 on p.CategoryId equals c.CategoryId
                                 select new ProductDetailDto
                                 {
                                     ProductId = p.ProductId,
                                     ProductName = p.ProductName,
                                     CategoryName = c.CategoryName,
                                     StockQuantity = p.StockQuantity,
                                     UnitPrice = p.UnitPrice,
                                     DateAdded = p.DateAdded,
                                     
                                 };
                    return result.ToList();
                }
                var resultWithFilter = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                                 StockQuantity = p.StockQuantity,
                                 UnitPrice = p.UnitPrice,
                                 DateAdded = p.DateAdded,
                                 
                             };
                return resultWithFilter.Where(filter).ToList();
            }
        }

        public List<ProductInventoryDto> GetProductInventories()
        {
            using (StokTakipContext context = new StokTakipContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductInventoryDto
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 StockQuantity = p.StockQuantity,
                                 
                             };
                return result.ToList();
            }
        }
    }
}
