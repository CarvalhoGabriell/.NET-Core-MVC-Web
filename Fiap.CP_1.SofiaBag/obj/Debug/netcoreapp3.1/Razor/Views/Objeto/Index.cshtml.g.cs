#pragma checksum "C:\Users\Mateus\source\repos\.NET-Core-MVC-Web\Fiap.CP_1.SofiaBag\Views\Objeto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b2049794c165c23121322506bbb9bae15e4f0f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Objeto_Index), @"mvc.1.0.view", @"/Views/Objeto/Index.cshtml")]
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
#line 1 "C:\Users\Mateus\source\repos\.NET-Core-MVC-Web\Fiap.CP_1.SofiaBag\Views\_ViewImports.cshtml"
using Fiap.CP_1.SofiaBag;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mateus\source\repos\.NET-Core-MVC-Web\Fiap.CP_1.SofiaBag\Views\_ViewImports.cshtml"
using Fiap.CP_1.SofiaBag.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b2049794c165c23121322506bbb9bae15e4f0f6", @"/Views/Objeto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4e858ddf696795dd9176131628f9b3a2c721d1a", @"/Views/_ViewImports.cshtml")]
    public class Views_Objeto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Objetos>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:greenyellow"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row row-cols-lg-auto g-3 align-items-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("mensagem", "Nenhum objeto cadastrado atualmente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", "alert alert-warning", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "deletar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Mateus\source\repos\.NET-Core-MVC-Web\Fiap.CP_1.SofiaBag\Views\Objeto\Index.cshtml"
  
    ViewData["title"] = "Seus Objetos para SofiaBag";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("sucess-msg", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b2049794c165c23121322506bbb9bae15e4f0f66815", async() => {
            }
            );
            __Fiap_CP_1_SofiaBag_TagHelpers_SucessMsgTagHelper = CreateTagHelper<global::Fiap.CP_1.SofiaBag.TagHelpers.SucessMsgTagHelper>();
            __tagHelperExecutionContext.Add(__Fiap_CP_1_SofiaBag_TagHelpers_SucessMsgTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 7 "C:\Users\Mateus\source\repos\.NET-Core-MVC-Web\Fiap.CP_1.SofiaBag\Views\Objeto\Index.cshtml"
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
            WriteLiteral("\r\n\r\n<button type=\"button\" style=\"margin-bottom:1rem\" class=\"btn btn-primary btn-lg btn-block\">Seus Objetos Cadastrados</button>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b2049794c165c23121322506bbb9bae15e4f0f68527", async() => {
                WriteLiteral(@"
    <div class=""col-8"" style=""margin-bottom:9px"">
        <div class=""input-group"">
            <div class=""input-group-text"">Filtro</div>
            <input class=""form-control"" type=""text"" name=""nomeBuscado"" id=""nomeBuscado"" placeholder=""Digite um Nome..."">
        </div>
    </div>

    <div class=""col-2"" style=""margin-bottom:10px"">
        <input type=""submit"" class=""btn btn-primary"" value=""Pesquisar"" />
    </div>

    <div class=""col-2"" style=""margin-bottom:10px"">
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b2049794c165c23121322506bbb9bae15e4f0f69311", async() => {
                    WriteLiteral("Cadastre Outro");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 30 "C:\Users\Mateus\source\repos\.NET-Core-MVC-Web\Fiap.CP_1.SofiaBag\Views\Objeto\Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("sucess-msg", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b2049794c165c23121322506bbb9bae15e4f0f612029", async() => {
            }
            );
            __Fiap_CP_1_SofiaBag_TagHelpers_SucessMsgTagHelper = CreateTagHelper<global::Fiap.CP_1.SofiaBag.TagHelpers.SucessMsgTagHelper>();
            __tagHelperExecutionContext.Add(__Fiap_CP_1_SofiaBag_TagHelpers_SucessMsgTagHelper);
            __Fiap_CP_1_SofiaBag_TagHelpers_SucessMsgTagHelper.Mensagem = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Fiap_CP_1_SofiaBag_TagHelpers_SucessMsgTagHelper.Class = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 33 "C:\Users\Mateus\source\repos\.NET-Core-MVC-Web\Fiap.CP_1.SofiaBag\Views\Objeto\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<table style=""border-radius:10px"" class=""table table-bordered table-dark"">
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
#line 47 "C:\Users\Mateus\source\repos\.NET-Core-MVC-Web\Fiap.CP_1.SofiaBag\Views\Objeto\Index.cshtml"
     foreach (var itens in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 50 "C:\Users\Mateus\source\repos\.NET-Core-MVC-Web\Fiap.CP_1.SofiaBag\Views\Objeto\Index.cshtml"
           Write(itens.CodigoId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 51 "C:\Users\Mateus\source\repos\.NET-Core-MVC-Web\Fiap.CP_1.SofiaBag\Views\Objeto\Index.cshtml"
           Write(itens.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 52 "C:\Users\Mateus\source\repos\.NET-Core-MVC-Web\Fiap.CP_1.SofiaBag\Views\Objeto\Index.cshtml"
           Write(itens.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 53 "C:\Users\Mateus\source\repos\.NET-Core-MVC-Web\Fiap.CP_1.SofiaBag\Views\Objeto\Index.cshtml"
            Write(itens.Ativo?"True":"False");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 54 "C:\Users\Mateus\source\repos\.NET-Core-MVC-Web\Fiap.CP_1.SofiaBag\Views\Objeto\Index.cshtml"
           Write(itens.DtCadastro.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 55 "C:\Users\Mateus\source\repos\.NET-Core-MVC-Web\Fiap.CP_1.SofiaBag\Views\Objeto\Index.cshtml"
           Write(itens.Cor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"justify-content:space-between\">\r\n                <button");
            BeginWriteAttribute("onclick", " onclick=\"", 1774, "\"", 1816, 3);
            WriteAttributeValue("", 1784, "idObject.value", 1784, 14, true);
            WriteAttributeValue(" ", 1798, "=", 1799, 2, true);
#nullable restore
#line 57 "C:\Users\Mateus\source\repos\.NET-Core-MVC-Web\Fiap.CP_1.SofiaBag\Views\Objeto\Index.cshtml"
WriteAttributeValue(" ", 1800, itens.CodigoId, 1801, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-sm btn-danger\" data-toggle=\"modal\" data-target=\"#exampleModal\">Remover</button>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b2049794c165c23121322506bbb9bae15e4f0f616460", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Users\Mateus\source\repos\.NET-Core-MVC-Web\Fiap.CP_1.SofiaBag\Views\Objeto\Index.cshtml"
                                                                        WriteLiteral(itens.CodigoId);

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
#line 62 "C:\Users\Mateus\source\repos\.NET-Core-MVC-Web\Fiap.CP_1.SofiaBag\Views\Objeto\Index.cshtml"


    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</table>

<!-- https://bootswatch.com/4/ baixar o tema e colar o codigo no arquivo boostrap.min-->
<!-- Modal -->
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"" style=""background-color:red"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Confirmação Remover</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>

            <div class=""modal-body"">
                Ops :( <br />
                Deseja Mesmo Deletar esse Objeto? <br />
                Adeus Mochila...
            </div>
            <div class=""modal-footer"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b2049794c165c23121322506bbb9bae15e4f0f619938", async() => {
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
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
