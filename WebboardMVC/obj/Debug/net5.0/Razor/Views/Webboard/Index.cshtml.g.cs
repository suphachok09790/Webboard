#pragma checksum "D:\Learn programing\WebboardMVC\WebboardMVC\Views\Webboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f96eee1886722a4d9e33f5fb7f857bca7f4a6098"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Webboard_Index), @"mvc.1.0.view", @"/Views/Webboard/Index.cshtml")]
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
#line 1 "D:\Learn programing\WebboardMVC\WebboardMVC\Views\_ViewImports.cshtml"
using WebboardMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Learn programing\WebboardMVC\WebboardMVC\Views\_ViewImports.cshtml"
using WebboardMVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Learn programing\WebboardMVC\WebboardMVC\Views\_ViewImports.cshtml"
using WebboardMVC.Models.db;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f96eee1886722a4d9e33f5fb7f857bca7f4a6098", @"/Views/Webboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5331ac1714db0bffed476631ea43db72c0f8df1c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Webboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Kratoo>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"container\">\r\n    <table class=\"table table-responsive table-striped\">\r\n        <tbody>\r\n");
#nullable restore
#line 12 "D:\Learn programing\WebboardMVC\WebboardMVC\Views\Webboard\Index.cshtml"
            foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("             <tr>\r\n                <td>\r\n                    <h4>\r\n                        ");
#nullable restore
#line 17 "D:\Learn programing\WebboardMVC\WebboardMVC\Views\Webboard\Index.cshtml"
                   Write(item.KratooTopic);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h4>       \r\n                    <div>\r\n                        ผู้ตั้งกระทู้ : ");
#nullable restore
#line 20 "D:\Learn programing\WebboardMVC\WebboardMVC\Views\Webboard\Index.cshtml"
                                   Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        (IP : ");
#nullable restore
#line 21 "D:\Learn programing\WebboardMVC\WebboardMVC\Views\Webboard\Index.cshtml"
                         Write(item.UserIp);

#line default
#line hidden
#nullable disable
            WriteLiteral(") |\r\n                        วันที่ตั้งกระทู้ :");
#nullable restore
#line 22 "D:\Learn programing\WebboardMVC\WebboardMVC\Views\Webboard\Index.cshtml"
                                     Write(item.RecordDate?.ToString("dd/MM/yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </td>\r\n                <td>\r\n                    <div>\r\n                        อ่าน : ");
#nullable restore
#line 27 "D:\Learn programing\WebboardMVC\WebboardMVC\Views\Webboard\Index.cshtml"
                          Write(item.ViewCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ตอบ : ");
#nullable restore
#line 28 "D:\Learn programing\WebboardMVC\WebboardMVC\Views\Webboard\Index.cshtml"
                         Write(item.ReplyCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </td>\r\n                <td>");
#nullable restore
#line 31 "D:\Learn programing\WebboardMVC\WebboardMVC\Views\Webboard\Index.cshtml"
               Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n             </tr>\r\n");
#nullable restore
#line 33 "D:\Learn programing\WebboardMVC\WebboardMVC\Views\Webboard\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Kratoo>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
