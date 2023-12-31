﻿using DataAccess.Abstract;
using Entities;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSaleDal : IEntityRepositoryBase<Sale, StokTakipContext>, ISaleDal
    {
        public List<SalesDetailsDto> GetSalesDetails(Expression<Func<SalesDetailsDto, bool>> filter = null)
        {
            using (StokTakipContext context = new StokTakipContext())
            {
                var query = from sale in context.Sales
                            join product in context.Products on sale.ProductId equals product.ProductId
                            join customer in context.Customers on sale.CustomerID equals customer.CustomerId
                            select new SalesDetailsDto
                            {
                                SaleId = sale.SaleID,
                                ProductName = product.ProductName,
                                CustomerName = customer.CustomerName,
                                CompanyName = customer.CompanyName,
                                Quantity = sale.Quantity,
                                Date = sale.Date
                            };

                if (filter != null)
                {
                    query = query.Where(filter);
                }

                return query.ToList();
            }
        }
    }
}
