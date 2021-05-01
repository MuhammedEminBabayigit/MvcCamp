using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> List()
        {
            return _categoryDal.List();
        }
       
            
        //GenericRepository<Category> repo = new GenericRepository<Category>();

        //public List<Category> GetAll()
        //{
        //    return repo.List();
        //}

        //public void CategoryAdd(Category p)
        //{
        //    //if (p.CategoryName == " " || p.CategoryName.Length <= 3)
        //    //{
        //    //    //Hata mesajı
        //    //}
        //    //else
        //    //{
        //        repo.Insert(p);
        //    //}
        //}
    }
}
