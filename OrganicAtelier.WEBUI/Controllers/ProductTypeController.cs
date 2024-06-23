using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrganicAtelier.BLL.Abstract;
using OrganicAtelier.BLL.DTOs.ProductTypeDTO;
using OrganicAtelier.Entity;
using OrganicAtelier.WEBUI.Models;

namespace OrganicAtelier.WEBUI.Controllers
{

    public class ProductTypeController : Controller
    {
        private readonly IProductTypeService _productTypeService;
        private readonly IMapper _mapper;

        public ProductTypeController(IProductTypeService productTypeService, IMapper mapper)
        {
            _productTypeService = productTypeService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var productTypes = _productTypeService.GetAll();
            var models = _mapper.Map<List<ResultProductTypeDTO>>(productTypes);
            return View(models);
        }

        public IActionResult Create()
        {
            return View(new CreateProductTypeDTO());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateProductTypeDTO dto)
        {
           
            if (ModelState.IsValid)
            {
                var productType = _productTypeService.GetOne(i => i.Name == dto.Name);

                if (productType != null)
                {
                    ErrorViewModel error = new ErrorViewModel()
                    {
                        Code = 101,
                        Title = "Kayıt Hatası",
                        Description = "Aynı isimde kayıtlı bir ürün türü vardır. Lütfen farklı isim girişi yapınız.",
                        ReturnUrl = "/ProductType/Index",
                        Css = "text-warning"
                    };
                    return View("Error", error);
                }
                _productTypeService.Create(_mapper.Map<ProductType>(dto));
                return RedirectToAction("Index");
            }

            return View(dto);
        }

        public IActionResult Edit(int id)
        {
            var productType = _productTypeService.GetById(id);

            if (productType == null)
            {
                ErrorViewModel error = new ErrorViewModel()
                {
                    Code = 404,
                    Title = "Ürün Türü Bulunamadı",
                    Description = "Lütfen seçiminizi kontrol ediniz.",
                    ReturnUrl = "/ProductType/Index",
                    Css = "text-danger"
                };
                return View("Error", error);
            }

            return View(_mapper.Map<UpdateProductTypeDTO>(productType));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(UpdateProductTypeDTO dto)
        {

            if (ModelState.IsValid)
            {               
                _productTypeService.Update(_mapper.Map<ProductType>(dto));
                return RedirectToAction("Index");

            }
            return View(dto);
        }

        public IActionResult Delete(int id)
        {
            var productType = _productTypeService.GetById(id);

            if (productType == null)
            {
                ErrorViewModel error = new ErrorViewModel()
                {
                    Code = 404,
                    Title = "Ürün Türü Bulunamadı",
                    Description = "Lütfen seçiminizi kontrol ediniz.",
                    ReturnUrl = "/ProductType/Index",
                    Css = "text-danger"
                };
                return View("Error", error);
            }

            _productTypeService.Delete(productType);
            return RedirectToAction("Index");
        }
    }
}