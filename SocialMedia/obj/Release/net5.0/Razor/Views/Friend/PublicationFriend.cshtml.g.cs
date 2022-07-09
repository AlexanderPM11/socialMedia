#pragma checksum "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Friend\PublicationFriend.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09eda0a275d7e3d22ca9b91539e2d977a0048898"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Friend_PublicationFriend), @"mvc.1.0.view", @"/Views/Friend/PublicationFriend.cshtml")]
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
#line 1 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Friend\PublicationFriend.cshtml"
using SocialMedia.Core.Application.ViewModels.Publication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Friend\PublicationFriend.cshtml"
using SocialMedia.Core.Aplication.ViewModel.Comment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Friend\PublicationFriend.cshtml"
using SocialMedia.Core.Application.ViewModels.User;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09eda0a275d7e3d22ca9b91539e2d977a0048898", @"/Views/Friend/PublicationFriend.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb3c1c4110c97850527e62d53d9f9c1592b4add2", @"/Views/_ViewImports.cshtml")]
    public class Views_Friend_PublicationFriend : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PublicationViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formul"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Friend", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 5 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Friend\PublicationFriend.cshtml"
  
    ViewData["Title"] = "Amigos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row mt-5\">\r\n");
#nullable restore
#line 10 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Friend\PublicationFriend.cshtml"
     if (Model.Count == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card-header bg-primary text-light\">\r\n            <h4>Este usuario no tiene publicaciones disponibles</h4>\r\n        </div>\r\n");
#nullable restore
#line 15 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Friend\PublicationFriend.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card-header bg-primary text-light\">\r\n            <h4>Publicaciones de mi amigo</h4>\r\n        </div>\r\n");
#nullable restore
#line 21 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Friend\PublicationFriend.cshtml"
         foreach (PublicationViewModel userVm in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card shadow-sm \">\r\n                <div class=\"card-body contCard\">\r\n\r\n");
#nullable restore
#line 26 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Friend\PublicationFriend.cshtml"
                     if (ViewBag.User != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Friend\PublicationFriend.cshtml"
                         foreach (UserViewModel user in ViewBag.User as List<UserViewModel>)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Friend\PublicationFriend.cshtml"
                             if (userVm.Id_User == user.Id)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"cont_Perfil\">\r\n                                    <div class=\"contNamePerfil\">\r\n                                        <h3>");
#nullable restore
#line 34 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Friend\PublicationFriend.cshtml"
                                       Write(user.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 34 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Friend\PublicationFriend.cshtml"
                                                   Write(user.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h3>\r\n                                        <p class=\"p_DatePublication\">");
#nullable restore
#line 35 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Friend\PublicationFriend.cshtml"
                                                                Write(userVm.Created);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n\r\n                                    </div>\r\n\r\n                                    <div class=\"contImgPerfil\">\r\n                                        <img class=\"bd-placeholder-img card-img-top img-product-size img_profile\"");
            BeginWriteAttribute("src", " src=\"", 1562, "\"", 1582, 1);
#nullable restore
#line 40 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Friend\PublicationFriend.cshtml"
WriteAttributeValue("", 1568, user.ImageUrl, 1568, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    </div>\r\n\r\n\r\n                                </div>\r\n");
#nullable restore
#line 45 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Friend\PublicationFriend.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Friend\PublicationFriend.cshtml"
                             

                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Friend\PublicationFriend.cshtml"
                         

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Friend\PublicationFriend.cshtml"
                     if (userVm.TitlePost != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h4 class=\"card-title\">");
#nullable restore
#line 52 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Friend\PublicationFriend.cshtml"
                                          Write(userVm.TitlePost);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n");
#nullable restore
#line 53 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Friend\PublicationFriend.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 55 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Friend\PublicationFriend.cshtml"
                     if (userVm.ImageUrl != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img class=\"bd-placeholder-img card-img-top img-product-size img_publicationHome\"");
            BeginWriteAttribute("src", " src=\"", 2112, "\"", 2134, 1);
#nullable restore
#line 57 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Friend\PublicationFriend.cshtml"
WriteAttributeValue("", 2118, userVm.ImageUrl, 2118, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 58 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Friend\PublicationFriend.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"




                    <div class=""d-flex justify-content-between align-items-center"">
                        <div class=""btn-group"">

                            <button type=""button"" class=""btn btn-outline-primary"" data-bs-toggle=""modal"" data-bs-target=""#exampleModal-");
#nullable restore
#line 68 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Friend\PublicationFriend.cshtml"
                                                                                                                                  Write(userVm.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                Comentarios\r\n                            </button>\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("            <!-- Modal -->\r\n            <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 2715, "\"", 2743, 2);
            WriteAttributeValue("", 2720, "exampleModal-", 2720, 13, true);
#nullable restore
#line 78 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Friend\PublicationFriend.cshtml"
WriteAttributeValue("", 2733, userVm.Id, 2733, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\" aria-labelledby=\"exampleModalLabel\" aria-hidden=\"true\">\r\n                <div class=\"modal-dialog\">\r\n                    <div class=\"modal-content\">\r\n\r\n                        <div class=\"modal-header\">\r\n                            <p><b>");
#nullable restore
#line 83 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Friend\PublicationFriend.cshtml"
                             Write(userVm.TitlePost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n                            <button type=\"button\" class=\"btn-close\" data-bs-dismiss=\"modal\" aria-label=\"Close\"></button>\r\n                        </div>\r\n                        <div class=\"modal-body\">\r\n\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09eda0a275d7e3d22ca9b91539e2d977a004889814290", async() => {
                WriteLiteral(@"
                                <div class=""mb-3"">
                                    <label for=""filtrar"" class=""form-label"">Introduzca el usuario:</label>
                                    <textarea type=""text"" class=""form-control"" required name=""comment"" id=""filtrar"" aria-describedby=""emailHelp""></textarea>
                                </div>
                                <input type=""hidden"" name=""Id_Publication""");
                BeginWriteAttribute("value", " value=\"", 3769, "\"", 3787, 1);
#nullable restore
#line 93 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Friend\PublicationFriend.cshtml"
WriteAttributeValue("", 3777, userVm.Id, 3777, 10, false);

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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 97 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Friend\PublicationFriend.cshtml"
                         if (ViewBag.Comment != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div style=\" height: 200px; overflow-y: scroll;\">\r\n");
#nullable restore
#line 100 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Friend\PublicationFriend.cshtml"
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
            BeginWriteAttribute("src", " src=\"", 4653, "\"", 4676, 1);
#nullable restore
#line 106 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Friend\PublicationFriend.cshtml"
WriteAttributeValue("", 4659, comment.ImageUrl, 4659, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                            </div>\r\n                                            <div class=\"contTextComment\">\r\n                                                <p>");
#nullable restore
#line 109 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Friend\PublicationFriend.cshtml"
                                              Write(comment.Commentary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            </div>\r\n                                        </div>\r\n");
#nullable restore
#line 112 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Friend\PublicationFriend.cshtml"
                                    }


                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 118 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Friend\PublicationFriend.cshtml"
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
#line 126 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Friend\PublicationFriend.cshtml"

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 127 "C:\Users\Alexander Polanco\source\repos\SocialMedia\SocialMedia\Views\Friend\PublicationFriend.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n</div>\r\n\r\n");
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
