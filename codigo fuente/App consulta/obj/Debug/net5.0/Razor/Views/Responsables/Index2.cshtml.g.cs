#pragma checksum "C:\Users\rinco\source\repos\App consulta\App consulta\Views\Responsables\Index2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f2dee71d804a608145dda917293b3c1db2f7188"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Responsables_Index2), @"mvc.1.0.view", @"/Views/Responsables/Index2.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f2dee71d804a608145dda917293b3c1db2f7188", @"/Views/Responsables/Index2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"447b7686d26caf9e4eafaf498393ffbee01a0de8", @"/Views/_ViewImports.cshtml")]
    public class Views_Responsables_Index2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<App_consulta.Models.Responsable>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\rinco\source\repos\App consulta\App consulta\Views\Responsables\Index2.cshtml"
  
    ViewData["Title"] = "Panel de control";
    ViewData["Subtitle"] = "";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h4>Dependencias</h4>\r\n");
#nullable restore
#line 9 "C:\Users\rinco\source\repos\App consulta\App consulta\Views\Responsables\Index2.cshtml"
 if (ViewBag.error != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning\" role=\"alert\">\r\n        <span class=\"glyphicon glyphicon-exclamation-sign\" aria-hidden=\"true\"></span>\r\n        <span class=\"sr-only\">Error:</span>\r\n        ");
#nullable restore
#line 14 "C:\Users\rinco\source\repos\App consulta\App consulta\Views\Responsables\Index2.cshtml"
   Write(ViewBag.error);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 16 "C:\Users\rinco\source\repos\App consulta\App consulta\Views\Responsables\Index2.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    ");
#nullable restore
#line 18 "C:\Users\rinco\source\repos\App consulta\App consulta\Views\Responsables\Index2.cshtml"
Write(Html.ActionLink("Nueva dependencia", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<table class=\"table font-smaller\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 23 "C:\Users\rinco\source\repos\App consulta\App consulta\Views\Responsables\Index2.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n      \r\n        <th>\r\n            Usuarios\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 32 "C:\Users\rinco\source\repos\App consulta\App consulta\Views\Responsables\Index2.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\Users\rinco\source\repos\App consulta\App consulta\Views\Responsables\Index2.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n           \r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\rinco\source\repos\App consulta\App consulta\Views\Responsables\Index2.cshtml"
           Write(await Component.InvokeAsync("UsuariosFromResponsable", new { idResponsable = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </td>\r\n            <td>\r\n                <span class=\"button-inline small-button\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\'", 1165, "\'", 1214, 1);
#nullable restore
#line 45 "C:\Users\rinco\source\repos\App consulta\App consulta\Views\Responsables\Index2.cshtml"
WriteAttributeValue("", 1172, Url.Action("Details", new { id=item.Id }), 1172, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default btn-sm\" title=\"Detalles\"><i class=\"fas fa-file-alt\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\'", 1323, "\'", 1369, 1);
#nullable restore
#line 46 "C:\Users\rinco\source\repos\App consulta\App consulta\Views\Responsables\Index2.cshtml"
WriteAttributeValue("", 1330, Url.Action("Edit", new { id=item.Id }), 1330, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default btn-sm\" title=\"Editar\"><i class=\"fas fa-edit\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\'", 1472, "\'", 1520, 1);
#nullable restore
#line 47 "C:\Users\rinco\source\repos\App consulta\App consulta\Views\Responsables\Index2.cshtml"
WriteAttributeValue("", 1479, Url.Action("Delete", new { id=item.Id }), 1479, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default btn-sm\" title=\"Borrar\"><i class=\"fas fa-trash\"></i></a>\r\n                </span>\r\n\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 52 "C:\Users\rinco\source\repos\App consulta\App consulta\Views\Responsables\Index2.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<App_consulta.Models.Responsable>> Html { get; private set; }
    }
}
#pragma warning restore 1591
