#pragma checksum "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\ChangeInfo\ChangeInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "314e7f4afcd7b2f6ab702bb99089649ba7ec9d93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ChangeInfo_ChangeInfo), @"mvc.1.0.view", @"/Views/ChangeInfo/ChangeInfo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"314e7f4afcd7b2f6ab702bb99089649ba7ec9d93", @"/Views/ChangeInfo/ChangeInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7af0d8d46e9810ccc2630830b39b78eaeba22be4", @"/Views/_ViewImports.cshtml")]
    public class Views_ChangeInfo_ChangeInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MAQFurni.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form-change-password"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangePassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ChangeInfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/toast.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\ChangeInfo\ChangeInfo.cshtml"
  
    ViewData["Title"] = "Profile";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
                            <li class=""breadcrumb-item active"">Account</li>
                        </ul>
                        <!-- breadcrumb-list end -->
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<!-- breadcrumb-area end -->

<!-- account area start -");
            WriteLiteral(@"->
<div class=""checkout-area pt-100px pb-100px"">
    <div class=""container"">
        <div class=""row"">
            <div class=""ml-auto mr-auto col-lg-9"">
                <div class=""checkout-wrapper"">
                    <div id=""faq"" class=""panel-group"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "314e7f4afcd7b2f6ab702bb99089649ba7ec9d937087", async() => {
                WriteLiteral(@"
                            <div class=""panel panel-default single-my-account"" data-aos=""fade-up"" data-aos-delay=""200"">
                                <div class=""panel-heading my-account-title"">
                                    <h3 class=""panel-title""><span>1 .</span> <a data-bs-toggle=""collapse""
                                            class=""collapsed"" aria-expanded=""true"" href=""#my-account-1"">Edit your
                                            account information </a>
                                    </h3>
                                </div>
                                <div id=""my-account-1"" class=""panel-collapse collapse show"" data-bs-parent=""#faq"">
                                    <div class=""panel-body"">
                                        <div class=""myaccount-info-wrapper"">
                                            <div class=""account-info-wrapper"">
");
                WriteLiteral(@"                                                <h4>Change Password</h4>
                                                <h5>Your Password</h5>
                                            </div>
                                            <div class=""row"">
");
                WriteLiteral(@"                                                <div class=""col-lg-12 col-md-12"">
                                                    <div class=""billing-info"">
                                                        <label>Password</label>
                                                        <p id=""message""></p>
                                                        <input id=""newPassword"" name=""newPassword"" type=""password"" />
                                                    </div>
                                                </div>
                                                <div class=""col-lg-12 col-md-12"">
                                                    <div class=""billing-info"">
                                                        <label>Password Confirm</label>
                                                        <input id=""confirmPassword"" name=""confirmPassword""
                                                            type=""password"" />
                           ");
                WriteLiteral(@"                         </div>
                                                </div>
                                            </div>
                                            <div class=""billing-back-btn"">
                                                <div class=""billing-back"">
                                                    <a href=""#""><i class=""icon-arrow-up-circle""></i> back</a>
                                                </div>
                                                <div class=""billing-btn"">
                                                    <button type=""submit"" class=""btn btn-primary"">Save</button>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("                    </div>\r\n                    <input type=\"hidden\" id=\"error\" name=\"error\"");
            BeginWriteAttribute("value", " value=\"", 12653, "\"", 12674, 1);
#nullable restore
#line 220 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\ChangeInfo\ChangeInfo.cshtml"
WriteAttributeValue("", 12661, ViewBag.Fail, 12661, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <input type=\"hidden\" id=\"success\" name=\"success\"");
            BeginWriteAttribute("value", " value=\"", 12746, "\"", 12770, 1);
#nullable restore
#line 221 "C:\Users\VODUCMINH\Desktop\MAQFurni\Views\ChangeInfo\ChangeInfo.cshtml"
WriteAttributeValue("", 12754, ViewBag.Success, 12754, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <input type=\"hidden\" id=\"detail-add\">\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- account area end -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "314e7f4afcd7b2f6ab702bb99089649ba7ec9d9313449", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    const password = document.getElementById(""newPassword"");
    const confirm = document.getElementById(""confirmPassword"");
    const messages = document.getElementById(""message"");
    let message = """";
    password.addEventListener(""keyup"", () => {
        if (password.value.length < 6) {
            message = ""Password must be at least 6 charactors!"";
        }
        else if (password.value != confirm.value) {
            message = ""New password and confirm password is different!"";
        } else message = """";
        messages.innerHTML = message;
    });
    confirm.addEventListener(""keyup"", () => {
        if (password.value != confirm.value) {
            message = ""New password and confirm password is different!"";
        } else message = """";
        messages.innerHTML = message;
    });
    function toatsError() {
        vt.error(""Change password fail!"", {
            title: ""Fail"",
            position: ""top-right"",
            duration: 5000,
            closab");
            WriteLiteral(@"le: true,
            focusable: true,
            callback: undefined
        });
    }
    function toatsSuccess() {
        vt.success(""Change password success!"", {
            title: ""Success"",
            position: ""top-right"",
            duration: 5000,
            closable: true,
            focusable: true,
            callback: undefined
        });
    }
    window.addEventListener(""load"", () => {
        console.log(""load roi"");
        const success = document.getElementById(""success"");
        const error = document.getElementById(""error"");

        if (success.value != """") {
            console.log(""success"");
            toatsSuccess();
        }


        if (error.value != """") {
            console.log(""error"");
            toatsError();
        }


    });
</script>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "314e7f4afcd7b2f6ab702bb99089649ba7ec9d9316516", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MAQFurni.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591