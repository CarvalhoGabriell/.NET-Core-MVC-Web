#pragma checksum "C:\Users\Gabriel\Visual Stuid .NET Core\FIAP\Fiap.Aula.Web.Exemplo01\Fiap.CP_1.SofiaBag\Views\Objeto\Pesquisar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9f95d97a62cc50f55acc7dc0273b1f02c1058f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Objeto_Pesquisar), @"mvc.1.0.view", @"/Views/Objeto/Pesquisar.cshtml")]
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
#line 1 "C:\Users\Gabriel\Visual Stuid .NET Core\FIAP\Fiap.Aula.Web.Exemplo01\Fiap.CP_1.SofiaBag\Views\_ViewImports.cshtml"
using Fiap.CP_1.SofiaBag;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gabriel\Visual Stuid .NET Core\FIAP\Fiap.Aula.Web.Exemplo01\Fiap.CP_1.SofiaBag\Views\_ViewImports.cshtml"
using Fiap.CP_1.SofiaBag.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9f95d97a62cc50f55acc7dc0273b1f02c1058f0", @"/Views/Objeto/Pesquisar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4e858ddf696795dd9176131628f9b3a2c721d1a", @"/Views/_ViewImports.cshtml")]
    public class Views_Objeto_Pesquisar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Objetos>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "deletar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Fiap.CP_1.SofiaBag.TagHelpers.SucessMsgTagHelper __Fiap_CP_1_SofiaBag_TagHelpers_SucessMsgTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Gabriel\Visual Stuid .NET Core\FIAP\Fiap.Aula.Web.Exemplo01\Fiap.CP_1.SofiaBag\Views\Objeto\Pesquisar.cshtml"
  
    ViewData["title"] = "Seus Objetos para SofiaBag";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("sucess-msg", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9f95d97a62cc50f55acc7dc0273b1f02c1058f04877", async() => {
            }
            );
            __Fiap_CP_1_SofiaBag_TagHelpers_SucessMsgTagHelper = CreateTagHelper<global::Fiap.CP_1.SofiaBag.TagHelpers.SucessMsgTagHelper>();
            __tagHelperExecutionContext.Add(__Fiap_CP_1_SofiaBag_TagHelpers_SucessMsgTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 7 "C:\Users\Gabriel\Visual Stuid .NET Core\FIAP\Fiap.Aula.Web.Exemplo01\Fiap.CP_1.SofiaBag\Views\Objeto\Pesquisar.cshtml"
          WriteLiteral(TempData["msg"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Fiap_CP_1_SofiaBag_TagHelpers_SucessMsgTagHelper.Mensagem = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("mensagem", __Fiap_CP_1_SofiaBag_TagHelpers_SucessMsgTagHelper.Mensagem, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<button type=""button"" style=""margin-bottom:1rem"" class=""btn btn-primary btn-lg btn-block"">Seus Objetos encontrados</button>

<table class=""table table-hover table-info"">
    <tr>
        <th>RFID</th>
        <th>Nome</th>
        <th>Descrição</th>
        <th>Status Atual</th>
        <th>Data Cadastro</th>
        <th>Cor</th>
        <th>Ações</th>
    </tr>

");
#nullable restore
#line 22 "C:\Users\Gabriel\Visual Stuid .NET Core\FIAP\Fiap.Aula.Web.Exemplo01\Fiap.CP_1.SofiaBag\Views\Objeto\Pesquisar.cshtml"
     foreach (var itens in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Gabriel\Visual Stuid .NET Core\FIAP\Fiap.Aula.Web.Exemplo01\Fiap.CP_1.SofiaBag\Views\Objeto\Pesquisar.cshtml"
           Write(itens.Codigo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\Gabriel\Visual Stuid .NET Core\FIAP\Fiap.Aula.Web.Exemplo01\Fiap.CP_1.SofiaBag\Views\Objeto\Pesquisar.cshtml"
           Write(itens.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\Gabriel\Visual Stuid .NET Core\FIAP\Fiap.Aula.Web.Exemplo01\Fiap.CP_1.SofiaBag\Views\Objeto\Pesquisar.cshtml"
           Write(itens.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\Gabriel\Visual Stuid .NET Core\FIAP\Fiap.Aula.Web.Exemplo01\Fiap.CP_1.SofiaBag\Views\Objeto\Pesquisar.cshtml"
            Write(itens.Ativo?"True":"False");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\Gabriel\Visual Stuid .NET Core\FIAP\Fiap.Aula.Web.Exemplo01\Fiap.CP_1.SofiaBag\Views\Objeto\Pesquisar.cshtml"
           Write(itens.DtCadastro.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\Gabriel\Visual Stuid .NET Core\FIAP\Fiap.Aula.Web.Exemplo01\Fiap.CP_1.SofiaBag\Views\Objeto\Pesquisar.cshtml"
           Write(itens.Cor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <button");
            BeginWriteAttribute("onclick", " onclick=\"", 875, "\"", 915, 3);
            WriteAttributeValue("", 885, "idObject.value", 885, 14, true);
            WriteAttributeValue(" ", 899, "=", 900, 2, true);
#nullable restore
#line 32 "C:\Users\Gabriel\Visual Stuid .NET Core\FIAP\Fiap.Aula.Web.Exemplo01\Fiap.CP_1.SofiaBag\Views\Objeto\Pesquisar.cshtml"
WriteAttributeValue(" ", 901, itens.Codigo, 902, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-sm btn-danger\" data-toggle=\"modal\" data-target=\"#exampleModal\">Remover</button>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9f95d97a62cc50f55acc7dc0273b1f02c1058f09639", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\Gabriel\Visual Stuid .NET Core\FIAP\Fiap.Aula.Web.Exemplo01\Fiap.CP_1.SofiaBag\Views\Objeto\Pesquisar.cshtml"
                                                                     WriteLiteral(itens.Codigo);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 37 "C:\Users\Gabriel\Visual Stuid .NET Core\FIAP\Fiap.Aula.Web.Exemplo01\Fiap.CP_1.SofiaBag\Views\Objeto\Pesquisar.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</table>


<!-- Modal -->
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Confirmação Remover</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>

            <div class=""modal-body"">
                Ops :( <br />
                Deseja Mesmo Deletar esse Objeto? <br />
                Adeus Sofia...
            </div>
            <div class=""modal-footer"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9f95d97a62cc50f55acc7dc0273b1f02c1058f013038", async() => {
                WriteLiteral(@"
                    <!-- O atributo ""id deve ser o mesmo informado no metodo POST da action de remover""-->
                    <input type=""hidden"" name=""id"" id=""idObject"" />
                    <button type=""button"" class=""btn btn-success"" data-dismiss=""modal"">Cancelar</button>
                    <button type=""submit"" class=""btn btn-danger"">Sim</button>

                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Objetos>> Html { get; private set; }
    }
}
#pragma warning restore 1591