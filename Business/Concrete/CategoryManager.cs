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
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;   
        }
        public void Add(Category category)
        {
            ValidationTool.Validate(new CategoryValidator(), category);
             _categoryDal.Add(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }
        public void Update(Category category)
        {
            ValidationTool.Validate(new CategoryValidator(), category);
            _categoryDal.Update(category);
        }

        List<Category> ICategoryService.GetAll()
        {
            return _categoryDal.GetAll();
        }

        Category ICategoryService.Get(int id)
        {
            throw new NotImplementedException();
        }


    }
}
