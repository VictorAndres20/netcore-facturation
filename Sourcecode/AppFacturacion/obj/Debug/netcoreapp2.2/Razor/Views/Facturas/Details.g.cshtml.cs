#pragma checksum "/home/victorandres/NET_Core-projects/AppFacturacion/Views/Facturas/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b39f1215892f6a81a180cb761ae79a1703de573"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Facturas_Details), @"mvc.1.0.view", @"/Views/Facturas/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Facturas/Details.cshtml", typeof(AspNetCore.Views_Facturas_Details))]
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
#line 1 "/home/victorandres/NET_Core-projects/AppFacturacion/Views/_ViewImports.cshtml"
using AppFacturacion;

#line default
#line hidden
#line 2 "/home/victorandres/NET_Core-projects/AppFacturacion/Views/Facturas/Details.cshtml"
using AppFacturacion.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b39f1215892f6a81a180cb761ae79a1703de573", @"/Views/Facturas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bff263f4574116e4a85f5f14745768461c1a59c7", @"/Views/_ViewImports.cshtml")]
    public class Views_Facturas_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppFacturacion.Models.Facturas>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Detalles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "/home/victorandres/NET_Core-projects/AppFacturacion/Views/Facturas/Details.cshtml"
  
    ViewData["Title"] = "Info";

#line default
#line hidden
            BeginContext(111, 236, true);
            WriteLiteral("<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-6 text-center\">\r\n            <h3>Información de factura</h3>\r\n        </div>\r\n        <div class=\"col-sm-6 text-center\">\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(347, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b39f1215892f6a81a180cb761ae79a1703de5735959", async() => {
                BeginContext(390, 54, true);
                WriteLiteral("<i class=\"fas fa-arrow-circle-left\"></i> Ir a facturas");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(448, 270, true);
            WriteLiteral(@"
            </p>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-sm-6"">
            <h4>Factura</h4>
            <hr />
            <div class=""row"" style=""font-size: 12px;"">
                <dt class = ""col-sm-5"">
                    ");
            EndContext();
            BeginContext(719, 49, false);
#line 24 "/home/victorandres/NET_Core-projects/AppFacturacion/Views/Facturas/Details.cshtml"
               Write(Html.DisplayNameFor(model => model.NumeroFactura));

#line default
#line hidden
            EndContext();
            BeginContext(768, 86, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class = \"col-sm-7\">\r\n                    ");
            EndContext();
            BeginContext(855, 45, false);
#line 27 "/home/victorandres/NET_Core-projects/AppFacturacion/Views/Facturas/Details.cshtml"
               Write(Html.DisplayFor(model => model.NumeroFactura));

#line default
#line hidden
            EndContext();
            BeginContext(900, 86, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class = \"col-sm-5\">\r\n                    ");
            EndContext();
            BeginContext(987, 41, false);
#line 30 "/home/victorandres/NET_Core-projects/AppFacturacion/Views/Facturas/Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Fecha));

#line default
#line hidden
            EndContext();
            BeginContext(1028, 86, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class = \"col-sm-7\">\r\n                    ");
            EndContext();
            BeginContext(1115, 37, false);
#line 33 "/home/victorandres/NET_Core-projects/AppFacturacion/Views/Facturas/Details.cshtml"
               Write(Html.DisplayFor(model => model.Fecha));

#line default
#line hidden
            EndContext();
            BeginContext(1152, 86, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class = \"col-sm-5\">\r\n                    ");
            EndContext();
            BeginContext(1239, 46, false);
#line 36 "/home/victorandres/NET_Core-projects/AppFacturacion/Views/Facturas/Details.cshtml"
               Write(Html.DisplayNameFor(model => model.TipodePago));

#line default
#line hidden
            EndContext();
            BeginContext(1285, 86, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class = \"col-sm-7\">\r\n                    ");
            EndContext();
            BeginContext(1372, 42, false);
#line 39 "/home/victorandres/NET_Core-projects/AppFacturacion/Views/Facturas/Details.cshtml"
               Write(Html.DisplayFor(model => model.TipodePago));

#line default
#line hidden
            EndContext();
            BeginContext(1414, 86, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class = \"col-sm-5\">\r\n                    ");
            EndContext();
            BeginContext(1501, 52, false);
#line 42 "/home/victorandres/NET_Core-projects/AppFacturacion/Views/Facturas/Details.cshtml"
               Write(Html.DisplayNameFor(model => model.DocumentoCliente));

#line default
#line hidden
            EndContext();
            BeginContext(1553, 86, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class = \"col-sm-7\">\r\n                    ");
            EndContext();
            BeginContext(1640, 48, false);
#line 45 "/home/victorandres/NET_Core-projects/AppFacturacion/Views/Facturas/Details.cshtml"
               Write(Html.DisplayFor(model => model.DocumentoCliente));

#line default
#line hidden
            EndContext();
            BeginContext(1688, 86, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class = \"col-sm-5\">\r\n                    ");
            EndContext();
            BeginContext(1775, 49, false);
#line 48 "/home/victorandres/NET_Core-projects/AppFacturacion/Views/Facturas/Details.cshtml"
               Write(Html.DisplayNameFor(model => model.NombreCliente));

#line default
#line hidden
            EndContext();
            BeginContext(1824, 86, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class = \"col-sm-7\">\r\n                    ");
            EndContext();
            BeginContext(1911, 45, false);
#line 51 "/home/victorandres/NET_Core-projects/AppFacturacion/Views/Facturas/Details.cshtml"
               Write(Html.DisplayFor(model => model.NombreCliente));

#line default
#line hidden
            EndContext();
            BeginContext(1956, 86, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class = \"col-sm-5\">\r\n                    ");
            EndContext();
            BeginContext(2043, 44, false);
#line 54 "/home/victorandres/NET_Core-projects/AppFacturacion/Views/Facturas/Details.cshtml"
               Write(Html.DisplayNameFor(model => model.SubTotal));

#line default
#line hidden
            EndContext();
            BeginContext(2087, 86, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class = \"col-sm-7\">\r\n                    ");
            EndContext();
            BeginContext(2174, 40, false);
#line 57 "/home/victorandres/NET_Core-projects/AppFacturacion/Views/Facturas/Details.cshtml"
               Write(Html.DisplayFor(model => model.SubTotal));

#line default
#line hidden
            EndContext();
            BeginContext(2214, 86, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class = \"col-sm-5\">\r\n                    ");
            EndContext();
            BeginContext(2301, 45, false);
#line 60 "/home/victorandres/NET_Core-projects/AppFacturacion/Views/Facturas/Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Descuento));

#line default
#line hidden
            EndContext();
            BeginContext(2346, 86, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class = \"col-sm-7\">\r\n                    ");
            EndContext();
            BeginContext(2433, 41, false);
#line 63 "/home/victorandres/NET_Core-projects/AppFacturacion/Views/Facturas/Details.cshtml"
               Write(Html.DisplayFor(model => model.Descuento));

#line default
#line hidden
            EndContext();
            BeginContext(2474, 86, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class = \"col-sm-5\">\r\n                    ");
            EndContext();
            BeginContext(2561, 39, false);
#line 66 "/home/victorandres/NET_Core-projects/AppFacturacion/Views/Facturas/Details.cshtml"
               Write(Html.DisplayNameFor(model => model.IVA));

#line default
#line hidden
            EndContext();
            BeginContext(2600, 86, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class = \"col-sm-7\">\r\n                    ");
            EndContext();
            BeginContext(2687, 35, false);
#line 69 "/home/victorandres/NET_Core-projects/AppFacturacion/Views/Facturas/Details.cshtml"
               Write(Html.DisplayFor(model => model.IVA));

#line default
#line hidden
            EndContext();
            BeginContext(2722, 86, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class = \"col-sm-5\">\r\n                    ");
            EndContext();
            BeginContext(2809, 50, false);
#line 72 "/home/victorandres/NET_Core-projects/AppFacturacion/Views/Facturas/Details.cshtml"
               Write(Html.DisplayNameFor(model => model.TotalDescuento));

#line default
#line hidden
            EndContext();
            BeginContext(2859, 86, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class = \"col-sm-7\">\r\n                    ");
            EndContext();
            BeginContext(2946, 46, false);
#line 75 "/home/victorandres/NET_Core-projects/AppFacturacion/Views/Facturas/Details.cshtml"
               Write(Html.DisplayFor(model => model.TotalDescuento));

#line default
#line hidden
            EndContext();
            BeginContext(2992, 86, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class = \"col-sm-5\">\r\n                    ");
            EndContext();
            BeginContext(3079, 49, false);
#line 78 "/home/victorandres/NET_Core-projects/AppFacturacion/Views/Facturas/Details.cshtml"
               Write(Html.DisplayNameFor(model => model.TotalImpuesto));

#line default
#line hidden
            EndContext();
            BeginContext(3128, 86, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class = \"col-sm-7\">\r\n                    ");
            EndContext();
            BeginContext(3215, 45, false);
#line 81 "/home/victorandres/NET_Core-projects/AppFacturacion/Views/Facturas/Details.cshtml"
               Write(Html.DisplayFor(model => model.TotalImpuesto));

#line default
#line hidden
            EndContext();
            BeginContext(3260, 86, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class = \"col-sm-5\">\r\n                    ");
            EndContext();
            BeginContext(3347, 41, false);
#line 84 "/home/victorandres/NET_Core-projects/AppFacturacion/Views/Facturas/Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
            EndContext();
            BeginContext(3388, 86, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class = \"col-sm-7\">\r\n                    ");
            EndContext();
            BeginContext(3475, 37, false);
#line 87 "/home/victorandres/NET_Core-projects/AppFacturacion/Views/Facturas/Details.cshtml"
               Write(Html.DisplayFor(model => model.Total));

#line default
#line hidden
            EndContext();
            BeginContext(3512, 80, true);
            WriteLiteral("\r\n                </dd>\r\n            </div>\r\n            <div>\r\n                ");
            EndContext();
            BeginContext(3592, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b39f1215892f6a81a180cb761ae79a1703de57317607", async() => {
                BeginContext(3669, 34, true);
                WriteLiteral("<i class=\"far fa-edit\"></i> Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 91 "/home/victorandres/NET_Core-projects/AppFacturacion/Views/Facturas/Details.cshtml"
                                                               WriteLiteral(Model.idFactura);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3707, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(3725, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b39f1215892f6a81a180cb761ae79a1703de57320066", async() => {
                BeginContext(3768, 54, true);
                WriteLiteral("<i class=\"fas fa-arrow-circle-left\"></i> Ir a facturas");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3826, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(3844, 159, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b39f1215892f6a81a180cb761ae79a1703de57321568", async() => {
                BeginContext(3949, 50, true);
                WriteLiteral("<i class=\"fas fa-dollar-sign\"></i> Agregar detalle");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 93 "/home/victorandres/NET_Core-projects/AppFacturacion/Views/Facturas/Details.cshtml"
                                                                   WriteLiteral(Model.idFactura);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4003, 99, true);
            WriteLiteral("\r\n            </div>\r\n        </div> \r\n        <div class=\"col-sm-6\">\r\n            <h4>Detalles de ");
            EndContext();
            BeginContext(4103, 45, false);
#line 97 "/home/victorandres/NET_Core-projects/AppFacturacion/Views/Facturas/Details.cshtml"
                       Write(Html.DisplayFor(model => model.NombreCliente));

#line default
#line hidden
            EndContext();
            BeginContext(4148, 511, true);
            WriteLiteral(@" </h4>
            <hr />
            <table class=""table custom-table"">
                <thead>
                    <tr>
                        <th>
                            Producto
                        </th>
                        <th>
                            Cantidad
                        </th>
                        <th>
                            Precio por unidad
                        </th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 114 "/home/victorandres/NET_Core-projects/AppFacturacion/Views/Facturas/Details.cshtml"
                 foreach (var item in ViewData["detalles"] as IEnumerable<Detalles>) {

#line default
#line hidden
            BeginContext(4747, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(4844, 53, false);
#line 117 "/home/victorandres/NET_Core-projects/AppFacturacion/Views/Facturas/Details.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Productos.Producto));

#line default
#line hidden
            EndContext();
            BeginContext(4897, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(5001, 43, false);
#line 120 "/home/victorandres/NET_Core-projects/AppFacturacion/Views/Facturas/Details.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(5044, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(5148, 49, false);
#line 123 "/home/victorandres/NET_Core-projects/AppFacturacion/Views/Facturas/Details.cshtml"
                           Write(Html.DisplayFor(modelItem => item.PrecioUnitario));

#line default
#line hidden
            EndContext();
            BeginContext(5197, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 126 "/home/victorandres/NET_Core-projects/AppFacturacion/Views/Facturas/Details.cshtml"
                }

#line default
#line hidden
            BeginContext(5284, 89, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>   \r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppFacturacion.Models.Facturas> Html { get; private set; }
    }
}
#pragma warning restore 1591
