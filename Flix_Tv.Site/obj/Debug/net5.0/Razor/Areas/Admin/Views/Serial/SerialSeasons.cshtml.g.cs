#pragma checksum "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\SerialSeasons.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f8bf85bc064322b853802c6a09747f796736e6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Serial_SerialSeasons), @"mvc.1.0.view", @"/Areas/Admin/Views/Serial/SerialSeasons.cshtml")]
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
#line 1 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\_ViewImports.cshtml"
using Flix_Tv.Site;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\_ViewImports.cshtml"
using Flix_Tv.Site.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f8bf85bc064322b853802c6a09747f796736e6e", @"/Areas/Admin/Views/Serial/SerialSeasons.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6278c106961752d4bd55c62fce5083d8e5130d21", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Serial_SerialSeasons : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Flix_Tv.Application.DTOs.SerialSeason.Admin.GetSerialSeasonsInAdminDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\SerialSeasons.cshtml"
  
    ViewData["Title"] = "SerialSeasons";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-12\">\r\n    <div class=\"main__title\">\r\n        <h2>فصل های سریال ");
#nullable restore
#line 9 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\SerialSeasons.cshtml"
                     Write(ViewBag.serialName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n\r\n        <span class=\"main__title-stat\">تعداد ");
#nullable restore
#line 11 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\SerialSeasons.cshtml"
                                        Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n        <div class=\"main__title-wrap\">\r\n            <a class=\"btn btn-info ml-4\"");
            BeginWriteAttribute("href", " href=\"", 456, "\"", 500, 2);
            WriteAttributeValue("", 463, "/Admin/CreateSeason/", 463, 20, true);
#nullable restore
#line 14 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\SerialSeasons.cshtml"
WriteAttributeValue("", 483, ViewBag.serialId, 483, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">افزودن فصل جدید</a>

        </div>
    </div>
</div>

<div class=""col-12"">
    <div class=""main__table-wrap"">
        <table class=""main__table"">
            <thead>
                <tr>

                    <th>تصویر</th>
                    <th>عنوان</th>
                    <th>تاریخ ایجاد شده</th>

                </tr>
            </thead>

            <tbody>
");
#nullable restore
#line 34 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\SerialSeasons.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            <div class=\"main__user\">\r\n                                <div class=\"main__avatar\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3f8bf85bc064322b853802c6a09747f796736e6e5898", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1172, "~/Serials/Seasons/ThumbImages/", 1172, 30, true);
#nullable restore
#line 40 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\SerialSeasons.cshtml"
AddHtmlAttributeValue("", 1202, item.Image, 1202, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n\r\n                            </div>\r\n                        </td>\r\n                        <td>\r\n                            <div class=\"main__table-text\"><a href=\"#\">");
#nullable restore
#line 46 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\SerialSeasons.cshtml"
                                                                 Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n                        </td>\r\n                        <td>\r\n                            <div class=\"main__table-text\"><a href=\"#\">");
#nullable restore
#line 49 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\SerialSeasons.cshtml"
                                                                 Write(item.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n                        </td>\r\n\r\n                        <td>\r\n\r\n                            <div class=\"main__table-btns\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1774, "\"", 1811, 2);
            WriteAttributeValue("", 1781, "/Admin/SerialEpisodes/", 1781, 22, true);
#nullable restore
#line 55 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\SerialSeasons.cshtml"
WriteAttributeValue("", 1803, item.Id, 1803, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"main__table-btn main__table-btn--banned opend-modal\">\r\n                                    <i class=\"fa fa-bars\" style=\"color:green;\"></i>\r\n                                </a>\r\n\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2034, "\"", 2067, 2);
            WriteAttributeValue("", 2041, "/Admin/EditSeason/", 2041, 18, true);
#nullable restore
#line 59 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\SerialSeasons.cshtml"
WriteAttributeValue("", 2059, item.Id, 2059, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""main__table-btn main__table-btn--edit"">
                                    <svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 24 24""><path d=""M22,7.24a1,1,0,0,0-.29-.71L17.47,2.29A1,1,0,0,0,16.76,2a1,1,0,0,0-.71.29L13.22,5.12h0L2.29,16.05a1,1,0,0,0-.29.71V21a1,1,0,0,0,1,1H7.24A1,1,0,0,0,8,21.71L18.87,10.78h0L21.71,8a1.19,1.19,0,0,0,.22-.33,1,1,0,0,0,0-.24.7.7,0,0,0,0-.14ZM6.83,20H4V17.17l9.93-9.93,2.83,2.83ZM18.17,8.66,15.34,5.83l1.42-1.41,2.82,2.82Z""></path></svg>
                                </a>
                                <button style=""cursor:pointer;""");
            BeginWriteAttribute("onclick", " onclick=\"", 2652, "\"", 2684, 3);
            WriteAttributeValue("", 2662, "DeleteSeason(", 2662, 13, true);
#nullable restore
#line 62 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\SerialSeasons.cshtml"
WriteAttributeValue("", 2675, item.Id, 2675, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2683, ")", 2683, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""main__table-btn main__table-btn--delete odpen-modal"">
                                    <svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 24 24""><path d=""M10,18a1,1,0,0,0,1-1V11a1,1,0,0,0-2,0v6A1,1,0,0,0,10,18ZM20,6H16V5a3,3,0,0,0-3-3H11A3,3,0,0,0,8,5V6H4A1,1,0,0,0,4,8H5V19a3,3,0,0,0,3,3h8a3,3,0,0,0,3-3V8h1a1,1,0,0,0,0-2ZM10,5a1,1,0,0,1,1-1h2a1,1,0,0,1,1,1V6H10Zm7,14a1,1,0,0,1-1,1H8a1,1,0,0,1-1-1V8H17Zm-3-1a1,1,0,0,0,1-1V11a1,1,0,0,0-2,0v6A1,1,0,0,0,14,18Z""></path></svg>
                                </button>
                            </div>
                        </td>
                    </tr>
");
#nullable restore
#line 68 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\SerialSeasons.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
    
        function DeleteSeason(id) {
            if (id) {
                $.ajax({
                    type: ""POST"",
                    url: ""/Admin/DeleteSeason"",
                    data: { Id: id },
                    dataType: ""json"",
                    success: function (res) {
                        location.reload();
                    }
                });
            }
        }
    </script>
");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Flix_Tv.Application.DTOs.SerialSeason.Admin.GetSerialSeasonsInAdminDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591