using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mystore.Data.Interfaces;
using mystore.ViewModels;

namespace mystore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IProductRepository _productRepository;

        public HomeController(ICategoryRepository categoryRepository, IProductRepository productRepository)
        {
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
        }

        public ViewResult List()
        {
            ProductListViewModel vm = new ProductListViewModel();
            vm.Products = _productRepository.Products;
            vm.CurrentCategory = "Current Category";
            return View (vm);
        }
        
    }
}