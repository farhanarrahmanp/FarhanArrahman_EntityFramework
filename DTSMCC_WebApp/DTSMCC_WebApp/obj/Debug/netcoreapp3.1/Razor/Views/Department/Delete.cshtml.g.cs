#pragma checksum "/Users/farhan/VSProjects/DTSMCC_WebApp/DTSMCC_WebApp/Views/Department/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "417d37647329e6b2d6f51882b9f9253dffc103e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_Delete), @"mvc.1.0.view", @"/Views/Department/Delete.cshtml")]
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
#line 1 "/Users/farhan/VSProjects/DTSMCC_WebApp/DTSMCC_WebApp/Views/_ViewImports.cshtml"
using DTSMCC_WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/farhan/VSProjects/DTSMCC_WebApp/DTSMCC_WebApp/Views/_ViewImports.cshtml"
using DTSMCC_WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"417d37647329e6b2d6f51882b9f9253dffc103e1", @"/Views/Department/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4d2e3b1d2e78ee2c66913c990fba6bad93a0cf2", @"/Views/_ViewImports.cshtml")]
    public class Views_Department_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Department>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/farhan/VSProjects/DTSMCC_WebApp/DTSMCC_WebApp/Views/Department/Delete.cshtml"
  
    ViewData["Title"] = "Delete Department";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Hapus Pegawai</h1>\n\n<p>\n    <br />\n</p>\n\n");
#nullable restore
#line 13 "/Users/farhan/VSProjects/DTSMCC_WebApp/DTSMCC_WebApp/Views/Department/Delete.cshtml"
 using (Html.BeginForm("Delete", "Department", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/farhan/VSProjects/DTSMCC_WebApp/DTSMCC_WebApp/Views/Department/Delete.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table\">\n");
#nullable restore
#line 17 "/Users/farhan/VSProjects/DTSMCC_WebApp/DTSMCC_WebApp/Views/Department/Delete.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <th>\n                    ");
#nullable restore
#line 21 "/Users/farhan/VSProjects/DTSMCC_WebApp/DTSMCC_WebApp/Views/Department/Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <td>\n                    ");
#nullable restore
#line 24 "/Users/farhan/VSProjects/DTSMCC_WebApp/DTSMCC_WebApp/Views/Department/Delete.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    <input type=\"hidden\" id=\"Id\" name=\"Id\"");
            BeginWriteAttribute("value", " value=\"", 559, "\"", 605, 1);
#nullable restore
#line 25 "/Users/farhan/VSProjects/DTSMCC_WebApp/DTSMCC_WebApp/Views/Department/Delete.cshtml"
WriteAttributeValue("", 567, Html.DisplayFor(modelItem => item.Id), 567, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n");
            WriteLiteral("                </td>\n            </tr>\n            <tr>\n                <th>\n                    Division ");
#nullable restore
#line 31 "/Users/farhan/VSProjects/DTSMCC_WebApp/DTSMCC_WebApp/Views/Department/Delete.cshtml"
                        Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <td>\n                    ");
#nullable restore
#line 34 "/Users/farhan/VSProjects/DTSMCC_WebApp/DTSMCC_WebApp/Views/Department/Delete.cshtml"
               Write(Html.DisplayFor(modelItem => item.Division.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("                </td>\n            </tr>\n");
#nullable restore
#line 38 "/Users/farhan/VSProjects/DTSMCC_WebApp/DTSMCC_WebApp/Views/Department/Delete.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <th>Are You Sure?</th>\n            <td>\n                <input type=\"submit\" value=\"Yes\">\n                |\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "417d37647329e6b2d6f51882b9f9253dffc103e16605", async() => {
                WriteLiteral("<input type=\"button\" value=\"No\">");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </td>\n        </tr>\n    </table>\n");
#nullable restore
#line 48 "/Users/farhan/VSProjects/DTSMCC_WebApp/DTSMCC_WebApp/Views/Department/Delete.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Department>> Html { get; private set; }
    }
}
#pragma warning restore 1591
