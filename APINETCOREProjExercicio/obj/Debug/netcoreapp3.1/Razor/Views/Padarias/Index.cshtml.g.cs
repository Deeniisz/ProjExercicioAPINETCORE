#pragma checksum "C:\Users\assis\source\repos\APINETCOREProjExercicio\APINETCOREProjExercicio\Views\Padarias\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40de71def36494ba8241ccc7976df6684e66d03c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Padarias_Index), @"mvc.1.0.view", @"/Views/Padarias/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40de71def36494ba8241ccc7976df6684e66d03c", @"/Views/Padarias/Index.cshtml")]
    public class Views_Padarias_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<APINETCOREProjExercicio.Model.Padaria>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\assis\source\repos\APINETCOREProjExercicio\APINETCOREProjExercicio\Views\Padarias\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\assis\source\repos\APINETCOREProjExercicio\APINETCOREProjExercicio\Views\Padarias\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\assis\source\repos\APINETCOREProjExercicio\APINETCOREProjExercicio\Views\Padarias\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CNPJ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\assis\source\repos\APINETCOREProjExercicio\APINETCOREProjExercicio\Views\Padarias\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.QtdFuncionarios));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\assis\source\repos\APINETCOREProjExercicio\APINETCOREProjExercicio\Views\Padarias\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Endereco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\assis\source\repos\APINETCOREProjExercicio\APINETCOREProjExercicio\Views\Padarias\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Telephone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\assis\source\repos\APINETCOREProjExercicio\APINETCOREProjExercicio\Views\Padarias\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\assis\source\repos\APINETCOREProjExercicio\APINETCOREProjExercicio\Views\Padarias\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\assis\source\repos\APINETCOREProjExercicio\APINETCOREProjExercicio\Views\Padarias\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CNPJ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\assis\source\repos\APINETCOREProjExercicio\APINETCOREProjExercicio\Views\Padarias\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.QtdFuncionarios));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\assis\source\repos\APINETCOREProjExercicio\APINETCOREProjExercicio\Views\Padarias\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Endereco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\assis\source\repos\APINETCOREProjExercicio\APINETCOREProjExercicio\Views\Padarias\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Telephone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1386, "\"", 1409, 1);
#nullable restore
#line 52 "C:\Users\assis\source\repos\APINETCOREProjExercicio\APINETCOREProjExercicio\Views\Padarias\Index.cshtml"
WriteAttributeValue("", 1401, item.Id, 1401, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1462, "\"", 1485, 1);
#nullable restore
#line 53 "C:\Users\assis\source\repos\APINETCOREProjExercicio\APINETCOREProjExercicio\Views\Padarias\Index.cshtml"
WriteAttributeValue("", 1477, item.Id, 1477, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1540, "\"", 1563, 1);
#nullable restore
#line 54 "C:\Users\assis\source\repos\APINETCOREProjExercicio\APINETCOREProjExercicio\Views\Padarias\Index.cshtml"
WriteAttributeValue("", 1555, item.Id, 1555, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 57 "C:\Users\assis\source\repos\APINETCOREProjExercicio\APINETCOREProjExercicio\Views\Padarias\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<APINETCOREProjExercicio.Model.Padaria>> Html { get; private set; }
    }
}
#pragma warning restore 1591
