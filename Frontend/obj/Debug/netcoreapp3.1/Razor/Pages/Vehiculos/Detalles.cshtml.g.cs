#pragma checksum "C:\Users\kdelg\OneDrive\Documentos\MISION TIC 2022\3.DESARROLLO DE SOFTWARE\INDUSTRIA\Industria-automotriz---mantenimiento-MinTic\Frontend\Pages\Vehiculos\Detalles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d88d675cae0df0e14deed33a29b9ee75c9d2f35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Frontend.Pages.Vehiculos.Pages_Vehiculos_Detalles), @"mvc.1.0.razor-page", @"/Pages/Vehiculos/Detalles.cshtml")]
namespace Frontend.Pages.Vehiculos
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
#line 1 "C:\Users\kdelg\OneDrive\Documentos\MISION TIC 2022\3.DESARROLLO DE SOFTWARE\INDUSTRIA\Industria-automotriz---mantenimiento-MinTic\Frontend\Pages\_ViewImports.cshtml"
using Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d88d675cae0df0e14deed33a29b9ee75c9d2f35", @"/Pages/Vehiculos/Detalles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10e7216069f48c57b0b0fadbe8f10eca06aff21f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Vehiculos_Detalles : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./listar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""justify-content-center text-center"">
    <h2>Detalles Del Vehiculo</h2>
    <br>
    <hr><br>

      <table class=""table-hover"" width=""600"" height=""300""  align=""center"" asp-validation-summary=""ModelOnly"" class=""text-danger"" >
    <tr>
      <td width=""260"" style=""font-size:0.4cm;"">Tipo de Vehiculo</td>
      <td width=""340"">");
#nullable restore
#line 13 "C:\Users\kdelg\OneDrive\Documentos\MISION TIC 2022\3.DESARROLLO DE SOFTWARE\INDUSTRIA\Industria-automotriz---mantenimiento-MinTic\Frontend\Pages\Vehiculos\Detalles.cshtml"
                 Write(Html.DisplayFor(m => m.vehiculo.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n       \r\n      </td>\r\n    </tr>\r\n    <tr>\r\n      <td width=\"260\" style=\"font-size:0.4cm;\">Matricula</td>\r\n      <td width=\"340\">");
#nullable restore
#line 19 "C:\Users\kdelg\OneDrive\Documentos\MISION TIC 2022\3.DESARROLLO DE SOFTWARE\INDUSTRIA\Industria-automotriz---mantenimiento-MinTic\Frontend\Pages\Vehiculos\Detalles.cshtml"
                 Write(Html.DisplayFor(m => m.vehiculo.Matricula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n       \r\n      </td>\r\n    <tr>\r\n      <td width=\"260\" style=\"font-size:0.4cm;\">Modelo</td>\r\n      <td width=\"340\">");
#nullable restore
#line 24 "C:\Users\kdelg\OneDrive\Documentos\MISION TIC 2022\3.DESARROLLO DE SOFTWARE\INDUSTRIA\Industria-automotriz---mantenimiento-MinTic\Frontend\Pages\Vehiculos\Detalles.cshtml"
                 Write(Html.DisplayFor(m => m.vehiculo.Modelo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </td>\r\n    </tr>\r\n    <tr>\r\n      <td width=\"260\" style=\"font-size:0.4cm;\">Marca</td>\r\n      <td width=\"340\">");
#nullable restore
#line 29 "C:\Users\kdelg\OneDrive\Documentos\MISION TIC 2022\3.DESARROLLO DE SOFTWARE\INDUSTRIA\Industria-automotriz---mantenimiento-MinTic\Frontend\Pages\Vehiculos\Detalles.cshtml"
                 Write(Html.DisplayFor(m => m.vehiculo.Marca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n       \r\n      </td>\r\n    </tr>\r\n    <tr>\r\n      <td width=\"260\"style=\"font-size:0.4cm;\" >Fecha de Ingreso</td>\r\n      <td width=\"340\">");
#nullable restore
#line 35 "C:\Users\kdelg\OneDrive\Documentos\MISION TIC 2022\3.DESARROLLO DE SOFTWARE\INDUSTRIA\Industria-automotriz---mantenimiento-MinTic\Frontend\Pages\Vehiculos\Detalles.cshtml"
                 Write(Html.DisplayFor(m => m.vehiculo.FechaIngreso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </td>\r\n    </tr>  \r\n    <tr>\r\n      <td width=\"260\" style=\"font-size:0.4cm;\">Tipo de falla</td>\r\n      <td width=\"340\">");
#nullable restore
#line 40 "C:\Users\kdelg\OneDrive\Documentos\MISION TIC 2022\3.DESARROLLO DE SOFTWARE\INDUSTRIA\Industria-automotriz---mantenimiento-MinTic\Frontend\Pages\Vehiculos\Detalles.cshtml"
                 Write(Html.DisplayFor(m => m.vehiculo.Tipo_de_falla));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    </tr>\r\n    <tr>\r\n     \r\n    </tr>\r\n    </table>\r\n <br>\r\n    <hr>\r\n    <div class=\"justify-content-center text-left\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d88d675cae0df0e14deed33a29b9ee75c9d2f356743", async() => {
                WriteLiteral("Ir a Gestion Vehiculo");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.DetallesvehiculoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DetallesvehiculoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DetallesvehiculoModel>)PageContext?.ViewData;
        public MyApp.Namespace.DetallesvehiculoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591