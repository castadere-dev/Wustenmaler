using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WustenMaler.Front.Front.ViewComponents
{

    [ViewComponent(Name = "Bilder")]
    public class BilderViewComponent : ViewComponent
    {

        public BilderViewComponent()
        {

        }


        public async Task<IViewComponentResult> InvokeAsync(string param)
        {
            List<string> categories = new List<string>() {
                    "Category 1", "Category 2", "Category 3", "Category 4", "Category 5"
                };

            return View("~/Views/Shared/Components/Bilder/Default.cshtml", categories);

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

