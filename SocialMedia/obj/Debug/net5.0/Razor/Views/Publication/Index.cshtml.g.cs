#pragma checksum "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fb24b642728c1e317e9c4702b9a2a6cdc5d7df3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Publication_Index), @"mvc.1.0.view", @"/Views/Publication/Index.cshtml")]
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
#line 1 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\_ViewImports.cshtml"
using SocialMedia;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\_ViewImports.cshtml"
using SocialMedia.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
using SocialMedia.Core.Application.ViewModels.Publication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
using SocialMedia.Core.Aplication.ViewModel.Comment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
using SocialMedia.Core.Application.ViewModels.User;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fb24b642728c1e317e9c4702b9a2a6cdc5d7df3", @"/Views/Publication/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb3c1c4110c97850527e62d53d9f9c1592b4add2", @"/Views/_ViewImports.cshtml")]
    public class Views_Publication_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PublicationViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Publication", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formul"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 5 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
  
    ViewData["Title"] = "Mis publicaciones";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row mt-5\">\r\n    <div class=\"cont_BtbCreate\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fb24b642728c1e317e9c4702b9a2a6cdc5d7df37670", async() => {
                WriteLiteral("Crear publicacion");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n");
#nullable restore
#line 14 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
     if (Model.Count == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card-header bg-primary text-light\">\r\n            <h4>No hay publicaciones disponibles</h4>\r\n        </div>\r\n");
#nullable restore
#line 19 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card-header bg-primary text-light\">\r\n            <h4>Mis publicaciones</h4>\r\n        </div>\r\n");
#nullable restore
#line 25 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
         foreach (PublicationViewModel userVm in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card shadow-sm \">\r\n                <div class=\"card-body contCard\">\r\n\r\n");
#nullable restore
#line 30 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
                     if (ViewBag.User != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
                         foreach (UserViewModel user in ViewBag.User as List<UserViewModel>)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
                             if (userVm.Id_User == user.Id)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"cont_Perfil\">\r\n                                    <div class=\"contNamePerfil\">\r\n                                        <h3>");
#nullable restore
#line 38 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
                                       Write(user.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 38 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
                                                   Write(user.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h3>\r\n                                        <p class=\"p_DatePublication\">");
#nullable restore
#line 39 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
                                                                Write(userVm.Created);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n\r\n                                    </div>\r\n\r\n                                    <div class=\"contImgPerfil\">\r\n                                        <img class=\"bd-placeholder-img card-img-top img-product-size img_profile\"");
            BeginWriteAttribute("src", " src=\"", 1713, "\"", 1733, 1);
#nullable restore
#line 44 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
WriteAttributeValue("", 1719, user.ImageUrl, 1719, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    </div>\r\n\r\n\r\n                                </div>\r\n");
#nullable restore
#line 49 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
                             

                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
                         

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
                     if (userVm.TitlePost != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h4 class=\"card-title\">");
#nullable restore
#line 56 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
                                          Write(userVm.TitlePost);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n");
#nullable restore
#line 57 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 59 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
                     if (userVm.ImageUrl != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img class=\"bd-placeholder-img card-img-top img-product-size img_publicationHome\"");
            BeginWriteAttribute("src", " src=\"", 2263, "\"", 2285, 1);
#nullable restore
#line 61 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
WriteAttributeValue("", 2269, userVm.ImageUrl, 2269, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 62 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"d-flex justify-content-between align-items-center\">\r\n                        <div class=\"btn-group\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fb24b642728c1e317e9c4702b9a2a6cdc5d7df315683", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
                                                                                WriteLiteral(userVm.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fb24b642728c1e317e9c4702b9a2a6cdc5d7df318208", async() => {
                WriteLiteral("Borrar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
                                                                                  WriteLiteral(userVm.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n\r\n                            <button type=\"button\" class=\"btn btn-outline-primary\" data-bs-toggle=\"modal\" data-bs-target=\"#exampleModal-");
#nullable restore
#line 70 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
                                                                                                                                  Write(userVm.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                Comentarios
                            </button>

                        </div>
                    </div>
                </div>
            </div>
            <!-- Modal -->
            <div class=""modal fade""");
            BeginWriteAttribute("id", " id=\"", 3164, "\"", 3192, 2);
            WriteAttributeValue("", 3169, "exampleModal-", 3169, 13, true);
#nullable restore
#line 79 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
WriteAttributeValue("", 3182, userVm.Id, 3182, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                <div class=""modal-dialog"">
                    <div class=""modal-content"">

                        <div class=""modal-header"">
                            <div class=""cont_Comment"">
");
#nullable restore
#line 85 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
                                 if (userVm.ImageUrl != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"contImgComment\">\r\n                                        <img class=\"bd-placeholder-img card-img-top img-product-size img_ComentUsers\"");
            BeginWriteAttribute("src", " src=\"", 3749, "\"", 3771, 1);
#nullable restore
#line 88 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
WriteAttributeValue("", 3755, userVm.ImageUrl, 3755, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    </div>\r\n");
#nullable restore
#line 90 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
                                }

                                else if (userVm.TitlePost != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"modal-header\">\r\n                                        <p><b>");
#nullable restore
#line 95 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
                                         Write(userVm.TitlePost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n                                    </div>\r\n");
#nullable restore
#line 97 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                            <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
                        </div>
                        <div class=""modal-body"">

                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fb24b642728c1e317e9c4702b9a2a6cdc5d7df324452", async() => {
                WriteLiteral(@"
                                <div class=""mb-3"">
                                    <label for=""filtrar"" class=""form-label"">Introduzca el usuario:</label>
                                    <textarea type=""text"" class=""form-control"" required name=""comment"" id=""filtrar"" aria-describedby=""emailHelp""></textarea>
                                </div>
                                <input type=""hidden"" name=""Id_Publication""");
                BeginWriteAttribute("value", " value=\"", 4963, "\"", 4981, 1);
#nullable restore
#line 108 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
WriteAttributeValue("", 4971, userVm.Id, 4971, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <button type=\"submit\" class=\"btn btn-primary\">Comentar</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 112 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
                         if (ViewBag.Comment != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div style=\" height: 200px; overflow-y: scroll;\">\r\n");
#nullable restore
#line 115 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
                                 foreach (CommentViewModel comment in ViewBag.Comment as List<CommentViewModel>)
                                {
                                    if (comment.Id_Publication == userVm.Id)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <div class=""cont_Comment"">
                                            <div class=""contImgComment"">
                                                <img class=""bd-placeholder-img card-img-top img-product-size img_ComentUsers""");
            BeginWriteAttribute("src", " src=\"", 5847, "\"", 5870, 1);
#nullable restore
#line 121 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
WriteAttributeValue("", 5853, comment.ImageUrl, 5853, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                            </div>\r\n                                            <div class=\"contTextComment\">\r\n                                                <p>");
#nullable restore
#line 124 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
                                              Write(comment.Commentary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            </div>\r\n                                        </div>\r\n");
#nullable restore
#line 127 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
                                    }


                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 133 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Cerrar</button>
                        </div>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 141 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"




        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 145 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Publication\Index.cshtml"
         

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PublicationViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591