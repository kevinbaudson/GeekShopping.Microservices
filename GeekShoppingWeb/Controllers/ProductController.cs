using GeekShoppingWeb.Models;
using GeekShoppingWeb.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace GeekShoppingWeb.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService
                ?? throw new ArgumentNullException(nameof(productService));
        }

        public async Task<IActionResult> ProductIndex(string search)
        {
            var products = await _productService.FindAllProducts();

            if (!string.IsNullOrEmpty(search))
            {
                products = products
                    .Where(p => p.Name.Contains(search, StringComparison.OrdinalIgnoreCase));
            }

            ViewBag.Search = search;

            return View(products);
        }

        #region Create Product
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateProduct(ProductModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            await _productService.CreateProduct(model);
            TempData["Success"] = "Produto criado com sucesso!";

            return RedirectToAction(nameof(ProductIndex));
        }
        #endregion

        #region Edit Product
        public async Task<IActionResult> EditProduct(long id)
        {
            var product = await _productService.FindProductById(id);
            if (product == null)
                return NotFound();
            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProduct(ProductModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            await _productService.UpdateProduct(model);

            TempData["Success"] = "Produto atualizado com sucesso!";

            return RedirectToAction(nameof(ProductIndex));
        }
        #endregion

        #region Delete Product
        public async Task<IActionResult> DeleteProduct(long id)
        {
            await _productService.DeleteProductById(id);

            TempData["Success"] = "Produto removido com sucesso!";

            return RedirectToAction(nameof(ProductIndex));
        }
        #endregion 
    }
}
