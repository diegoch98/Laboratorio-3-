#pragma checksum "C:\Users\Diego\source\repos\Laboratorio-3-\Laboratorio3\Views\Song\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62695f3333a23532861b3313e5ceeeaf90975e98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Song_Index), @"mvc.1.0.view", @"/Views/Song/Index.cshtml")]
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
#line 1 "C:\Users\Diego\source\repos\Laboratorio-3-\Laboratorio3\Views\_ViewImports.cshtml"
using Laboratorio3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Diego\source\repos\Laboratorio-3-\Laboratorio3\Views\_ViewImports.cshtml"
using Laboratorio3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62695f3333a23532861b3313e5ceeeaf90975e98", @"/Views/Song/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e7dd5c7c732b0d76f4dc87d0019fc2954704402", @"/Views/_ViewImports.cshtml")]
    public class Views_Song_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Laboratorio3.Models.SongModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Diego\source\repos\Laboratorio-3-\Laboratorio3\Views\Song\Index.cshtml"
  
    ViewData["Title"] = "Songs";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\Diego\source\repos\Laboratorio-3-\Laboratorio3\Views\Song\Index.cshtml"
Write(ViewBag.MainTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<div>
    <table class=""table"">

        <thead>
            <tr>
                <th>Song title</th>
                <th>Gender</th>
                <th>Released date</th>
                <th>Singer</th>
                <th>Length</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 22 "C:\Users\Diego\source\repos\Laboratorio-3-\Laboratorio3\Views\Song\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\Diego\source\repos\Laboratorio-3-\Laboratorio3\Views\Song\Index.cshtml"
                   Write(item.SongName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\Diego\source\repos\Laboratorio-3-\Laboratorio3\Views\Song\Index.cshtml"
                   Write(item.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\Diego\source\repos\Laboratorio-3-\Laboratorio3\Views\Song\Index.cshtml"
                   Write(item.ReleasedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\Diego\source\repos\Laboratorio-3-\Laboratorio3\Views\Song\Index.cshtml"
                   Write(item.Singer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\Diego\source\repos\Laboratorio-3-\Laboratorio3\Views\Song\Index.cshtml"
                   Write(item.Length);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 31 "C:\Users\Diego\source\repos\Laboratorio-3-\Laboratorio3\Views\Song\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Laboratorio3.Models.SongModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
