using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrganicAtelier.BLL;
using OrganicAtelier.BLL.Abstract;
using OrganicAtelier.BLL.DTOs.ProductDTO;
using OrganicAtelier.Entity;
using OrganicAtelier.WEBUI.Models;

namespace OrganicAtelier.WEBUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IProductDetailService _productDetailService;
        private readonly IProductTypeService _productTypeService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IProductDetailService productDetailService, IProductTypeService productTypeService, IMapper mapper)
        {
            _productService = productService;
            _productDetailService = productDetailService;
            _productTypeService = productTypeService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View(_mapper.Map<List<ResultProductDTO>>(_productService.GetAll()));
        }

        public IActionResult Create()
        {
            ViewBag.ProductTypes= _productTypeService.GetAll();
            return View(new CreateProductDTO());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateProductDTO dto, IFormFile file)
        {
            if (file == null)
            {
                ViewBag.ProductTypes = _productTypeService.GetAll();
                ModelState.AddModelError("", "Ürün resmi yüklenmedi.");     
                return View(dto);
            }
            dto.Image = await ImageMethods.UploadImage(file);

            ModelState.Remove("Image");
            if (ModelState.IsValid)
            {                
                if (dto.Image == null)
                {
                    ModelState.AddModelError("", "Resim yükleme işlemi başarısız oldu.");
                    return View(dto);
                }

                dto.Status = true;

                var product = _mapper.Map<Product>(dto);
                _productService.Create(product);

                return RedirectToAction("Index");
            }

            ViewBag.ProductTypes = _productTypeService.GetAll();
            return View(dto);
        }

        public IActionResult Edit(int id)
        {
            if (id < 1)
            {
                ErrorViewModel error = new ErrorViewModel()
                {
                    Code = 102,
                    Title = "Ürün Bulunamadı",
                    Description = "Lütfen varolan bir ürün seçiniz.",
                    ReturnUrl = "/Product/Index",
                    Css = "text-danger"
                };
                return View("Error", error);
            }

            var product = _productService.GetById(id);
			ViewBag.ProductTypes = _productTypeService.GetAll();

			if (product == null)
            {
                ErrorViewModel error = new ErrorViewModel()
                {
                    Code = 102,
                    Title = "Ürün Bulunamadı",
                    Description = "Lütfen varolan bir ürün seçiniz.",
                    ReturnUrl = "/Product/Index",
                    Css = "text-danger"
                };
                return View("Error", error);
            }

            var model = _mapper.Map<UpdateProductDTO>(product);          
            ViewBag.ProductTypes = _productTypeService.GetAll();

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(UpdateProductDTO dto, IFormFile file)
        {
            ModelState.Remove("file");
            if (ModelState.IsValid)
            {
                var product = _productService.GetById(dto.Id);

                if (product == null)
                {
                    ErrorViewModel error = new ErrorViewModel()
                    {
                        Code = 102,
                        Title = "İlan Bulunamadı",
                        Description = "Lütfen varolan bir ürün seçiniz.",
                        ReturnUrl = "/Product/Index",
                        Css = "text-danger"
                    };
                    return View("Error", error);
                }

                if (file != null)
                {
                    ImageMethods.DeleteImage(product.Image);
                    dto.Image = await ImageMethods.UploadImage(file);					
				}               


                _productService.Update(_mapper.Map<Product>(dto));
                return RedirectToAction("Index");
            }

            ViewBag.ProductTypes = _productTypeService.GetAll();

            return View(dto);
        }

        public IActionResult Delete(int id)
        {
            var product = _productService.GetById(id);

            if (product == null)
            {
                ErrorViewModel error = new ErrorViewModel()
                {
                    Code = 102,
                    Title = "İlan Bulunamadı",
                    Description = "Lütfen varolan bir ilanı seçiniz.",
                    ReturnUrl = "/Product/Index",
                    Css = "text-danger"
                };
                return View("Error", error);
            }

            _productService.Delete(product);
            ImageMethods.DeleteImage(product.Image);
            return RedirectToAction("Index");
        }

        public IActionResult StatusChange(int id)
        {
            var product = _productService.GetById(id);

            product.Status = product.Status == true ? false : true;

            _productService.Update(product);

            return RedirectToAction("Index");
        }
    }
}
