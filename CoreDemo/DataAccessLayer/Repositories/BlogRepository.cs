using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {



        //public void AddBlog(Blog blog)
        //{
        //    using var c = new Context();
        //    c.Add(blog);
        //    c.SaveChanges();
        //}

        //public void DeleteBlog(Blog blog)
        //{
        //    using var c = new Context();
        //    c.Remove(blog);
        //    c.SaveChanges();
        //}

        //public Blog GetById(int id)
        //{
        //    using var c = new Context();
        //    return c.Blogs.Find(id);
        //}

        //public List<Blog> ListAllBlog()
        //{
        //    using var c = new Context();
        //    return c.Blogs.ToList();
        //}

        //public void UpdateBlog(Blog blog)
        //{
        //    using var c = new Context();
        //    c.Update(blog);
        //    c.SaveChanges();
        //}

        Context c = new Context();
        public void Delete(Blog blog)
        {
            c.Remove(blog);
            c.SaveChanges();
        }

        public Blog GetById(int id)
        {
            return c.Blogs.Find(id);
        }

        public List<Blog> GetListAll()
        {
            return c.Blogs.ToList();
        }

        public void Insert(Blog blog)
        {
            c.Add(blog);
            c.SaveChanges();
        }

        public void Update(Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}
