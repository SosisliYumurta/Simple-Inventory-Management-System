using DataAccess.Abstract;
using Entities;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IEntityRepositoryBase<Product, StokTakipContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails(Expression<Func<ProductDetailDto, bool>> filter = null)
        {
            using (StokTakipContext context = new StokTakipContext())
            {
                var query = from p in context.Products
                            join c in context.Categories on p.CategoryId equals c.CategoryId
                            select new ProductDetailDto
                            {
                                ProductId = p.ProductId,
                                ProductName = p.ProductName,
                                CategoryName = c.CategoryName,
                                StockQuantity = p.StockQuantity,
                                UnitPrice = p.UnitPrice,
                                TotalPrice = p.UnitPrice * p.StockQuantity,
                                DateAdded = p.DateAdded
                            };

                if (filter != null)
                {
                    query = query.Where(filter);
                }

                return query.ToList();
            }
        }

        public List<ProductInventoryDto> GetProductInventories()
        {
            using (StokTakipContext context = new StokTakipContext())
            {
                var query = from p in context.Products
                            join c in context.Categories on p.CategoryId equals c.CategoryId
                            select new ProductInventoryDto
                            {
                                ProductId = p.ProductId,
                                ProductName = p.ProductName,
                                StockQuantity = p.StockQuantity
                            };

                return query.ToList();
            }
        }
    }
}
