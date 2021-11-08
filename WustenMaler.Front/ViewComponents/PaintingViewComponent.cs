using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WustenMaler.Front.Interfaces;
using WustenMaler.Front.Services;

namespace WustenMaler.Front.ViewComponents
{
    [ViewComponent(Name = "Painting")]
    public class PaintingViewComponent : ViewComponent
    {

        private readonly IPaintingService _paintingService;

        public PaintingViewComponent(IPaintingService paintingService)
        {
            _paintingService = paintingService;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {

            //var valModel =  _bookService.MostPopular(numberToTake);

            return View();

            //return View("/Views/Shared/Components/Bilder/Default.cshtml", categories);

        }

    }
}



//[ViewComponent(Name = "LandingPageConversion")]
//public class LandingPageConversionViewComponent : NopViewComponent
//{
//    private readonly IProductService _productService;
//    private readonly IGroupedCartService _groupedCartService;
//    private readonly IGenericAttributeService _genericAttributeService;

//    public LandingPageConversionViewComponent(
//                                            IGroupedCartService groupedCartService,
//                                            IGenericAttributeService genericAttributeService)
//    {
//        _workContext = workContext;
//        _settingService = settingService;
//        _genericAttributeService = genericAttributeService;
//    }


/// <summary>
/// Constructor of Landing Page Conversion (Umbau) 
/// </summary>
/// <param name="modelValue">Landingpage Conversion</param>
/// <returns></returns>
//public IViewComponentResult Invoke(LandingPageModel modelValue)
//{
//    List<OrderItemValue> tyreListOrder = new List<OrderItemValue>();
//    List<OrderItemValue> rimListOrder = new List<OrderItemValue>();

//    foreach (var itemOrder in modelValue.OrderItemList)
//    {
//        OrderItemValue orderDetail = new OrderItemValue();
//        //get product info
//        var productInfoModel = Nettec.Services.MemoryMap.ProductTree.GetGenericData(itemOrder.ProductId);
//                rimListOrder.Add(orderDetail);
//    }

//    //Instanze Conversion model
//    var modelView = new LandingPageConversionModel();
//    if (modelValue != null)
//    {
//        //set Order list
//        modelView.OrderItemList = modelValue.OrderItemList;
//        modelView.RimItemList = rimListOrder;
//    }

//    //set vehicle complet info
//    modelView.VehiclesExtended.Add(GetVehicleInfoModel(modelValue.Id));

