#pragma checksum "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\EpisodeComments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0784cdd42f9a5821ed52baa6e152595b8421afb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Serial_EpisodeComments), @"mvc.1.0.view", @"/Areas/Admin/Views/Serial/EpisodeComments.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0784cdd42f9a5821ed52baa6e152595b8421afb1", @"/Areas/Admin/Views/Serial/EpisodeComments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6278c106961752d4bd55c62fce5083d8e5130d21", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Serial_EpisodeComments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<List<Flix_Tv.Application.DTOs.SerialComment.Site.ShowSerialCommentDto>, int>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("main__title-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:30px;width:60px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\EpisodeComments.cshtml"
  
    ViewData["Title"] = "EpisodeComments";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<main class=""main"" style="" padding: 0px 0px 30px 15px;"">
    <div class=""container-fluid"">
        <div class=""row"">
            <!-- main title -->
            <div class=""col-12"">
                <div class=""main__title"">
                    <h2>نظر ها</h2>

");
            WriteLiteral("\r\n                    <div class=\"main__title-wrap\">\r\n                        <!-- filter sort -->\r\n                        <!-- end filter sort -->\r\n                        <!-- search -->\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0784cdd42f9a5821ed52baa6e152595b8421afb15137", async() => {
                WriteLiteral("\r\n                            <input type=\"text\" name=\"filter\"");
                BeginWriteAttribute("value", " value=\"", 922, "\"", 945, 1);
#nullable restore
#line 24 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\EpisodeComments.cshtml"
WriteAttributeValue("", 930, ViewBag.filter, 930, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"کلمه کلیدی ..\">\r\n                            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1025, "\"", 1049, 2);
#nullable restore
#line 25 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\EpisodeComments.cshtml"
WriteAttributeValue("", 1033, ViewBag.pageId, 1033, 15, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 1048, "", 1049, 1, true);
                EndWriteAttribute();
                WriteLiteral(" name=\"pageId\" />\r\n");
                WriteLiteral(@"                            <button type=""submit"">
                                <svg width=""18"" height=""18"" viewBox=""0 0 18 18"" fill=""none"" xmlns=""http://www.w3.org/2000/svg""><circle cx=""8.25998"" cy=""8.25995"" r=""7.48191"" stroke=""#2F80ED"" stroke-width=""1.5"" stroke-linecap=""round"" stroke-linejoin=""round""></circle><path d=""M13.4637 13.8523L16.3971 16.778"" stroke=""#2F80ED"" stroke-width=""1.5"" stroke-linecap=""round"" stroke-linejoin=""round""></path></svg>
                            </button>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 792, "/Admin/EpisodeComments/", 792, 23, true);
#nullable restore
#line 23 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\EpisodeComments.cshtml"
AddHtmlAttributeValue("", 815, ViewBag.episodeId, 815, 18, false);

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
            WriteLiteral(@"
                        <!-- end search -->
                    </div>
                </div>
            </div>
            <!-- end main title -->
            <!-- comments -->
            <div class=""col-12"">
                <div class=""main__table-wrap"">
                    <table class=""main__table"">
                        <thead>
                            <tr>
                                <th>تصویر</th>
                                <th>عنوان</th>
                                <th>نویسنده</th>
                                <th>امتیاز</th>
                                <th>متن</th>
                                <th>تاریخ ایجاد شده</th>
                                <th>اقدامات</th>
                            </tr>
                        </thead>

                        <tbody>
");
#nullable restore
#line 53 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\EpisodeComments.cshtml"
                             foreach (var item in Model.Item1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        <div class=\"main__table-text\">  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0784cdd42f9a5821ed52baa6e152595b8421afb19878", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2820, "~/Users/ThumbImages/", 2820, 20, true);
#nullable restore
#line 57 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\EpisodeComments.cshtml"
AddHtmlAttributeValue("", 2840, item.UserImage, 2840, 15, false);

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
            WriteLiteral("</div>\r\n                                    </td>\r\n                                    <td>\r\n                                        <div class=\"main__table-text\"><a href=\"#\">");
#nullable restore
#line 60 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\EpisodeComments.cshtml"
                                                                             Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n                                    </td>\r\n                                    <td>\r\n                                        <div class=\"main__table-text\">");
#nullable restore
#line 63 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\EpisodeComments.cshtml"
                                                                 Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                    </td>\r\n                                    <td>\r\n                                        <div class=\"main__table-text\">");
#nullable restore
#line 66 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\EpisodeComments.cshtml"
                                                                  Write((item.Rate!=null?item.Rate:"NULL"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                    </td>\r\n                                    <td>\r\n                                        <div class=\"main__table-text\" style=\"overflow:hidden\">");
#nullable restore
#line 69 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\EpisodeComments.cshtml"
                                                                                          Write((item.Text.Length<20?item.Text: item.Text.Substring(0, 20)));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ...</div>\r\n                                    </td>\r\n\r\n                                    <td>\r\n                                        <div class=\"main__table-text\">");
#nullable restore
#line 73 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\EpisodeComments.cshtml"
                                                                 Write(item.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                    </td>\r\n                                    <td>\r\n                                        <div class=\"main__table-btns\">\r\n                                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 4073, "\"", 4105, 3);
            WriteAttributeValue("", 4083, "ShowText(`", 4083, 10, true);
#nullable restore
#line 77 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\EpisodeComments.cshtml"
WriteAttributeValue("", 4093, item.Text, 4093, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4103, "`)", 4103, 2, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""main__table-btn main__table-btn--view open-modal"">
                                                <svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 24 24""><path d=""M21.92,11.6C19.9,6.91,16.1,4,12,4S4.1,6.91,2.08,11.6a1,1,0,0,0,0,.8C4.1,17.09,7.9,20,12,20s7.9-2.91,9.92-7.6A1,1,0,0,0,21.92,11.6ZM12,18c-3.17,0-6.17-2.29-7.9-6C5.83,8.29,8.83,6,12,6s6.17,2.29,7.9,6C18.17,15.71,15.17,18,12,18ZM12,8a4,4,0,1,0,4,4A4,4,0,0,0,12,8Zm0,6a2,2,0,1,1,2-2A2,2,0,0,1,12,14Z""></path></svg>
                                            </a>
                                            <a");
            BeginWriteAttribute("href", " href=\"", 4692, "\"", 4735, 2);
            WriteAttributeValue("", 4699, "/Admin/ReplyEpisodeComments/", 4699, 28, true);
#nullable restore
#line 80 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\EpisodeComments.cshtml"
WriteAttributeValue("", 4727, item.Id, 4727, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""main__table-btn main__table-btn--view open-modal"">
                                                <i class=""fa fa-comment"" style=""color: #b38768;""></i>
                                            </a>
                                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 4995, "\"", 5035, 3);
            WriteAttributeValue("", 5005, "DeleteEpisodeComment(", 5005, 21, true);
#nullable restore
#line 83 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\EpisodeComments.cshtml"
WriteAttributeValue("", 5026, item.Id, 5026, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5034, ")", 5034, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""main__table-btn main__table-btn--delete open-modal"">
                                                <svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 24 24""><path d=""M10,18a1,1,0,0,0,1-1V11a1,1,0,0,0-2,0v6A1,1,0,0,0,10,18ZM20,6H16V5a3,3,0,0,0-3-3H11A3,3,0,0,0,8,5V6H4A1,1,0,0,0,4,8H5V19a3,3,0,0,0,3,3h8a3,3,0,0,0,3-3V8h1a1,1,0,0,0,0-2ZM10,5a1,1,0,0,1,1-1h2a1,1,0,0,1,1,1V6H10Zm7,14a1,1,0,0,1-1,1H8a1,1,0,0,1-1-1V8H17Zm-3-1a1,1,0,0,0,1-1V11a1,1,0,0,0-2,0v6A1,1,0,0,0,14,18Z""></path></svg>
                                            </a>
                                        </div>
                                    </td>
                                </tr>
");
#nullable restore
#line 89 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\EpisodeComments.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


                        </tbody>
                    </table>
                </div>
            </div>
            <!-- end comments -->
            <!-- paginator -->
            <div class=""col-12"">
                <div class=""paginator"">
                    <span class=""paginator__pages"">10 از 7,545</span>

                    <ul class=""paginator__paginator"">
");
#nullable restore
#line 104 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\EpisodeComments.cshtml"
                         if (ViewBag.pageId > 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 6278, "\"", 6376, 6);
            WriteAttributeValue("", 6285, "/Admin/EpisodeComments/", 6285, 23, true);
#nullable restore
#line 107 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\EpisodeComments.cshtml"
WriteAttributeValue("", 6308, ViewBag.episodeId, 6308, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6326, "?filter=", 6326, 8, true);
#nullable restore
#line 107 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\EpisodeComments.cshtml"
WriteAttributeValue("", 6334, ViewBag.filter, 6334, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6349, "&pageId=", 6349, 8, true);
#nullable restore
#line 107 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\EpisodeComments.cshtml"
WriteAttributeValue("", 6357, ViewBag.pageId-1, 6357, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    <svg width=""14"" height=""11"" viewBox=""0 0 14 11"" fill=""none"" xmlns=""http://www.w3.org/2000/svg""><path d=""M13.1992 5.3645L0.75 5.3645"" stroke-width=""1.2"" stroke-linecap=""round"" stroke-linejoin=""round""></path><path d=""M8.17822 0.602051L13.1993 5.36417L8.17822 10.1271"" stroke-width=""1.2"" stroke-linecap=""round"" stroke-linejoin=""round""></path></svg>
                                </a>
                            </li>
");
#nullable restore
#line 111 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\EpisodeComments.cshtml"
                        }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"active\"><a href=\"#\">");
#nullable restore
#line 118 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\EpisodeComments.cshtml"
                                                  Write(ViewBag.pageId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 119 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\EpisodeComments.cshtml"
                         if (ViewBag.pageId <= Model.Item2)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 7749, "\"", 7847, 6);
            WriteAttributeValue("", 7756, "/Admin/EpisodeComments/", 7756, 23, true);
#nullable restore
#line 122 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\EpisodeComments.cshtml"
WriteAttributeValue("", 7779, ViewBag.episodeId, 7779, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7797, "?filter=", 7797, 8, true);
#nullable restore
#line 122 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\EpisodeComments.cshtml"
WriteAttributeValue("", 7805, ViewBag.filter, 7805, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7820, "&pageId=", 7820, 8, true);
#nullable restore
#line 122 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\EpisodeComments.cshtml"
WriteAttributeValue("", 7828, ViewBag.pageId+1, 7828, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    <svg width=""14"" height=""11"" viewBox=""0 0 14 11"" fill=""none"" xmlns=""http://www.w3.org/2000/svg""><path d=""M0.75 5.36475L13.1992 5.36475"" stroke-width=""1.2"" stroke-linecap=""round"" stroke-linejoin=""round""></path><path d=""M5.771 10.1271L0.749878 5.36496L5.771 0.602051"" stroke-width=""1.2"" stroke-linecap=""round"" stroke-linejoin=""round""></path></svg>

                                </a>
                            </li>
");
#nullable restore
#line 127 "D:\Flix_Tv\Flix_Tv\Flix_Tv.Site\Areas\Admin\Views\Serial\EpisodeComments.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </div>\r\n            </div>\r\n            <!-- end paginator -->\r\n        </div>\r\n    </div>\r\n</main>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function ShowText(text) {
            alert(text);
        }
        function DeleteEpisodeComment(id) {
            $.ajax({
                type: ""POST"",
                url: ""/DeleteEpisodeComment"",
                data: { id: id },
                dataType: ""json"",
                success: function (response) {
                    location.reload();
                }
            });
        }
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<List<Flix_Tv.Application.DTOs.SerialComment.Site.ShowSerialCommentDto>, int>> Html { get; private set; }
    }
}
#pragma warning restore 1591
