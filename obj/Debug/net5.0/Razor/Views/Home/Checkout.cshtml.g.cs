#pragma checksum "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "977dca60cf167193ed6bcb3bbfe5caca0e974b0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Checkout), @"mvc.1.0.view", @"/Views/Home/Checkout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"977dca60cf167193ed6bcb3bbfe5caca0e974b0f", @"/Views/Home/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7af0d8d46e9810ccc2630830b39b78eaeba22be4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/toast.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- breadcrumb-area start -->
<div class=""breadcrumb-area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""row breadcrumb_box  align-items-center"">
                    <div class=""col-lg-6 col-md-6 col-sm-12 text-center text-md-left"">
                        <h2 class=""breadcrumb-title"">Shop</h2>
                    </div>
                    <div class=""col-lg-6  col-md-6 col-sm-12"">
                        <!-- breadcrumb-list start -->
                        <ul class=""breadcrumb-list text-center text-md-right"">
                            <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                            <li class=""breadcrumb-item active"">Checkout</li>
                        </ul>
                        <!-- breadcrumb-list end -->
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<!-- breadcrumb-area end -->

<!-- checkout area start");
            WriteLiteral(" -->\r\n<div class=\"checkout-area pt-100px pb-100px\">\r\n    <div class=\"container\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "977dca60cf167193ed6bcb3bbfe5caca0e974b0f5792", async() => {
                WriteLiteral(@"
            <div class=""row"">

                <div class=""col-lg-7"">
                    <div class=""billing-info-wrap"">
                        <h3>Billing Details</h3>
                        <div class=""row"">
                            <div class=""col-lg-6 col-md-6"">
                                <div class=""billing-info mb-4"">
                                    <label>First Name</label>
                                    <input type=""text"" name=""firstName"" required />
                                </div>
                            </div>
                            <div class=""col-lg-6 col-md-6"">
                                <div class=""billing-info mb-4"">
                                    <label>Last Name</label>
                                    <input type=""text"" name=""lastName"" required />
                                </div>
                            </div>

                            <div class=""col-lg-12"">
                                <div class=""billin");
                WriteLiteral(@"g-info mb-4"">
                                    <label>Address</label>

                                    <input name=""address"" placeholder=""Apartment, suite, unit etc."" type=""text""
                                        required />
                                </div>
                            </div>
                            <div class=""col-lg-12"">
                                <div class=""billing-info mb-4"">
                                    <label>Email Address</label>
                                    <input name=""email"" type=""email"" required />
                                </div>
                            </div>
                            <div class=""col-lg-12"">
                                <div class=""billing-info mb-4"">
                                    <label>Town / City</label>
                                    <input name=""city"" type=""text"" required />
                                </div>
                            </div>
                         ");
                WriteLiteral(@"   <div class=""col-lg-6 col-md-6"">
                                <div class=""billing-info mb-4"">
                                    <label>State / County</label>
                                    <input name=""state"" type=""text"" required />
                                </div>
                            </div>
                            <input type=""hidden"" name=""cart"" id=""cart"">
                            <div class=""col-lg-6 col-md-6"">
                                <div class=""billing-info mb-4"">
                                    <label>Phone</label>
                                    <input name=""phone"" type=""phone"" required />
                                </div>
                            </div>
                            <div class=""additional-info-wrap"">
                                <h4>Additional information</h4>
                                <div class=""additional-info"">
                                    <label>Order notes</label>
                            ");
                WriteLiteral(@"        <textarea placeholder=""Notes about your order, e.g. special notes for delivery. ""
                                        name=""message""></textarea>
                                </div>
                            </div>
                            <input type=""hidden"" name=""cart"">
                        </div>

                    </div>
                </div>
                <div class=""col-lg-5 mt-md-30px mt-lm-30px "">
                    <div class=""your-order-area"">
                        <h3>Your order</h3>
                        <div class=""your-order-wrap gray-bg-4"">
                            <div class=""your-order-product-info"">
                                <div class=""your-order-top"">
                                    <ul>
                                        <li>Product</li>
                                        <li>Total</li>
                                    </ul>
                                </div>
                                <div class=""your");
                WriteLiteral(@"-order-middle"">
                                    <ul id=""listProduct"">
                                    </ul>
                                </div>
                                <div class=""your-order-bottom"">
                                    <ul>
                                        <li class=""your-order-shipping"">Shipping</li>
                                        <li>Free shipping</li>
                                    </ul>
                                </div>
                                <div class=""your-order-total"">
                                    <ul>
                                        <li class=""order-total"">Total</li>
                                        <li id=""total""></li>
                                    </ul>
                                </div>
                            </div>
                            <div class=""payment-method"">
                                <div class=""payment-accordion element-mrg"">
                          ");
                WriteLiteral(@"          <div id=""faq"" class=""panel-group"">
                                        <div class=""panel panel-default single-my-account m-0"">
                                            <div class=""panel-heading my-account-title"">
                                                <h4 class=""panel-title""><a data-bs-toggle=""collapse""
                                                        href=""#my-account-1"" class=""collapsed""
                                                        aria-expanded=""true"">Direct bank transfer</a>
                                                </h4>
                                            </div>
                                            <div id=""my-account-1"" class=""panel-collapse collapse show""
                                                data-bs-parent=""#faq"">

                                                <div class=""panel-body"">
                                                    <p>Please send a check to Store Name, Store Street, Store Town,
             ");
                WriteLiteral(@"                                           Store
                                                        State / County, Store Postcode.</p>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""panel panel-default single-my-account m-0"">
                                            <div class=""panel-heading my-account-title"">
                                                <h4 class=""panel-title""><a data-bs-toggle=""collapse""
                                                        href=""#my-account-2"" aria-expanded=""false""
                                                        class=""collapsed"">Check payments</a></h4>
                                            </div>
                                            <div id=""my-account-2"" class=""panel-collapse collapse""
                                                data-bs-parent=""#faq"">

           ");
                WriteLiteral(@"                                     <div class=""panel-body"">
                                                    <p>Please send a check to Store Name, Store Street, Store Town,
                                                        Store
                                                        State / County, Store Postcode.</p>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""panel panel-default single-my-account m-0"">
                                            <div class=""panel-heading my-account-title"">
                                                <h4 class=""panel-title""><a data-bs-toggle=""collapse""
                                                        href=""#my-account-3"">Cash on delivery</a></h4>
                                            </div>
                                            <div id=""my-account-3"" class=""panel-collaps");
                WriteLiteral(@"e collapse""
                                                data-bs-parent=""#faq"">

                                                <div class=""panel-body"">
                                                    <p>Please send a check to Store Name, Store Street, Store Town,
                                                        Store
                                                        State / County, Store Postcode.</p>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""Place-order mt-25"">
                            <button class=""btn-hover button-css-to-a"" id=""check-out"">Place Order</button>
                        </div>
                    </div>
                </div>
                <input type=""hidde");
                WriteLiteral("n\" id=\"id-remove\"");
                BeginWriteAttribute("value", " value=\"", 10399, "\"", 10425, 1);
#nullable restore
#line 183 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\Checkout.cshtml"
WriteAttributeValue("", 10407, ViewBag.ProductId, 10407, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <input type=\"hidden\" id=\"quantity\"");
                BeginWriteAttribute("value", " value=\"", 10479, "\"", 10511, 1);
#nullable restore
#line 184 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\Checkout.cshtml"
WriteAttributeValue("", 10487, ViewBag.ProductQuantity, 10487, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <input type=\"hidden\" id=\"clear-cart\"");
                BeginWriteAttribute("value", " value=\"", 10567, "\"", 10591, 1);
#nullable restore
#line 185 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\Home\Checkout.cshtml"
WriteAttributeValue("", 10575, ViewBag.Success, 10575, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <input type=\"hidden\" id=\"detail-add\">\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n</div>\r\n</div>\r\n<!-- checkout area end -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "977dca60cf167193ed6bcb3bbfe5caca0e974b0f18626", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    const checkOut = document.getElementById(""check-out"");
    checkOut.addEventListener(""click"", function () {
        document.getElementById(""cart"").value = localStorage.getItem(""cart"");
    });


    function toats() {
        vt.error(""Your order product have been sold out!"", {
            title: ""Check out fail"",
            position: ""top-right"",
            duration: 5000,
            closable: true,
            focusable: true,
            callback: undefined
        });
    }

    function toats2() {
        vt.error(""Your order do not have enough quantity!"", {
            title: ""Check out fail"",
            position: ""top-right"",
            duration: 5000,
            closable: true,
            focusable: true,
            callback: undefined
        });
    }


");
            WriteLiteral("\r\n");
            WriteLiteral(@"
        /*checkOut.addEventListener(""click"", function () {
            const phone = document.getElementById(""phone"");
            const firstName = document.getElementById(""first-name"");
            const lastName = document.getElementById(""last-name"");
            const address = document.getElementById(""address"");
            const city = document.getElementById(""city"");
            const state = document.getElementById(""state"");
            $.ajax({
                type: ""POST"",
                url: ""cart/check-out"",
");
            WriteLiteral(@"                data: {
                cart: localStorage.getItem(""cart""), fullName: firstName + "" "" + lastName,
                phone: phone, address: address, city: city,
                state: state
            },
                async: false,
                success: function (response) {
                    data = response;
                    if (data === ""not login"")
                        window.location.replace(""https://localhost:5001/login"");
                    else if (data === ""cart null"")
                        window.location.reload(""https://localhost:5001/check-out"");
                    else {
                        console.log(data);
                        localStorage.removeItem(""cart"");
                        localStorage.setItem(""cart"");
                    }
                },
                error: function () {
                    alert(""Error occured"");
                },
            });
        });*/
");
            WriteLiteral("\r\n        window.addEventListener(\'load\', (event) => {\r\n\r\n");
            WriteLiteral(@"                console.log(""load ne"");
            let success = document.getElementById(""clear-cart"").value;
            if (success === ""success"") {
                localStorage.removeItem(""cart"");
                document.location.href = ""https://localhost:5001/check-out-success"";
            }
            let cart = JSON.parse(localStorage.getItem(""cart""));
            if (cart === null) {
                cart = [];
            }

            if (JSON.parse(localStorage.getItem(""cart"")).length == 0) {
                document.getElementById(""check-out"").style.display = ""none"";
            }

            let id = document.getElementById(""id-remove"").value;
            let quantity = document.getElementById(""quantity"").value;

            var newCart = [];
            if (id != null) {

                localStorage.setItem(""cart"", JSON.stringify(newCart));
                if (quantity == ""0"") {
                    toats();
                    for (let o of cart) {
                 ");
            WriteLiteral(@"       console.log(o.id);
                        if (o.id != document.getElementById(""id-remove"").value) {
                            newCart.push(o);
                        }
                    }


                } else {

                    for (let o of cart) {
                        let newProduct;
                        if (o.id == document.getElementById(""id-remove"").value) {
                            toats2();
                            newProduct = {
                                id: o.id,
                                image: o.image,
                                name: o.name,
                                price: o.price,
                                quantity: quantity
                            };
                        } else {
                            newProduct = {
                                id: o.id,
                                image: o.image,
                                name: o.name,
                                price: o.price,");
            WriteLiteral(@"
                                quantity: o.quantity
                            };
                        }

                        newCart.push(newProduct);
                    }
                    localStorage.setItem(""cart"", JSON.stringify(newCart));
");
            WriteLiteral(@"                }

            }
            cart = JSON.parse(localStorage.getItem(""cart""));
            let listInsert = document.getElementById(""listProduct"");
            listInsert.innerHTML = """";
            if (cart === null) {
                cart = [];
            }

            let total = 0;
            let item = """";
            for (let cartItem of cart) {
                item += `<li><span class=""order-middle-left"">${cartItem.name} x ${cartItem.quantity}</span> <span
                                            class=""order-price"">${cartItem.price * cartItem.quantity} VND </span></li>`;
                total += parseFloat(cartItem.price * cartItem.quantity);
            }
            listInsert.innerHTML = item;
            document.getElementById(""total"").innerHTML = total;
        });
</script>
<style>
    .button-css-to-a {
        background-color: #ff7004;
        color: #fff;
        display: block;
        font-weight: 700;
        letter-spacing: 1px;
        l");
            WriteLiteral(@"ine-height: 1;
        padding: 18px 20px;
        text-align: center;
        text-transform: uppercase;
        border-radius: 0px;
        z-index: 9;
        width: 100%;
    }

    .button-css-to-a:hover {
        background-color: black;
    }
</style>");
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