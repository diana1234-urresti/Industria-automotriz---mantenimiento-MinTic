#pragma checksum "C:\Users\Solarte\Desktop\ciclo 3\proyectos\git\Industria-automotriz---mantenimiento-MinTic\Frontend\Pages\Clientes\listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b29b14f7e9328d7891ab042d18b024045a5b35a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Frontend.Pages.Clientes.Pages_Clientes_listar), @"mvc.1.0.razor-page", @"/Pages/Clientes/listar.cshtml")]
namespace Frontend.Pages.Clientes
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
#line 1 "C:\Users\Solarte\Desktop\ciclo 3\proyectos\git\Industria-automotriz---mantenimiento-MinTic\Frontend\Pages\_ViewImports.cshtml"
using Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b29b14f7e9328d7891ab042d18b024045a5b35a", @"/Pages/Clientes/listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10e7216069f48c57b0b0fadbe8f10eca06aff21f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Clientes_listar : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""justify-content-center text-center"">
    <h1>Lista de Clientes</h1>
    <br>
</div>
<div>
    <table class=""table"">
        <tr>
            <th>ID</th>
            <th>CUIDAD</th>
            <th>FECHA DE INGRESO</th>
            <th>TIPO DE VEHICULO</th>
            
        </tr>
");
#nullable restore
#line 19 "C:\Users\Solarte\Desktop\ciclo 3\proyectos\git\Industria-automotriz---mantenimiento-MinTic\Frontend\Pages\Clientes\listar.cshtml"
         foreach(var cliente in Model.Clientes){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\Solarte\Desktop\ciclo 3\proyectos\git\Industria-automotriz---mantenimiento-MinTic\Frontend\Pages\Clientes\listar.cshtml"
               Write(cliente.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\Solarte\Desktop\ciclo 3\proyectos\git\Industria-automotriz---mantenimiento-MinTic\Frontend\Pages\Clientes\listar.cshtml"
               Write(cliente.Ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\Solarte\Desktop\ciclo 3\proyectos\git\Industria-automotriz---mantenimiento-MinTic\Frontend\Pages\Clientes\listar.cshtml"
               Write(cliente.FechaIngreso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\Solarte\Desktop\ciclo 3\proyectos\git\Industria-automotriz---mantenimiento-MinTic\Frontend\Pages\Clientes\listar.cshtml"
               Write(cliente.TipoVehiculo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                \r\n            </tr>\r\n");
#nullable restore
#line 27 "C:\Users\Solarte\Desktop\ciclo 3\proyectos\git\Industria-automotriz---mantenimiento-MinTic\Frontend\Pages\Clientes\listar.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.listarModelclientes> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.listarModelclientes> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.listarModelclientes>)PageContext?.ViewData;
        public MyApp.Namespace.listarModelclientes Model => ViewData.Model;
    }
}
#pragma warning restore 1591
