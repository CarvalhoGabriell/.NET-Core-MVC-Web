#pragma checksum "C:\Users\Gabriel\Visual Stuid .NET Core\FIAP\Fiap.Aula.Web.Exemplo01\Fiap.Aula.Web.Exemplo01\Views\Produto\cadastro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b886465318b4332820cb747068c56d995fcaf482"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_cadastro), @"mvc.1.0.view", @"/Views/Produto/cadastro.cshtml")]
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
#line 1 "C:\Users\Gabriel\Visual Stuid .NET Core\FIAP\Fiap.Aula.Web.Exemplo01\Fiap.Aula.Web.Exemplo01\Views\_ViewImports.cshtml"
using Fiap.Aula.Web.Exemplo01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gabriel\Visual Stuid .NET Core\FIAP\Fiap.Aula.Web.Exemplo01\Fiap.Aula.Web.Exemplo01\Views\_ViewImports.cshtml"
using Fiap.Aula.Web.Exemplo01.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b886465318b4332820cb747068c56d995fcaf482", @"/Views/Produto/cadastro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ced56b4fcdd4d25dd6a8d0566b5d0bcda653520", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_cadastro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--");
#nullable restore
#line 1 "C:\Users\Gabriel\Visual Stuid .NET Core\FIAP\Fiap.Aula.Web.Exemplo01\Fiap.Aula.Web.Exemplo01\Views\Produto\cadastro.cshtml"
Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("-->\r\n\r\n");
#nullable restore
#line 3 "C:\Users\Gabriel\Visual Stuid .NET Core\FIAP\Fiap.Aula.Web.Exemplo01\Fiap.Aula.Web.Exemplo01\Views\Produto\cadastro.cshtml"
  
    ViewData["Title"] = "Cadastro";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Cadastro</h1>\r\n<!--\r\n/*");
#nullable restore
#line 8 "C:\Users\Gabriel\Visual Stuid .NET Core\FIAP\Fiap.Aula.Web.Exemplo01\Fiap.Aula.Web.Exemplo01\Views\Produto\cadastro.cshtml"
   if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\" alert alert-danger\">\r\n        <ul>\r\n            <li></li>\r\n            <li></li>\r\n            <li></li>\r\n        </ul>\r\n\r\n    </div>\r\n");
#nullable restore
#line 18 "C:\Users\Gabriel\Visual Stuid .NET Core\FIAP\Fiap.Aula.Web.Exemplo01\Fiap.Aula.Web.Exemplo01\Views\Produto\cadastro.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("*/\r\n-->\r\n<div>\r\n\r\n    Temp Data:\r\n    ");
#nullable restore
#line 24 "C:\Users\Gabriel\Visual Stuid .NET Core\FIAP\Fiap.Aula.Web.Exemplo01\Fiap.Aula.Web.Exemplo01\Views\Produto\cadastro.cshtml"
Write(TempData["msg"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n    ");
#nullable restore
#line 25 "C:\Users\Gabriel\Visual Stuid .NET Core\FIAP\Fiap.Aula.Web.Exemplo01\Fiap.Aula.Web.Exemplo01\Views\Produto\cadastro.cshtml"
Write(TempData["nome"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
#nullable restore
#line 28 "C:\Users\Gabriel\Visual Stuid .NET Core\FIAP\Fiap.Aula.Web.Exemplo01\Fiap.Aula.Web.Exemplo01\Views\Produto\cadastro.cshtml"
 if (ViewBag.prod != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n\r\n        View Bag: ");
#nullable restore
#line 32 "C:\Users\Gabriel\Visual Stuid .NET Core\FIAP\Fiap.Aula.Web.Exemplo01\Fiap.Aula.Web.Exemplo01\Views\Produto\cadastro.cshtml"
             Write(ViewBag.qtd);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 33 "C:\Users\Gabriel\Visual Stuid .NET Core\FIAP\Fiap.Aula.Web.Exemplo01\Fiap.Aula.Web.Exemplo01\Views\Produto\cadastro.cshtml"
   Write(ViewBag.prod.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 34 "C:\Users\Gabriel\Visual Stuid .NET Core\FIAP\Fiap.Aula.Web.Exemplo01\Fiap.Aula.Web.Exemplo01\Views\Produto\cadastro.cshtml"
   Write(ViewBag.prod.Preco);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    </div>\r\n");
#nullable restore
#line 38 "C:\Users\Gabriel\Visual Stuid .NET Core\FIAP\Fiap.Aula.Web.Exemplo01\Fiap.Aula.Web.Exemplo01\Views\Produto\cadastro.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b886465318b4332820cb747068c56d995fcaf4826909", async() => {
                WriteLiteral(@"
    <div class=""mb-3"">
        <label for=""id-nome"" class=""form-label"">Full Name</label>
        <input type=""text"" class=""form-control"" id=""nome"" name=""nome"" placeholder=""Nome do produto"">
    </div>

    <div class=""mb-3"">
        <label for=""id-preco"" class=""form-label"">Price</label>
        <input type=""number"" class=""form-control"" id=""preco"" name=""preco"" placeholder=""R$ 0,00"">
    </div>

    <div class=""mb-3"">
        <label for=""id-qtd"" class=""form-label"">Quantidade (UN)</label>
        <input type=""number"" class=""form-control"" id=""quantidade"" name=""quantidade"" placeholder=""Quantidade unitário"">
    </div>
    <div class=""col-auto"">
        <button type=""submit"" class=""btn btn-outline-success"">Cadastrar</button>
    </div>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
