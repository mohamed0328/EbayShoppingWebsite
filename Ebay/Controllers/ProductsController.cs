using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ebay.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace Ebay.Controllers
{
    public class ProductsController : Controller

    {
        private EbayDbContext db;
        public ProductsController(EbayDbContext ebayDb)
        {
            db = ebayDb;
        }

        public IActionResult Index()
        {
            var products = db.products.Include(x => x.Orders).ToList();

            return View(products);

        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product, IFormFile productImage)
        {
            if (ModelState.IsValid)
            {
                if (productImage != null);

                {
                    using (var imageBytes = new MemoryStream())
                    {
                        productImage.CopyTo(imageBytes);
                        product.Image = imageBytes.ToArray();
                    }  
                }
               
                db.products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");

            }

            return View(product);
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var product = db.products.Find(Id);
            if (product ==null)
            {
                return RedirectToAction("Error");

            }
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product, IFormFile productImage)
        {
            if (ModelState.IsValid)
            {
                if (productImage != null)
                {
                    using (var imageBytes = new MemoryStream())
                    {
                        productImage.CopyTo(imageBytes);
                        product.Image = imageBytes.ToArray();
                    }
                }
                db.products.Update(product);
                db.SaveChanges();


                return RedirectToAction("Index");

            }

            return View(product);
        }

       
        public IActionResult Error()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Details(int Id)
        {
            var product = db.products.Include(x => x.Orders).FirstOrDefault(p => p.Id == Id);
            if (product == null)
            {
                return RedirectToAction("Error");

            }
            return View(product);
        }


        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var product = db.products.Find(Id);
            if (product == null)
            {
                return RedirectToAction("Error");

            }
            db.products.Remove(product);
            db.SaveChanges();

            return RedirectToAction("Index");
        }




    }
}