#pragma checksum "C:\PROJELER\Asp.NetCoreExample\MyBlog\MyBlog\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0576f3bf0c65983a17f7e3a248ed524bed8d1cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "C:\PROJELER\Asp.NetCoreExample\MyBlog\MyBlog\Views\_ViewImports.cshtml"
using MyBlog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\PROJELER\Asp.NetCoreExample\MyBlog\MyBlog\Views\_ViewImports.cshtml"
using MyBlog.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\PROJELER\Asp.NetCoreExample\MyBlog\MyBlog\Views\Blog\Index.cshtml"
using MyBlog.Entities.Concrate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0576f3bf0c65983a17f7e3a248ed524bed8d1cb", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b889b3f4308041dc292b61010b9c4781c7386c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\PROJELER\Asp.NetCoreExample\MyBlog\MyBlog\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""main-content-w3layouts-agileits"">
    <div class=""container"">
        <h3 class=""tittle"">Blog Posts</h3>
        <div class=""inner-sec"">
            <!--left-->
            <div class=""left-blog-info-w3layouts-agileits text-left"">
                <div class=""row"">
");
#nullable restore
#line 16 "C:\PROJELER\Asp.NetCoreExample\MyBlog\MyBlog\Views\Blog\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-4 card\">\r\n                            <a href=\"single.html\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 650, "\"", 670, 1);
#nullable restore
#line 20 "C:\PROJELER\Asp.NetCoreExample\MyBlog\MyBlog\Views\Blog\Index.cshtml"
WriteAttributeValue("", 656, item.ImageUrl, 656, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 702, "\"", 708, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""70"" height=""70"">
                            </a>
                            <div class=""card-body"">
                                <ul class=""blog-icons my-4"">
                                    <li>
                                        <a href=""#"">
                                            <i class=""far fa-calendar-alt""></i> ");
#nullable restore
#line 26 "C:\PROJELER\Asp.NetCoreExample\MyBlog\MyBlog\Views\Blog\Index.cshtml"
                                                                           Write(item.CreateDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </a>
                                    </li>
                                    <li class=""mx-2"">
                                        <a href=""#"">
                                            <i class=""far fa-comment""></i> 0
                                        </a>
                                    </li>
                                    <li>
                                        <a href=""#"">
                                            <i class=""fas fa-eye""></i> ");
#nullable restore
#line 36 "C:\PROJELER\Asp.NetCoreExample\MyBlog\MyBlog\Views\Blog\Index.cshtml"
                                                                  Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </a>\r\n                                    </li>\r\n                                </ul>\r\n                                <h5 class=\"card-title\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1874, "\"", 1907, 3);
            WriteAttributeValue("", 1881, "/Blog/BlogDetail/", 1881, 17, true);
#nullable restore
#line 41 "C:\PROJELER\Asp.NetCoreExample\MyBlog\MyBlog\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1898, item.Id, 1898, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1906, "/", 1906, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 41 "C:\PROJELER\Asp.NetCoreExample\MyBlog\MyBlog\Views\Blog\Index.cshtml"
                                                                    Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </h5>\r\n");
            WriteLiteral("                                <p class=\"card-text mb-3\">");
#nullable restore
#line 44 "C:\PROJELER\Asp.NetCoreExample\MyBlog\MyBlog\Views\Blog\Index.cshtml"
                                                     Write(item.Content.Substring(0, 8));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</p>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2177, "\"", 2210, 3);
            WriteAttributeValue("", 2184, "/Blog/BlogDetail/", 2184, 17, true);
#nullable restore
#line 45 "C:\PROJELER\Asp.NetCoreExample\MyBlog\MyBlog\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2201, item.Id, 2201, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2209, "/", 2209, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary read-m\">Read More</a>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 48 "C:\PROJELER\Asp.NetCoreExample\MyBlog\MyBlog\Views\Blog\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <!--//left-->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
