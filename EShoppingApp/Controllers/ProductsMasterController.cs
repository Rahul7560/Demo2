using EShoppingApp.Models;
using EShoppingEntity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShoppingApp.Controllers
{
    public class ProductsMasterController : Controller
    {
        private readonly IProductMasterRepository _productMasterRepository;

        public ProductsMasterController(IProductMasterRepository productMasterRepository)
        {
            _productMasterRepository = productMasterRepository;
        }
        // GET: ProductsMasterController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProductsMasterController/Details/5
        public ActionResult ProductDetails(int id)
        {
            return View();
        }

        // GET: ProductsMasterController/Create
        public ActionResult AddProduct()
        {
            return View();
        }

        // POST: ProductsMasterController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddProduct(Product product)
        {
            try
            {
                _productMasterRepository.AddProduct(product);
                return Content("product added");
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsMasterController/Edit/5
        public ActionResult EditProduct(int id)
        {
            return View();
        }

        // POST: ProductsMasterController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditProduct(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsMasterController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductsMasterController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteProduct(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
