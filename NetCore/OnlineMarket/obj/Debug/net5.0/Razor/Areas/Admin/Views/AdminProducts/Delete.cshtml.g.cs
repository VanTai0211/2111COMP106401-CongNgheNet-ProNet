#pragma checksum "D:\LocalDiskD_Data\OnlineMarket\Areas\Admin\Views\AdminProducts\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d1f8aab1cee7a509895a7f6b69f095192769e6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminProducts_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminProducts/Delete.cshtml")]
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
#line 1 "D:\LocalDiskD_Data\OnlineMarket\Areas\Admin\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\LocalDiskD_Data\OnlineMarket\Areas\Admin\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d1f8aab1cee7a509895a7f6b69f095192769e6a", @"/Areas/Admin/Views/AdminProducts/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03350a0a69106539bd5bc7a986cfffe7a4c319da", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminProducts_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineMarket.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("breadcrumb-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminProducts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\LocalDiskD_Data\OnlineMarket\Areas\Admin\Views\AdminProducts\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"page-header\">\r\n    <div class=\"header-sub-title\">\r\n        <nav class=\"breadcrumb breadcrumb-dash\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d1f8aab1cee7a509895a7f6b69f095192769e6a7025", async() => {
                WriteLiteral("<i class=\"anticon anticon-home m-r-5\"></i>Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d1f8aab1cee7a509895a7f6b69f095192769e6a8723", async() => {
                WriteLiteral("Danh sách sản phẩm");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <span class=\"breadcrumb-item active\">Thông tin sản phẩm : ");
#nullable restore
#line 13 "D:\LocalDiskD_Data\OnlineMarket\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                                                                 Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </nav>\r\n    </div>\r\n</div>\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        <h4 class=\"card-title\">Thông tin sản phẩm : ");
#nullable restore
#line 19 "D:\LocalDiskD_Data\OnlineMarket\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                                               Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
        <div class=""table-responsive"">
            <table class=""product-info-table m-t-20"">
                <tbody>
                    <tr>
                        <td>ID:</td>
                        <td class=""text-dark font-weight-semibold"">");
#nullable restore
#line 25 "D:\LocalDiskD_Data\OnlineMarket\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                                                              Write(Model.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Tên sản phẩm:</td>\r\n                        <td>");
#nullable restore
#line 29 "D:\LocalDiskD_Data\OnlineMarket\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                       Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Mô tả ngắn:</td>\r\n                        <td>");
#nullable restore
#line 33 "D:\LocalDiskD_Data\OnlineMarket\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                       Write(Model.ShortDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Gía bán:</td>\r\n                        <td>");
#nullable restore
#line 37 "D:\LocalDiskD_Data\OnlineMarket\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                       Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Active:</td>\r\n                        <td>\r\n");
#nullable restore
#line 42 "D:\LocalDiskD_Data\OnlineMarket\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                             if (Model.Active)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"switch m-r-10\">\r\n                                    <input type=\"checkbox\" id=\"switch-1\"");
            BeginWriteAttribute("checked", " checked=\"", 1855, "\"", 1865, 0);
            EndWriteAttribute();
            WriteLiteral(" disabled />\r\n                                    <label for=\"switch-1\"></label>\r\n                                </div>\r\n");
#nullable restore
#line 48 "D:\LocalDiskD_Data\OnlineMarket\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"switch m-r-10\">\r\n                                    <input type=\"checkbox\" id=\"switch-2\" disabled />\r\n                                    <label for=\"switch-2\"></label>\r\n                                </div>\r\n");
#nullable restore
#line 55 "D:\LocalDiskD_Data\OnlineMarket\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n                    </tr>\r\n                    <tr>\r\n                        <td>BestSeller:</td>\r\n                        <td>\r\n");
#nullable restore
#line 63 "D:\LocalDiskD_Data\OnlineMarket\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                             if (Model.BestSeller)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"switch m-r-10\">\r\n                                    <input type=\"checkbox\" id=\"switch-1\"");
            BeginWriteAttribute("checked", " checked=\"", 2750, "\"", 2760, 0);
            EndWriteAttribute();
            WriteLiteral(" disabled />\r\n                                    <label for=\"switch-1\"></label>\r\n                                </div>\r\n");
#nullable restore
#line 69 "D:\LocalDiskD_Data\OnlineMarket\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"switch m-r-10\">\r\n                                    <input type=\"checkbox\" id=\"switch-2\" disabled />\r\n                                    <label for=\"switch-2\"></label>\r\n                                </div>\r\n");
#nullable restore
#line 76 "D:\LocalDiskD_Data\OnlineMarket\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>HomeFlag:</td>\r\n                        <td>\r\n");
#nullable restore
#line 83 "D:\LocalDiskD_Data\OnlineMarket\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                             if (Model.HomeTag)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"switch m-r-10\">\r\n                                    <input type=\"checkbox\" id=\"switch-1\"");
            BeginWriteAttribute("checked", " checked=\"", 3638, "\"", 3648, 0);
            EndWriteAttribute();
            WriteLiteral(" disabled />\r\n                                    <label for=\"switch-1\"></label>\r\n                                </div>\r\n");
#nullable restore
#line 89 "D:\LocalDiskD_Data\OnlineMarket\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"switch m-r-10\">\r\n                                    <input type=\"checkbox\" id=\"switch-2\" disabled />\r\n                                    <label for=\"switch-2\"></label>\r\n                                </div>\r\n");
#nullable restore
#line 96 "D:\LocalDiskD_Data\OnlineMarket\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Discount:</td>\r\n                        <td>");
#nullable restore
#line 101 "D:\LocalDiskD_Data\OnlineMarket\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                       Write(Model.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Danh mục:</td>\r\n                        <td>");
#nullable restore
#line 105 "D:\LocalDiskD_Data\OnlineMarket\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                       Write(Model.Cat.CatName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>*\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Ngày tạo:</td>\r\n                        <td>");
#nullable restore
#line 109 "D:\LocalDiskD_Data\OnlineMarket\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                       Write(Model.DateCreated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Ngày chỉnh sửa:</td>\r\n                        <td>");
#nullable restore
#line 113 "D:\LocalDiskD_Data\OnlineMarket\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                       Write(Model.DateModified);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Tiêu đề:</td>\r\n                        <td>");
#nullable restore
#line 117 "D:\LocalDiskD_Data\OnlineMarket\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>MetaDesc:</td>\r\n                        <td>");
#nullable restore
#line 121 "D:\LocalDiskD_Data\OnlineMarket\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                       Write(Model.MetaDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>MetaKey:</td>\r\n                        <td>");
#nullable restore
#line 125 "D:\LocalDiskD_Data\OnlineMarket\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                       Write(Model.MetaKey);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Mô tả chi tiết:</td>\r\n                        <td>");
#nullable restore
#line 129 "D:\LocalDiskD_Data\OnlineMarket\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Tags:</td>\r\n                        <td>");
#nullable restore
#line 133 "D:\LocalDiskD_Data\OnlineMarket\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                       Write(Model.Tags);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Ảnh đại diện:</td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9d1f8aab1cee7a509895a7f6b69f095192769e6a21343", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5713, "~/images/products/", 5713, 18, true);
#nullable restore
#line 138 "D:\LocalDiskD_Data\OnlineMarket\Areas\Admin\Views\AdminProducts\Delete.cshtml"
AddHtmlAttributeValue("", 5731, Model.Thumb, 5731, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 138 "D:\LocalDiskD_Data\OnlineMarket\Areas\Admin\Views\AdminProducts\Delete.cshtml"
AddHtmlAttributeValue("", 5750, Model.Title, 5750, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>     \r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d1f8aab1cee7a509895a7f6b69f095192769e6a23612", async() => {
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9d1f8aab1cee7a509895a7f6b69f095192769e6a23903", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#nullable restore
#line 144 "D:\LocalDiskD_Data\OnlineMarket\Areas\Admin\Views\AdminProducts\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                <input type=\"submit\" value=\"Xác nhận xóa\" class=\"btn btn-danger\" /> \r\n                             \r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 143 "D:\LocalDiskD_Data\OnlineMarket\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                                                                                       WriteLiteral(Model.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineMarket.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
