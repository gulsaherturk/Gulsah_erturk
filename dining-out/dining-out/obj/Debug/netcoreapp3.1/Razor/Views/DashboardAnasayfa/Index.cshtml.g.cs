#pragma checksum "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c43668ab28622fe89392906408c994cded02a0a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DashboardAnasayfa_Index), @"mvc.1.0.view", @"/Views/DashboardAnasayfa/Index.cshtml")]
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
#line 1 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\_ViewImports.cshtml"
using dining_out;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\_ViewImports.cshtml"
using dining_out.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\_ViewImports.cshtml"
using dining_out.Models.DbModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c43668ab28622fe89392906408c994cded02a0a2", @"/Views/DashboardAnasayfa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db1e818469822cea25997ec769de68a3e441debc", @"/Views/_ViewImports.cshtml")]
    public class Views_DashboardAnasayfa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DashboardAnasayfaVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DashboardMasaRezervasyon", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
  
    Layout = "~/Views/Shared/_LayoutDashboard.cshtml";
    ViewData["Title"] = "Dashboard - Anasayfa";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br />
<div>
    <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
        <li class=""nav-item"">
            <a class=""nav-link active"" id=""new-rez"" data-toggle=""tab"" href=""#newrez"" role=""tab"" aria-controls=""newrez"" aria-selected=""true"">Yeni Rezervasyonlu Masalar</a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" id=""active-rez"" data-toggle=""tab"" href=""#activerez"" role=""tab"" aria-controls=""activerez"" aria-selected=""false"">Aktif Rezervasyonlu Masalar</a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" id=""last-rez"" data-toggle=""tab"" href=""#lastrez"" role=""tab"" aria-controls=""lastrez"" aria-selected=""false"">Geçmiş Rezervasyonlu Masalar</a>
        </li>
    </ul>
    <div class=""tab-content text-center"" id=""myTabContent"">
        <br/>
        <div class=""tab-pane fade show active"" id=""newrez"" role=""tabpanel"" aria-labelledby=""new-rez-tab"">
            <div class=""shadow p-3 mb-5 bg-white rounded"">
");
#nullable restore
#line 25 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                 if (Model.BookTableNewRezervations != null && Model.BookTableNewRezervations.Count > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <table id=""newrez-table"" class=""table table-striped table-bordered"" style=""width:95%"">
                        <thead>
                            <tr>
                                <th>Rezervasyon Numarası</th>
                                <th>Rezervasyon Tarihi</th>
                                <th>Rezervasyon İsmi Soyismi</th>
                                <th>Rezervasyon Durumu</th>
                                <th>Rezervasyon Yapılan Restaurant</th>
                                <th>Rezervasyon Yapan Telefon</th>
                                <th>Rezervasyon Yapan E-Mail</th>
                                <th>Detay</th>
                            </tr>
                        </thead>
                        <tbody>

");
#nullable restore
#line 42 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                             foreach (var rezervationVM in Model.BookTableNewRezervations)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td>");
#nullable restore
#line 45 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                               Write(rezervationVM.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 46 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                               Write(rezervationVM.RezervationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 46 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                                                                Write(rezervationVM.RezervationTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 47 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                               Write(rezervationVM.NameLastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 48 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                               Write(rezervationVM.RezervationStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 49 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                               Write(rezervationVM.RestaurantName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 50 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                               Write(rezervationVM.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 51 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                               Write(rezervationVM.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c43668ab28622fe89392906408c994cded02a0a29323", async() => {
                WriteLiteral("\n                                        <i class=\"bi bi-arrow-right-circle-fill\" style=\"font-size: 2rem; color: cornflowerblue;\"></i>\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-masaRezervationId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                                                        WriteLiteral(rezervationVM.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["masaRezervationId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-masaRezervationId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["masaRezervationId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </td>\n                            </tr>\n");
#nullable restore
#line 60 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\n                    </table>\n");
#nullable restore
#line 63 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"text-primary\">Kayıt Bulunmamaktadır</span>\n");
#nullable restore
#line 67 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        </div>\n        <div class=\"tab-pane fade\" id=\"activerez\" role=\"tabpanel\" aria-labelledby=\"active-rez-tab\">\n            <div class=\"shadow p-3 mb-5 bg-white rounded\">\n");
#nullable restore
#line 72 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                 if (Model.BookTableActiveRezervations != null && Model.BookTableActiveRezervations.Count > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <table id=""activerez-table"" class=""table table-striped table-bordered"" style=""width:95%"">
                        <thead>
                            <tr>
                                <th>Rezervasyon Numarası</th>
                                <th>Rezervasyon Tarihi</th>
                                <th>Rezervasyon İsmi Soyismi</th>
                                <th>Rezervasyon Durumu</th>
                                <th>Rezervasyon Yapılan Restaurant</th>
                                <th>Rezervasyon Yapan Telefon</th>
                                <th>Rezervasyon Yapan E-Mail</th>
                                <th>Detay</th>

                        </thead>
                        <tbody>
");
#nullable restore
#line 88 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                             foreach (var rezervationVM in Model.BookTableActiveRezervations)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\n                                    <td>");
#nullable restore
#line 91 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                                   Write(rezervationVM.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 92 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                                   Write(rezervationVM.RezervationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 92 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                                                                    Write(rezervationVM.RezervationTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 93 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                                   Write(rezervationVM.NameLastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 94 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                                   Write(rezervationVM.RezervationStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 95 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                                   Write(rezervationVM.RestaurantName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 96 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                                   Write(rezervationVM.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 97 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                                   Write(rezervationVM.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c43668ab28622fe89392906408c994cded02a0a217147", async() => {
                WriteLiteral("\n                                            <i class=\"bi bi-arrow-right-circle-fill\" style=\"font-size: 2rem; color: cornflowerblue;\"></i>\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-masaRezervationId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 101 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                                                            WriteLiteral(rezervationVM.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["masaRezervationId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-masaRezervationId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["masaRezervationId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                    </td>\n                                </tr>\n");
#nullable restore
#line 106 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\n\n                    </table>\n");
#nullable restore
#line 110 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"text-primary\">Kayıt Bulunmamaktadır</span>\n");
#nullable restore
#line 114 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n            </div>\n            <div class=\"tab-pane fade\" id=\"lastrez\" role=\"tabpanel\" aria-labelledby=\"last-rez-tab\">\n                <div class=\"shadow p-3 mb-5 bg-white rounded\">\n");
#nullable restore
#line 119 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                     if (Model.BookTableClosedRezervations != null && Model.BookTableClosedRezervations.Count > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <table id=""lastrez-table"" class=""table table-striped table-bordered"" style=""width:95%"">
                            <thead>
                                <tr>
                                    <th>Rezervasyon Numarası</th>
                                    <th>Rezervasyon Tarihi</th>
                                    <th>Rezervasyon İsmi Soyismi</th>
                                    <th>Rezervasyon Durumu</th>
                                    <th>Rezervasyon Yapılan Restaurant</th>
                                    <th>Rezervasyon Yapan Telefon</th>
                                    <th>Rezervasyon Yapan E-Mail</th>
                                    <th>Detay</th>
                                </tr>
                            </thead>
                            <tbody>

");
#nullable restore
#line 136 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                                 foreach (var rezervationVM in Model.BookTableClosedRezervations)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\n                                    <td>");
#nullable restore
#line 139 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                                   Write(rezervationVM.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 140 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                                   Write(rezervationVM.RezervationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 140 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                                                                    Write(rezervationVM.RezervationTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 141 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                                   Write(rezervationVM.NameLastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 142 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                                   Write(rezervationVM.RezervationStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 143 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                                   Write(rezervationVM.RestaurantName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 144 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                                   Write(rezervationVM.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 145 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                                   Write(rezervationVM.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c43668ab28622fe89392906408c994cded02a0a225124", async() => {
                WriteLiteral("\n                                            <i class=\"bi bi-arrow-right-circle-fill\" style=\"font-size: 2rem; color: cornflowerblue;\"></i>\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-masaRezervationId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 149 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                                                            WriteLiteral(rezervationVM.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["masaRezervationId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-masaRezervationId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["masaRezervationId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                    </td>\n                                </tr>\n");
#nullable restore
#line 154 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\n                        </table>\n");
#nullable restore
#line 157 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"text-primary\">Kayıt Bulunmamaktadır</span>\n");
#nullable restore
#line 161 "C:\Users\ACER\Desktop\Projects\dining-out\dining-out\Views\DashboardAnasayfa\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n            </div>\n        </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DashboardAnasayfaVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
