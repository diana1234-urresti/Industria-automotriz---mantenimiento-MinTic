#pragma checksum "C:\Users\Solarte\Desktop\ciclo 3\proyectos\git\Industria-automotriz---mantenimiento-MinTic\Frontend\Pages\Clientes\Detalles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e380e4e05e132fc3a14c4c3028ad6d88f3dc9439"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Frontend.Pages.Clientes.Pages_Clientes_Detalles), @"mvc.1.0.razor-page", @"/Pages/Clientes/Detalles.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e380e4e05e132fc3a14c4c3028ad6d88f3dc9439", @"/Pages/Clientes/Detalles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10e7216069f48c57b0b0fadbe8f10eca06aff21f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Clientes_Detalles : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            WriteLiteral("<div class=\"justify-content-center text-center\">\r\n    <h2>Detalles Cliente</h2>\r\n    <br>\r\n    <hr><br>\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n    <div class=\"col\"><strong>");
#nullable restore
#line 11 "C:\Users\Solarte\Desktop\ciclo 3\proyectos\git\Industria-automotriz---mantenimiento-MinTic\Frontend\Pages\Clientes\Detalles.cshtml"
                        Write(Html.DisplayNameFor(m => m.Clientes.Ciudad));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></div>\r\n    <div class=\"col\">");
#nullable restore
#line 12 "C:\Users\Solarte\Desktop\ciclo 3\proyectos\git\Industria-automotriz---mantenimiento-MinTic\Frontend\Pages\Clientes\Detalles.cshtml"
                Write(Html.DisplayFor(m => m.Clientes.Ciudad));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"w-100\"></div>\r\n    <div class=\"col\"><strong>");
#nullable restore
#line 14 "C:\Users\Solarte\Desktop\ciclo 3\proyectos\git\Industria-automotriz---mantenimiento-MinTic\Frontend\Pages\Clientes\Detalles.cshtml"
                        Write(Html.DisplayNameFor(m => m.Clientes.FechaIngreso));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></div>\r\n    <div class=\"col\"> ");
#nullable restore
#line 15 "C:\Users\Solarte\Desktop\ciclo 3\proyectos\git\Industria-automotriz---mantenimiento-MinTic\Frontend\Pages\Clientes\Detalles.cshtml"
                 Write(Html.DisplayFor(m => m.Clientes.FechaIngreso));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n <br>\r\n    <hr>\r\n    <div class=\"justify-content-center text-left\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e380e4e05e132fc3a14c4c3028ad6d88f3dc94395061", async() => {
                WriteLiteral("Ir a Gestion Clientes");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.DetallesclienteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DetallesclienteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DetallesclienteModel>)PageContext?.ViewData;
        public MyApp.Namespace.DetallesclienteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
