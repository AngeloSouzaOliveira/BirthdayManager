#pragma checksum "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\Pessoa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9116e682aa82c950e54af5bbd37a7ba8a2f2008d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pessoa_Index), @"mvc.1.0.view", @"/Views/Pessoa/Index.cshtml")]
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
#line 1 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\_ViewImports.cshtml"
using AngSoz.BirthdayManager.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\_ViewImports.cshtml"
using AngSoz.BirthdayManager.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9116e682aa82c950e54af5bbd37a7ba8a2f2008d", @"/Views/Pessoa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"effb8364e69518036f0e4dc089b69971b806c57e", @"/Views/_ViewImports.cshtml")]
    public class Views_Pessoa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AngSoz.BirthdayManager.Web.Models.Pessoa>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-effect-ripple btn-block btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/pessoa"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-sm-12 col-lg-12"">

        <div class=""widget"">
            <div class=""widget-content border-bottom"">
                <h3 class=""title-table""><strong>Lista de Aniversário</strong></h3>
            </div>
            <div class=""widget-content border-bottom themed-background-muted"">

                <div class=""row py-5"">

                    <div class=""col-sm-12 col-lg-3 mt-3"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9116e682aa82c950e54af5bbd37a7ba8a2f2008d5648", async() => {
                WriteLiteral("<i class=\"fa fa-plus-circle\"></i> Adicionar novo amigo");
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
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"col-sm-12 col-lg-5\">\r\n                    </div>\r\n\r\n                    <div class=\"col-sm-12 col-lg-4\">\r\n\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9116e682aa82c950e54af5bbd37a7ba8a2f2008d7148", async() => {
                WriteLiteral(@"
                            <input type=""text"" name=""searchString"" class=""form-control"" placeholder=""Pesquise o nome de um amigo..."">
                            <button type=""submit"" class=""btn  btn-effect-ripple btn-primary buttonsearch"">Pesquisar</button>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                    </div>
                </div>

                <table class=""table table-hover"" style=""margin-top:32px;"">
                    <thead style=""background-color: #5ccdde"">
                        <tr class=""text-white"">
                            <th class=""border"">Nome</th>
                            <th class=""border"">Sobrenome</th>
                            <th class=""border"">Data de nascimento</th>
                            <th class=""border"">Idade</th>
                            <th class=""border"">É amigo ou familiar?</th>
                            <th class=""border"">Já te deu algum presente?</th>
                            <th>Ações</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 44 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\Pessoa\Index.cshtml"
                       foreach(var pessoa in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td >");
#nullable restore
#line 46 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\Pessoa\Index.cshtml"
                            Write(pessoa.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"bg-light2\">");
#nullable restore
#line 47 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\Pessoa\Index.cshtml"
                                             Write(pessoa.SobreNome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td >");
#nullable restore
#line 48 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\Pessoa\Index.cshtml"
                             Write(pessoa.DataNascimento.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td  class=\"bg-light2\">");
#nullable restore
#line 49 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\Pessoa\Index.cshtml"
                                              Write(pessoa.Idade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" anos</td>\r\n                            <td >");
#nullable restore
#line 50 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\Pessoa\Index.cshtml"
                            Write(pessoa.FamilarOuAmigo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td  class=\"bg-light2\">");
#nullable restore
#line 51 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\Pessoa\Index.cshtml"
                                               Write(pessoa.TeDeuPresente == true ? "Sim" : "Não");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td >\r\n                                <a class=\"btn themed-background-creme\"");
            BeginWriteAttribute("href", " href=\"", 2632, "\"", 2667, 2);
            WriteAttributeValue("", 2639, "/pessoa/editar?id=", 2639, 18, true);
#nullable restore
#line 53 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\Pessoa\Index.cshtml"
WriteAttributeValue("", 2657, pessoa.Id, 2657, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">Editar</a>\r\n                                <a class=\"btn themed-background-success\"");
            BeginWriteAttribute("href", "  href=\"", 2767, "\"", 2805, 2);
            WriteAttributeValue("", 2775, "/pessoa/detalhes?id=", 2775, 20, true);
#nullable restore
#line 54 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\Pessoa\Index.cshtml"
WriteAttributeValue("", 2795, pessoa.Id, 2795, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">Detalhes</a>\r\n                                <a class=\"btn themed-background-danger\"");
            BeginWriteAttribute("href", " href=\"", 2906, "\"", 2942, 2);
            WriteAttributeValue("", 2913, "/pessoa/excluir?id=", 2913, 19, true);
#nullable restore
#line 55 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\Pessoa\Index.cshtml"
WriteAttributeValue("", 2932, pessoa.Id, 2932, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">Excluir</a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 58 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\Pessoa\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>


            </div>
            <div class=""widget-content widget-content-full"">
                <div class=""row text-center"">

                </div>
            </div>
        </div>

    </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AngSoz.BirthdayManager.Web.Models.Pessoa>> Html { get; private set; }
    }
}
#pragma warning restore 1591
