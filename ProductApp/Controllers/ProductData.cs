using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductApp.Models;

namespace ProductApp.Controllers
{
    public class ProductData : Controller
    {
        private readonly Models.ApplicationDb _context;
        public ProductData(Models.ApplicationDb context)
        {
            _context = context;
        }
        public async Task<ActionResult> Index()
        {

            var products = await _context.Product.ToListAsync();
            return View(products);
        }
        public async Task<ActionResult> ProductList()
        {
          var products = await _context.Product.ToListAsync();
            return View(products);
        }
        public IActionResult create() 
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult create(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                _context.SaveChanges();
                TempData["Message"] = "Product created successfully!";
                return RedirectToAction("Index");
            }
            return View(product);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Update(product);
                await _context.SaveChangesAsync();
                TempData["Message"] = "Product updated successfully!";
                return RedirectToAction("Index");
            }
            return View(product);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Product.FindAsync(id);
            if (product != null)
            {
                _context.Product.Remove(product);
                await _context.SaveChangesAsync();
                TempData["Message"] = "Product deleted successfully!";
            }
            return RedirectToAction("Index");
        }
    }
}
