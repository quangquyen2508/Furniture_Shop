#pragma checksum "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\AdminDashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37dbb1ce022a1097cb46dbfd8e210ccbbfc10229"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AdminDashboard), @"mvc.1.0.view", @"/Views/Home/AdminDashboard.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\_ViewImports.cshtml"
using MAQFurni;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\_ViewImports.cshtml"
using MAQFurni.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37dbb1ce022a1097cb46dbfd8e210ccbbfc10229", @"/Views/Home/AdminDashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7af0d8d46e9810ccc2630830b39b78eaeba22be4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AdminDashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\AdminDashboard.cshtml"
  
    ViewData["Title"] = "Admin Dashboard";
    Layout = "_Admin";

    int listUser = ViewBag.ListUser;
    int listUserBuy = ViewBag.ListUserBuy;
    var listOrders = ViewBag.ListOrders;
    var listOrderSuccess = ViewBag.ListOrderSuccess;
    var listProduct = ViewBag.ListProduct;
    var listProductBuy = ViewBag.ListProductBuy;
    decimal totalMoney = ViewBag.TotalMoney;
    var listOdDetail = ViewBag.listOdDetail as List<OrderDetail>;
    var listTransaction = ViewBag.ListTransaction as List<Order>;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""widgets"">
        <div class=""widgets__row row gutter-bottom-xl"">
            <div class=""col-12 col-md-6 col-xl-4 d-flex"">
                <div class=""widget"">
                    <div class=""widget__wrapper"">
                        <div class=""widget__row"">
                            <div class=""widget__left"">
                                <h3 class=""widget__title"">Users</h3>
                                <div class=""widget__status-title text-grey"">Total users</div>
                                <div class=""widget__trade""><span class=""widget__trade-count"">");
#nullable restore
#line 26 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\AdminDashboard.cshtml"
                                                                                        Write(listUser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span class=\"trade-icon trade-icon--up\">\r\n");
            WriteLiteral(@"                                </div>
                                <div class=""widget__details""><a class=""link-under text-grey"" href=""/admin/users"">Detail</a>
                                </div>
                            </div>
                            <div class=""widget__chart"">
                                <div class=""widget__chart-inner"">
                                    <div class=""widget__chart-percentage"">");
#nullable restore
#line 36 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\AdminDashboard.cshtml"
                                                                      Write(Math.Ceiling((decimal)listUserBuy*100/listUser));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<small>%</small>
                                    </div>
                                    <div class=""widget__chart-caption"">Users Buy</div>
                                </div>
                                <div class=""widget__chart-canvas js-progress-circle"" data-value=""");
#nullable restore
#line 40 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\AdminDashboard.cshtml"
                                                                                             Write((decimal)listUserBuy/listUser);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" data-color=""#22CCE2""></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-12 col-md-6 col-xl-4 d-flex"">
                <div class=""widget"">
                    <div class=""widget__wrapper"">
                        <div class=""widget__row"">
                            <div class=""widget__left"">
                                <h3 class=""widget__title"">Orders</h3>
                                <div class=""widget__status-title text-grey"">Total orders</div>
                                <div class=""widget__trade""><span class=""widget__trade-count"">");
#nullable restore
#line 53 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\AdminDashboard.cshtml"
                                                                                        Write(listOrders);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span class=\"trade-icon trade-icon--down\">\r\n");
            WriteLiteral(@"                                </div>
                                <div class=""widget__details""><a class=""link-under text-grey"" href=""/admin/order"">Detail</a>
                                </div>
                            </div>
                            <div class=""widget__chart"">
                                <div class=""widget__chart-inner"">
                                    <div class=""widget__chart-percentage"">");
#nullable restore
#line 63 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\AdminDashboard.cshtml"
                                                                      Write(Math.Ceiling((decimal)listOrderSuccess*100/listOrders));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<small>%</small>
                                    </div>
                                    <div class=""widget__chart-caption"">Comp. Orders</div>
                                </div>
                                <div class=""widget__chart-canvas js-progress-circle"" data-value=""");
#nullable restore
#line 67 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\AdminDashboard.cshtml"
                                                                                             Write((decimal)listOrderSuccess/listOrders);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" data-color=""#FDBF5E""></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-12 col-md-6 col-xl-4 d-flex"">
                <div class=""widget"">
                    <div class=""widget__wrapper"">
                        <div class=""widget__row"">
                            <div class=""widget__left"">
                                <h3 class=""widget__title"">Products</h3>
                                <div class=""widget__status-title text-grey"">Total products</div>
                                <div class=""widget__trade""><span class=""widget__trade-count"">");
#nullable restore
#line 80 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\AdminDashboard.cshtml"
                                                                                        Write(listProduct);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span class=\"trade-icon trade-icon--up\">\r\n");
            WriteLiteral(@"                                </div>
                                <div class=""widget__details""><a class=""link-under text-grey"" href=""/admin/product"">Detail</a>
                                </div>
                            </div>
                            <div class=""widget__chart"">
                                <div class=""widget__chart-inner"">
                                    <div class=""widget__chart-percentage"">");
#nullable restore
#line 90 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\AdminDashboard.cshtml"
                                                                      Write(Math.Ceiling((decimal)listProductBuy*100/listProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<small>%</small>
                                    </div>
                                    <div class=""widget__chart-caption"">Purchased Product</div>
                                </div>
                                <div class=""widget__chart-canvas js-progress-circle"" data-value=""");
#nullable restore
#line 94 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\AdminDashboard.cshtml"
                                                                                             Write((decimal)listProductBuy/listProduct);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" data-color=""#FF3D57""></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <section class=""section"">
        <div class=""section__title d-none"">
            <h2>Section</h2>
        </div>
        <div class=""row gutter-bottom-xl"">
            <div class=""col-12 col-lg-7 col-xl-8 d-flex"">
                <div class=""card card--lg"">
                    <div class=""card__wrapper"">
                        <div class=""card__container"">
                            <div class=""card__header"">
                                <div class=""card__header-left"">
                                    <h3 class=""card__header-title"">Products By Category</h3>
                                </div>
                                <div class=""card__tools"">
                                    <div class=""card__tools-row row row--xs gutter-bottom-xs"">
                                        <");
            WriteLiteral("div class=\"card__tools-switcher col\">\r\n                                            <div class=\"switcher-button\">\r\n");
            WriteLiteral(@"                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""card__tools-more"">
                                    <button class=""items-more__button"">
                                        <svg class=""icon-icon-more"">
                                            <use xlink:href=""#icon-more""></use>
                                        </svg>
                                    </button>
                                    <div class=""dropdown-items"">
                                        <div class=""dropdown-items__container"">
                                            <ul class=""dropdown-items__list"">
                                                <li class=""dropdown-items__item""><a class=""dropdown-items__link""><span class=""dropdown-items__link-icon"">
                            <svg class=""icon-icon-refresh"">
               ");
            WriteLiteral(@"             <use xlink:href=""#icon-refresh""></use>
                            </svg></span>Refresh</a>
                                                </li>
                                                <li class=""dropdown-items__item""><a class=""dropdown-items__link""><span class=""dropdown-items__link-icon"">
                            <svg class=""icon-icon-settings"">
                            <use xlink:href=""#icon-settings""></use>
                            </svg></span>Settings</a>
                                                </li>
                                                <li class=""dropdown-items__item""><a class=""dropdown-items__link""><span class=""dropdown-items__link-icon"">
                            <svg class=""icon-icon-download"">
                            <use xlink:href=""#icon-download""></use>
                            </svg></span>Download</a>
                                                </li>
                                                <li class=""dropdown-it");
            WriteLiteral(@"ems__item""><a class=""dropdown-items__link""><span class=""dropdown-items__link-icon"">
                            <svg class=""icon-icon-action"">
                            <use xlink:href=""#icon-action""></use>
                            </svg></span>Action</a>
                                                </li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""card__body"">
                                <div class=""card__widgets"">
                                    <div class=""card__widgets-row gutter-bottom-sm"">
                                        <div class=""card-widget card-widget--xl"">
                                            <h4 class=""card-widget__title"">Total Revenue</h4>
                                            <div class=""card-widget__trade""><span class=""card-widget__coun");
            WriteLiteral("t\">");
#nullable restore
#line 174 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\AdminDashboard.cshtml"
                                                                                                        Write(String.Format(System.Globalization.CultureInfo.GetCultureInfo("vi-VN"), "{0:c}", totalMoney));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""card__countries-progressbar"">
                                    <div class=""progressbar progressbar--stacked progressbar--axis-top progressbar--lg"">
                                        <div class=""progressbar__items"">
                                            <div class=""progressbar__bar progressbar__bar--green"" style=""width: 100%;""><span class=""progressbar__bar-count""></span>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""card__footer card__footer--lg"">
                                <div class=""card__container"">
                                    <di");
            WriteLiteral(@"v class=""country-legend"">
                                        <div class=""country-legend__row"">
                                            <div class=""country-legend__item"">
                                                <div class=""country-legend__trade""><span class=""country-legend__quot quotation quotation--up"">
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-12 col-lg-5 col-xl-4 d-flex"">
                <div class=""card card--right pb-0"">
                    <div class=""card__wrapper"">
                        <div class=""card__container"">
                            <div class=""card__header"">
                                <div class=""ca");
            WriteLiteral(@"rd__header-left"">
                                    <h3 class=""card__header-title"">Recent Products Purchased</h3>
                                </div>
                                <div class=""card__tools-more"">
                                    <button class=""items-more__button"">
                                        <svg class=""icon-icon-more"">
                                            <use xlink:href=""#icon-more""></use>
                                        </svg>
                                    </button>
                                    <div class=""dropdown-items"">
                                        <div class=""dropdown-items__container"">
                                            <ul class=""dropdown-items__list"">
                                                <li class=""dropdown-items__item""><a class=""dropdown-items__link""><span class=""dropdown-items__link-icon"">
                            <svg class=""icon-icon-refresh"">
                            <use xlink:hr");
            WriteLiteral(@"ef=""#icon-refresh""></use>
                            </svg></span>Refresh</a>
                                                </li>
                                                <li class=""dropdown-items__item""><a class=""dropdown-items__link""><span class=""dropdown-items__link-icon"">
                            <svg class=""icon-icon-settings"">
                            <use xlink:href=""#icon-settings""></use>
                            </svg></span>Settings</a>
                                                </li>
                                                <li class=""dropdown-items__item""><a class=""dropdown-items__link""><span class=""dropdown-items__link-icon"">
                            <svg class=""icon-icon-download"">
                            <use xlink:href=""#icon-download""></use>
                            </svg></span>Download</a>
                                                </li>
                                                <li class=""dropdown-items__item""><a class=""dropd");
            WriteLiteral(@"own-items__link""><span class=""dropdown-items__link-icon"">
                            <svg class=""icon-icon-action"">
                            <use xlink:href=""#icon-action""></use>
                            </svg></span>Action</a>
                                                </li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""card__body"">
                                <div class=""card__transactions card__scrollbar scrollbar-thin scrollbar-visible"" data-simplebar=""data-simplebar"">
                                    <div class=""card-transactions"">
");
#nullable restore
#line 249 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\AdminDashboard.cshtml"
                                         foreach (var orderDetail in listOdDetail)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                             <div class=""card-transactions__item"">
                                            <div class=""card-transactions__left"">
                                                <div class=""card-transactions__icon"">
                                                    <svg class=""icon-icon-bill"">
                                                        <use xlink:href=""#icon-bill""></use>
                                                    </svg>
                                                </div>
                                                <div class=""card-transactions__right"">
                                                    <h5 class=""card-transactions__title"">");
#nullable restore
#line 259 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\AdminDashboard.cshtml"
                                                                                    Write(orderDetail.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5><span class=\"card-transactions__time\">");
#nullable restore
#line 259 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\AdminDashboard.cshtml"
                                                                                                                                                               Write(orderDetail.Order.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                                </div>
                                            </div>
                                            <div class=""card-transactions__details"">
                                                <div class=""card-transactions__cost"">");
#nullable restore
#line 263 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\AdminDashboard.cshtml"
                                                                                Write(String.Format(System.Globalization.CultureInfo.GetCultureInfo("vi-VN"), "{0:c}", orderDetail.DetailPrice*orderDetail.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            WriteLiteral("                                            </div>\r\n                                        </div>\r\n");
#nullable restore
#line 267 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\AdminDashboard.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                       
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section class=""section"">
        <div class=""section__title d-none"">
            <h2>Section</h2>
        </div>
        <div class=""row gutter-bottom-xl"">
            <div class=""col-12 d-flex"">
                <div class=""card pb-0"">
                    <div class=""card__wrapper"">
                        <div class=""card__container"">
                            <div class=""card__header"">
                                <div class=""card__header-left"">
                                    <h3 class=""card__header-title"">Transactions</h3>
                                </div>
                                <div class=""card__tools-more"">
                                    <button class=""items-more__b");
            WriteLiteral(@"utton"">
                                        <svg class=""icon-icon-more"">
                                            <use xlink:href=""#icon-more""></use>
                                        </svg>
                                    </button>
                                    <div class=""dropdown-items"">
                                        <div class=""dropdown-items__container"">
                                            <ul class=""dropdown-items__list"">
                                                <li class=""dropdown-items__item""><a class=""dropdown-items__link""><span class=""dropdown-items__link-icon"">
                            <svg class=""icon-icon-refresh"">
                            <use xlink:href=""#icon-refresh""></use>
                            </svg></span>Refresh</a>
                                                </li>
                                                <li class=""dropdown-items__item""><a class=""dropdown-items__link""><span class=""dropdown-items__link-ico");
            WriteLiteral(@"n"">
                            <svg class=""icon-icon-settings"">
                            <use xlink:href=""#icon-settings""></use>
                            </svg></span>Settings</a>
                                                </li>
                                                <li class=""dropdown-items__item""><a class=""dropdown-items__link""><span class=""dropdown-items__link-icon"">
                            <svg class=""icon-icon-download"">                                                                                                              
                            <use xlink:href=""#icon-download""></use>
                            </svg></span>Download</a>
                                                </li>
                                                <li class=""dropdown-items__item""><a class=""dropdown-items__link""><span class=""dropdown-items__link-icon"">
                            <svg class=""icon-icon-action"">
                            <use xlink:href=""#icon-action");
            WriteLiteral(@"""></use>
                            </svg></span>Action</a>
                                                </li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""card__body"">
                                <div class=""card__scrollbar card__table"">
                                    <div class=""card__table-transactions scrollbar-thin scrollbar-visible"" data-simplebar=""data-simplebar"">
                                        <table class=""table table--lines table--striped"">
                                            <colgroup>
                                                <col class=""colgroup-1"" />
                                                <col class=""colgroup-2"" />
                                                <col class=""colgroup-3"" />
                                          ");
            WriteLiteral(@"      <col class=""colgroup-4"" />
                                                <col class=""colgroup-5"" />
                                                <col class=""colgroup-6"" />
                                                <col/>
                                            </colgroup>
                                            <thead class=""table__header table__header--sticky"">
                                                <tr>
                                                    <th style=""width: 30%;""><span class=""text-nowrap"">Order No.</span>
                                                    </th>
                                                    <th style=""width: 30%;""><span>Name</span>
                                                    </th>
                                                    <th style=""width: 20%;""><span>Date</span>
                                                    </th>
                                                    <th style=""width: 20%;""><span>Amoun");
            WriteLiteral("t</span>\r\n                                                    </th>\r\n                                                </tr>\r\n                                            </thead>\r\n                                            <tbody>\r\n");
#nullable restore
#line 351 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\AdminDashboard.cshtml"
                                                 foreach (var trans in listTransaction)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr class=\"table__row\">\r\n                                                    <td class=\"table__td\"><span class=\"text-grey\">");
#nullable restore
#line 354 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\AdminDashboard.cshtml"
                                                                                             Write(trans.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                                    </td>
                                                    <td class=""table__td"">
                                                        <div class=""media-item"">
                                                            <div class=""media-item__icon color-orange"">
                                                                <div class=""media-item__icon-text"">WS</div>
                                                                <img class=""media-item__thumb"" src=""img/content/humans/item-4.jpg"" alt=""#"" />
                                                            </div>
                                                            <div class=""media-item__right"">
                                                                <h5 class=""media-item__title"">");
#nullable restore
#line 363 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\AdminDashboard.cshtml"
                                                                                         Write(trans.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                                            </div>
                                                        </div>
                                                    </td>
                                                    <td class=""table__td""><span class=""text-grey"">");
#nullable restore
#line 367 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\AdminDashboard.cshtml"
                                                                                             Write(trans.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                    </td>\r\n                                                    <td class=\"table__td\"><span>");
#nullable restore
#line 369 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\AdminDashboard.cshtml"
                                                                           Write(String.Format(System.Globalization.CultureInfo.GetCultureInfo("vi-VN"), "{0:c}", trans.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                    </td>\r\n                                                </tr>\r\n");
#nullable restore
#line 372 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\AdminDashboard.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
