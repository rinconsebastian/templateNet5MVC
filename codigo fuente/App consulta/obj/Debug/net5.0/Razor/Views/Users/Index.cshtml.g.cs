#pragma checksum "C:\Users\rinco\source\repos\App consulta\App consulta\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3478899f8985256c793cf5dc22fc294923671898"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
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
#line 1 "C:\Users\rinco\source\repos\App consulta\App consulta\Views\_ViewImports.cshtml"
using App_consulta;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rinco\source\repos\App consulta\App consulta\Views\_ViewImports.cshtml"
using App_consulta.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3478899f8985256c793cf5dc22fc294923671898", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"447b7686d26caf9e4eafaf498393ffbee01a0de8", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<App_consulta.Models.ApplicationUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\rinco\source\repos\App consulta\App consulta\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Panel de control";
    ViewData["Subtitle"] = "";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h4>Usuarios</h4>\r\n");
#nullable restore
#line 9 "C:\Users\rinco\source\repos\App consulta\App consulta\Views\Users\Index.cshtml"
 if (ViewBag.error != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning\" role=\"alert\">\r\n        <span class=\"glyphicon glyphicon-exclamation-sign\" aria-hidden=\"true\"></span>\r\n        <span class=\"sr-only\">Error:</span>\r\n        ");
#nullable restore
#line 14 "C:\Users\rinco\source\repos\App consulta\App consulta\Views\Users\Index.cshtml"
   Write(ViewBag.error);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 16 "C:\Users\rinco\source\repos\App consulta\App consulta\Views\Users\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    ");
#nullable restore
#line 18 "C:\Users\rinco\source\repos\App consulta\App consulta\Views\Users\Index.cshtml"
Write(Html.ActionLink("Nuevo usuario", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<table class=\"table font-smaller\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 23 "C:\Users\rinco\source\repos\App consulta\App consulta\Views\Users\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 26 "C:\Users\rinco\source\repos\App consulta\App consulta\Views\Users\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 29 "C:\Users\rinco\source\repos\App consulta\App consulta\Views\Users\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.IDDependencia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 32 "C:\Users\rinco\source\repos\App consulta\App consulta\Views\Users\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 35 "C:\Users\rinco\source\repos\App consulta\App consulta\Views\Users\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.EmailConfirmed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 40 "C:\Users\rinco\source\repos\App consulta\App consulta\Views\Users\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\rinco\source\repos\App consulta\App consulta\Views\Users\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\Users\rinco\source\repos\App consulta\App consulta\Views\Users\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\rinco\source\repos\App consulta\App consulta\Views\Users\Index.cshtml"
           Write(await Component.InvokeAsync("DependenciaNombre", new { id = item.IDDependencia }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\rinco\source\repos\App consulta\App consulta\Views\Users\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"text-center\">\r\n                ");
#nullable restore
#line 56 "C:\Users\rinco\source\repos\App consulta\App consulta\Views\Users\Index.cshtml"
            Write(item.EmailConfirmed ? "Si" : "No");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <span class=\"button-inline small-button\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\'", 1747, "\'", 1796, 1);
#nullable restore
#line 60 "C:\Users\rinco\source\repos\App consulta\App consulta\Views\Users\Index.cshtml"
WriteAttributeValue("", 1754, Url.Action("Details", new { id=item.Id }), 1754, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default btn-sm\" title=\"Detalles\"><i class=\"fas fa-file-alt\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\'", 1905, "\'", 1951, 1);
#nullable restore
#line 61 "C:\Users\rinco\source\repos\App consulta\App consulta\Views\Users\Index.cshtml"
WriteAttributeValue("", 1912, Url.Action("Edit", new { id=item.Id }), 1912, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default btn-sm\" title=\"Editar\"><i class=\"fas fa-edit\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\'", 2054, "\'", 2102, 1);
#nullable restore
#line 62 "C:\Users\rinco\source\repos\App consulta\App consulta\Views\Users\Index.cshtml"
WriteAttributeValue("", 2061, Url.Action("Delete", new { id=item.Id }), 2061, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default btn-sm\" title=\"Borrar\"><i class=\"fas fa-trash\"></i></a>\r\n                </span>\r\n\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 67 "C:\Users\rinco\source\repos\App consulta\App consulta\Views\Users\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<App_consulta.Models.ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
