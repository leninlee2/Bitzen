#pragma checksum "C:\Users\2560p\source\repos\Bitzen_LeninAguiar\Bitzen_LeninAguiar\Views\Vehicle\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41965c1fe4191bc139c6cfcf77b3c8af3c0d0759"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehicle_Index), @"mvc.1.0.view", @"/Views/Vehicle/Index.cshtml")]
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
#line 1 "C:\Users\2560p\source\repos\Bitzen_LeninAguiar\Bitzen_LeninAguiar\Views\_ViewImports.cshtml"
using Bitzen_LeninAguiar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\2560p\source\repos\Bitzen_LeninAguiar\Bitzen_LeninAguiar\Views\_ViewImports.cshtml"
using Bitzen_LeninAguiar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41965c1fe4191bc139c6cfcf77b3c8af3c0d0759", @"/Views/Vehicle/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3d314c185fd0cb7c4de9f24cdf87538e9c8fcc8", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehicle_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VehicleViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\2560p\source\repos\Bitzen_LeninAguiar\Bitzen_LeninAguiar\Views\Vehicle\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Consulta de Veiculos</h3>\r\n<div class=\"container-fluid\" >\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 10 "C:\Users\2560p\source\repos\Bitzen_LeninAguiar\Bitzen_LeninAguiar\Views\Vehicle\Index.cshtml"
       Write(Html.ActionLink("Novo Veiculo", "Create", "Vehicle", new { }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
    <div class=""row"">
        <div class=""col-sm-10"">
            <table id=""vehicles"" class=""table table-striped table-bordered"" style=""width:100%"">
                <thead>
                    <tr>
                        <th>Marca</th>
                        <th>Modelo</th>
                        <th>/</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 24 "C:\Users\2560p\source\repos\Bitzen_LeninAguiar\Bitzen_LeninAguiar\Views\Vehicle\Index.cshtml"
                     if (Model.vehicles != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\2560p\source\repos\Bitzen_LeninAguiar\Bitzen_LeninAguiar\Views\Vehicle\Index.cshtml"
                         foreach (var item in Model.vehicles)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th>");
#nullable restore
#line 29 "C:\Users\2560p\source\repos\Bitzen_LeninAguiar\Bitzen_LeninAguiar\Views\Vehicle\Index.cshtml"
                               Write(item.brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 30 "C:\Users\2560p\source\repos\Bitzen_LeninAguiar\Bitzen_LeninAguiar\Views\Vehicle\Index.cshtml"
                               Write(item.model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>/</th>\r\n                            </tr>\r\n");
#nullable restore
#line 33 "C:\Users\2560p\source\repos\Bitzen_LeninAguiar\Bitzen_LeninAguiar\Views\Vehicle\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\2560p\source\repos\Bitzen_LeninAguiar\Bitzen_LeninAguiar\Views\Vehicle\Index.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VehicleViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591