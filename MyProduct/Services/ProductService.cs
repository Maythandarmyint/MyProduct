using MyProduct.DAL;
using MyProduct.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace MyProduct.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository<Product> repoProduct;
        private IProductRepository<Category> repoCategory;
        private IProductRepository<SubCategory> repoSubCategory;

        public ProductService(IProductRepository<Product> repoProduct,
            IProductRepository<Category> repoCategory,
            IProductRepository<SubCategory> repoSubCategory)
        {
            this.repoProduct = repoProduct;
            this.repoCategory = repoCategory;
            this.repoSubCategory = repoSubCategory;
        }


        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            try
            {
                products = repoProduct.GetAll().ToList();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message + "\n" + e.StackTrace);
            }
            return products;
        }

        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            try
            {
                categories = repoCategory.GetAll().ToList();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message + "\n" + e.StackTrace);
            }
            return categories;
        }

        public List<SubCategory> GetSubCategories()
        {
            List<SubCategory> subcategories = new List<SubCategory>();
            try
            {
                subcategories = repoSubCategory.GetAll().ToList();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message + "\n" + e.StackTrace);
            }
            return subcategories;
        }

        public List<SubCategory> GetSubCategoriesByCategory(int categoryid)
        {
            List<SubCategory> subcategories = new List<SubCategory>();
            try
            {
                subcategories = repoSubCategory.GetAll().ToList();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message + "\n" + e.StackTrace);
            }
            return subcategories;
        }
    }
}