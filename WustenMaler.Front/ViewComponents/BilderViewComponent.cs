using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace WustenMaler.ViewComponents
{
   
    namespace LearnASPNETCoreMVC5.ViewComponents
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

                return View("Index", categories);

                //return View("~/Plugins/Nettec.Plugin.Misc.Checkout/Views/Shared/Components/LandingPageConversion/Default.cshtml", modelView);

            }

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
    //        _cacheManager = cacheManager;
    //        _storeContext = storeContext;
    //        _productService = productService;
    //        _groupedCartService = groupedCartService;
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

        //        if (productInfoModel != null && productInfoModel.Product != null)
        //        {
        //            if (string.Equals(productInfoModel.ProductInfo.ProductArticleType, "tyre", System.StringComparison.CurrentCultureIgnoreCase))
        //            {
        //                //Tyre Product
        //                orderDetail = new OrderItemValue
        //                {
        //                    ManufacturerName = productInfoModel.ProductInfo.ManufacturerName,
        //                    Name = productInfoModel.ProductInfo.Name,
        //                    Info = productInfoModel.Info,
        //                    Info2 = productInfoModel.Info2,
        //                    ProductImageUrl = productInfoModel.PictureSet.ProductImageUrl,
        //                    ArticleType = productInfoModel.ProductInfo.ProductArticleType,
        //                    ProductId = productInfoModel.ProductInfo.ProductId,
        //                    ManufacturerImageUrl = productInfoModel.PictureSet.ManufacturerImageUrl
        //                };

        //                tyreListOrder.Add(orderDetail);
        //            }
        //            else if (string.Equals(productInfoModel.ProductInfo.ProductArticleType, "rim", System.StringComparison.CurrentCultureIgnoreCase))
        //            {
        //                //Rim product
        //                orderDetail = new OrderItemValue
        //                {
        //                    ManufacturerName = productInfoModel.ProductInfo.ManufacturerName,
        //                    Name = productInfoModel.ProductInfo.Name,
        //                    Info = productInfoModel.Info,
        //                    Info2 = productInfoModel.Info2,
        //                    ProductImageUrl = productInfoModel.PictureSet.ProductImageUrl,
        //                    ArticleType = productInfoModel.ProductInfo.ProductArticleType,
        //                    ProductId = productInfoModel.ProductInfo.ProductId,
        //                    ManufacturerImageUrl = productInfoModel.PictureSet.ManufacturerImageUrl
        //                };

        //                rimListOrder.Add(orderDetail);
        //            }
        //        }
        //    }

        //    //Instanze Conversion model
        //    var modelView = new LandingPageConversionModel();
        //    if (modelValue != null)
        //    {
        //        //set Order list
        //        modelView.OrderItemList = modelValue.OrderItemList;
        //        modelView.TyreItemList = tyreListOrder;
        //        modelView.RimItemList = rimListOrder;

        //        //Set value
        //        modelView.VoucherNumber = modelValue.CustomOrderNumber;
        //        modelView.ProcessIdentifier = modelValue.ProcessGuid;
        //        modelView.IsAccepted = true;
        //        modelView.DateNew = modelValue.CreatedOnUtc;
        //        modelView.VehicleName = modelValue.VehicleName;
        //        modelView.EmailHistoryId = modelValue.EmailHistoryId;
        //    }

        //    //set vehicle complet info
        //    modelView.VehiclesExtended.Add(GetVehicleInfoModel(modelValue.Id));

