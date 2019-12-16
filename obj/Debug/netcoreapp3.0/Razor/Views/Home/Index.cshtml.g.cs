#pragma checksum "/home/student/CodeSchool/IdeaProjects/dotNet/MVcMovie/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6ea37b6ccfb14523e851166c0b38ae838dc875e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/home/student/CodeSchool/IdeaProjects/dotNet/MVcMovie/Views/_ViewImports.cshtml"
using MVcMovie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/student/CodeSchool/IdeaProjects/dotNet/MVcMovie/Views/_ViewImports.cshtml"
using MVcMovie.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6ea37b6ccfb14523e851166c0b38ae838dc875e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dd51a75a82d58e5a2475c04dfd75255fae4cc80", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVcMovie.Models.Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/home/student/CodeSchool/IdeaProjects/dotNet/MVcMovie/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n\r\n    <div>\r\n        <!-- <li>");
#nullable restore
#line 12 "/home/student/CodeSchool/IdeaProjects/dotNet/MVcMovie/Views/Home/Index.cshtml"
            Write(ViewData["ID"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>");
#nullable restore
#line 13 "/home/student/CodeSchool/IdeaProjects/dotNet/MVcMovie/Views/Home/Index.cshtml"
       Write(ViewData["Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>");
#nullable restore
#line 14 "/home/student/CodeSchool/IdeaProjects/dotNet/MVcMovie/Views/Home/Index.cshtml"
       Write(ViewData["Year"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>");
#nullable restore
#line 15 "/home/student/CodeSchool/IdeaProjects/dotNet/MVcMovie/Views/Home/Index.cshtml"
       Write(ViewData["FullDate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li> -->\r\n");
#nullable restore
#line 16 "/home/student/CodeSchool/IdeaProjects/dotNet/MVcMovie/Views/Home/Index.cshtml"
         if (Model.Count() < 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h1>There are no movies available</h1>\r\n");
#nullable restore
#line 19 "/home/student/CodeSchool/IdeaProjects/dotNet/MVcMovie/Views/Home/Index.cshtml"
            
        }

        else
        {
            
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "/home/student/CodeSchool/IdeaProjects/dotNet/MVcMovie/Views/Home/Index.cshtml"
             foreach(var movie in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
#nullable restore
#line 27 "/home/student/CodeSchool/IdeaProjects/dotNet/MVcMovie/Views/Home/Index.cshtml"
               Write(movie.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>           \r\n                <li>");
#nullable restore
#line 28 "/home/student/CodeSchool/IdeaProjects/dotNet/MVcMovie/Views/Home/Index.cshtml"
               Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li> \r\n                <li>");
#nullable restore
#line 29 "/home/student/CodeSchool/IdeaProjects/dotNet/MVcMovie/Views/Home/Index.cshtml"
               Write(movie.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li> \r\n                <li>");
#nullable restore
#line 30 "/home/student/CodeSchool/IdeaProjects/dotNet/MVcMovie/Views/Home/Index.cshtml"
               Write(movie.ReleaseDate.ToString("MMMM d, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li> \r\n");
#nullable restore
#line 31 "/home/student/CodeSchool/IdeaProjects/dotNet/MVcMovie/Views/Home/Index.cshtml"
    
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "/home/student/CodeSchool/IdeaProjects/dotNet/MVcMovie/Views/Home/Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVcMovie.Models.Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591