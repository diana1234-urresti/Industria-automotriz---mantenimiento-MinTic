#pragma checksum "C:\Users\kdelg\OneDrive\Documentos\MISION TIC 2022\3.DESARROLLO DE SOFTWARE\INDUSTRIA\Industria-automotriz---mantenimiento-MinTic\Frontend\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f2e05845511aabd7312244d1544b9115834ff26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Frontend.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace Frontend.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f2e05845511aabd7312244d1544b9115834ff26", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10e7216069f48c57b0b0fadbe8f10eca06aff21f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\kdelg\OneDrive\Documentos\MISION TIC 2022\3.DESARROLLO DE SOFTWARE\INDUSTRIA\Industria-automotriz---mantenimiento-MinTic\Frontend\Pages\Index.cshtml"
  
    ViewData["Title"] = "Pagina de inicio";
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    
    <h2 class=""display-4"">Taller De Mantenimiento Automotriz</h2>
    <p>EN BACKLOG DAMOS LA TRANQUILIDAD DE QUE TU VEHÍCULO ESTÁ EN BUENAS MANOS, TE OFRECEMOS UNA GRAN GAMA DE SERVICIOS PARA QUE COTICES CON NOSOTROS Y HAGAS LAS REVISIONES DE TU VEHICULO, CON GUSTO TE ATENDEREMOS PARA QUE SIGAMOS RECORRIENDO KILÓMETROS JUNTOS</p>
</div>

<div class=""imagenservicio"">
   <img id=""foto1""  src=""images\MANTO-BACKLOG.png"" width=""300px"">
    <img id=""foto2"" src=""images\ACEITE-BACKLOG.png"" width=""300px"">
    <img id=""foto3"" src=""images\REPUESTOS-BACKLOG.png"" width=""305px""></div>
 

</div>


    

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
