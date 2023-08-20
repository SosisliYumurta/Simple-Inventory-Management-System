using Business.Abstract;
using Business.Utilities;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public void Add(Customer customer)
        {
            ValidationTool.Validate(new CustomerValidator(), customer);
            _customerDal.Add(customer);
        }

        public void Delete(Customer customer)
        {
            _customerDal.Delete(customer);
        }

        public Customer Get(int id)
        {
            return _customerDal.Get(c =>c.CustomerId == id);
        }

        public void Update(Customer customer)
        {
            ValidationTool.Validate(new CustomerValidator(), customer);
            _customerDal.Update(customer);
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }
    }
}
