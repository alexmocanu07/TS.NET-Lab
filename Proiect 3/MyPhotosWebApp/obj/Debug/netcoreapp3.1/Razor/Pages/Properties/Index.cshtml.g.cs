#pragma checksum "D:\GitHub\TS.Net-Lab\MyPhotosWebApp\Pages\Properties\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c902c3a3de4060605929a336e56ad5716e68ebd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyPhotosWebApp.Pages.Properties.Pages_Properties_Index), @"mvc.1.0.razor-page", @"/Pages/Properties/Index.cshtml")]
namespace MyPhotosWebApp.Pages.Properties
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
#line 1 "D:\GitHub\TS.Net-Lab\MyPhotosWebApp\Pages\_ViewImports.cshtml"
using MyPhotosWebApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c902c3a3de4060605929a336e56ad5716e68ebd", @"/Pages/Properties/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"885064f16969f706af01cc520d62bd748bebf6dc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Properties_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\GitHub\TS.Net-Lab\MyPhotosWebApp\Pages\Properties\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>File Properties</h1>\r\n<h2>Image name: ");
#nullable restore
#line 8 "D:\GitHub\TS.Net-Lab\MyPhotosWebApp\Pages\Properties\Index.cshtml"
           Write(Model.imageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "D:\GitHub\TS.Net-Lab\MyPhotosWebApp\Pages\Properties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Properties[0].Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\GitHub\TS.Net-Lab\MyPhotosWebApp\Pages\Properties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Properties[0].Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\GitHub\TS.Net-Lab\MyPhotosWebApp\Pages\Properties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Properties[0].Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "D:\GitHub\TS.Net-Lab\MyPhotosWebApp\Pages\Properties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Properties[0].DataType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n           \r\n            <th>\r\n                Value\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 32 "D:\GitHub\TS.Net-Lab\MyPhotosWebApp\Pages\Properties\Index.cshtml"
         foreach (var item in Model.propertyValueDictionary)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr style=\"font-size:small\">\r\n            <td>\r\n                ");
#nullable restore
#line 36 "D:\GitHub\TS.Net-Lab\MyPhotosWebApp\Pages\Properties\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Key.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "D:\GitHub\TS.Net-Lab\MyPhotosWebApp\Pages\Properties\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Key.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "D:\GitHub\TS.Net-Lab\MyPhotosWebApp\Pages\Properties\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Key.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "D:\GitHub\TS.Net-Lab\MyPhotosWebApp\Pages\Properties\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Key.DataType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "D:\GitHub\TS.Net-Lab\MyPhotosWebApp\Pages\Properties\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 52 "D:\GitHub\TS.Net-Lab\MyPhotosWebApp\Pages\Properties\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyPhotosWebApp.Pages.Properties.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyPhotosWebApp.Pages.Properties.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyPhotosWebApp.Pages.Properties.IndexModel>)PageContext?.ViewData;
        public MyPhotosWebApp.Pages.Properties.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
