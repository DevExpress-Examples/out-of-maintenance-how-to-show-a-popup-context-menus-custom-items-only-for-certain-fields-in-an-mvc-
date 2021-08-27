<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128579485/16.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T431251)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/MvcApplication1/Controllers/HomeController.cs)
* [PivotEventHelper.cs](./CS/MvcApplication1/Helper/PivotEventHelper.cs)
* [pivotMenu.js](./CS/MvcApplication1/Scripts/pivotMenu.js)
* [_PivotGridPartial.cshtml](./CS/MvcApplication1/Views/Home/_PivotGridPartial.cshtml)
* [Index.cshtml](./CS/MvcApplication1/Views/Home/Index.cshtml)
<!-- default file list end -->
# How to show a popup context menu's custom items only for certain fields in an MVC solution
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t431251/)**
<!-- run online end -->

This example demonstrates how to hide certain context menu items using the client-side [PopUp](https://docs.devexpress.com/AspNet/js-ASPxClientMenuBase.PopUp) and [CloseUp](https://docs.devexpress.com/AspNet/js-ASPxClientMenuBase.CloseUp) events. It is possible to use the [PivotGridSettings.CustomJsProperties](https://docs.devexpress.com/AspNetMvc/DevExpress.Web.Mvc.PivotGridSettings.CustomJsProperties) action to pass additional information for client side processing. To get the ID of a target [Field Value](https://docs.devexpress.com/AspNet/3597/components/pivot-grid/ui-elements/field-value) item use the **pivotGrid.fieldMenuFieldID** property. If the [Header](https://docs.devexpress.com/AspNet/3586/components/pivot-grid/ui-elements/filter-header-area) menu is shown, you can get the ID using the **pivotGrid.headerMenuFieldID** property.

**See also:** [How to show custom popup context menu items only for certain fields](https://supportcenter.devexpress.com/ticket/details/e3909/how-to-show-custom-popup-context-menu-items-only-for-certain-fields).
