using BussinessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class CategoryManager : ICategorySevice
    {
        CategoryRepository categoryRepository = new CategoryRepository();

        public void CategoryAdd(Category category)
        {

            categoryRepository.AddCategory(category);
        }

        public void CategoryDelete(Category category)
        {
            throw new NotImplementedException();
        }

        public void CategoryUpdate(Category category)
        {
            throw new NotImplementedException();
        }

        public Category GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
