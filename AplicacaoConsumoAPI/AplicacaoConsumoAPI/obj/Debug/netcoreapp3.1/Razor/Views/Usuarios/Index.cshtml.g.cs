#pragma checksum "C:\Users\thiag\Desktop\FACULDADE\ADID6\API CRUD\AplicacaoConsumoAPI\AplicacaoConsumoAPI\Views\Usuarios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2f4166fb997451ff7ce963d5ca614f6acb8f81e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Index), @"mvc.1.0.view", @"/Views/Usuarios/Index.cshtml")]
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
#line 1 "C:\Users\thiag\Desktop\FACULDADE\ADID6\API CRUD\AplicacaoConsumoAPI\AplicacaoConsumoAPI\Views\_ViewImports.cshtml"
using AplicacaoConsumoAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\thiag\Desktop\FACULDADE\ADID6\API CRUD\AplicacaoConsumoAPI\AplicacaoConsumoAPI\Views\_ViewImports.cshtml"
using AplicacaoConsumoAPI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2f4166fb997451ff7ce963d5ca614f6acb8f81e", @"/Views/Usuarios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"175fdff41fa3b23c00d203c1b9a4cf5ee67751e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\thiag\Desktop\FACULDADE\ADID6\API CRUD\AplicacaoConsumoAPI\AplicacaoConsumoAPI\Views\Usuarios\Index.cshtml"
  
    ViewBag.Title = "Usuario";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2f4166fb997451ff7ce963d5ca614f6acb8f81e3875", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<h2>Adicionar um Usuario</h2>
<div class=""form-group"">
    <label for=""Nome"">Id:</label>
    <input id=""txtUsuarioId"" class=""form-control"" name=""Id"" />
</div>
<div class=""form-group"">
    <label for=""Nome"">Nome:</label>
    <input id=""txtNomeUsuario"" class=""form-control"" name=""Nome"" />
</div>
<div class=""form-group"">
    <label for=""Email"">Email:</label>
    <input id=""txtEmailUsuario"" class=""form-control"" name=""Email"" />
</div>
<div class=""text-center panel-body"">
    <button id=""btnSalvar"" class=""btn btn-sm btn-primary"">Salvar</button>
</div>

<button onclick=""GetAllUsers()"" class=""btn btn-primary"">Carregar Usuarios</button>

<br />

<h2>Lista de Usuarios</h2>
<table id=""tblUsuarios"" class=""table table-sm table-striped table-bordered m-2"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Nome</th>
            <th>Email</th>
            <th>Ação</th>
        </tr>
    </thead>
    <tbody></tbody>
</table>  

<script type=""text/javascript"">

    $(docume");
            WriteLiteral(@"nt).ready(function () {

    });

    function GetAllUsers() {
        $.getJSON(""/Usuarios/GetAllUsers"", function (usuarios) {
            $(""#tblUsuarios tbody tr"").remove();
            $.map(usuarios, function (usuario) {
                $(""#tblUsuarios tbody"").append(""<tr>""
                    + "" <td>"" + usuario.id + ""</td>""
                    + "" <td>"" + usuario.nome + ""</td>""
                    + "" <td>"" + usuario.email + ""</td>""
                    + "" <td>""
                    + ""      <button class='btn-success' onclick='Edit("" + usuario.id + "")' style='margin-right:5px;'>Editar</button>""
                    + ""      <button class='btn-danger' onclick='Delete("" + usuario.id + "")'>Excluir</button>""
                    + "" </td> ""
                    + "" </tr> "");
            });
        });
    }

    function Edit(usuarioId) {
        if (usuarioId > 0) {
            $.getJSON(""/Usuarios/GetById?id="" + usuarioId, function (usuarios) {
                $('#txtUsuarioId').val");
            WriteLiteral(@"(usuario.id);
                $('#txtNomeUsuario').val(usuario.nome);
                $('#txtEmailUsuario').val(usuario.email);
            });
        }
    }

    function Delete(usuarioId) {
        if (usuarioId > 0) {
            $.ajax({
                url: '/Usuarios/Delete?id=' + usuarioId,
                type: 'DELETE',
                dataType: 'json',
                success: function (data) {
                },
                error: function (ex) {
                    console.log('Erro na Operação');
                }
            });
        }
    }

    $(""#btnSalvar"").click(function () {
        var oUsuario = {
            Id: $(""#txtUsuarioId"").val(),
            Nome: $(""#txtNomeUsuario"").val(),
            Email: $(""#txtEmailUsuario"").val()
        }
        $.post(""/Usuarios/AddUpdateUser"", oUsuario)
            .done(function (data) {
                GetAllUsers
            });
    });

</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
