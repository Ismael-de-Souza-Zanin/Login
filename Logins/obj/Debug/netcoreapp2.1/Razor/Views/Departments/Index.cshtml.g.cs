#pragma checksum "C:\Users\mt100388\source\repos\LoginSystem\Logins\Views\Departments\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a52cc8f4e8fdd2062cc31742af1d7b55d09d5c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Departments_Index), @"mvc.1.0.view", @"/Views/Departments/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Departments/Index.cshtml", typeof(AspNetCore.Views_Departments_Index))]
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
#line 1 "C:\Users\mt100388\source\repos\LoginSystem\Logins\Views\_ViewImports.cshtml"
using Logins;

#line default
#line hidden
#line 2 "C:\Users\mt100388\source\repos\LoginSystem\Logins\Views\_ViewImports.cshtml"
using Logins.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a52cc8f4e8fdd2062cc31742af1d7b55d09d5c2", @"/Views/Departments/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89cb68f9180de57f92feffa2c9614ea14e4b09a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Departments_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Logins.Models.Department>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\mt100388\source\repos\LoginSystem\Logins\Views\Departments\Index.cshtml"
   
    ViewData["Title"] = "Departments";

#line default
#line hidden
            BeginContext(96, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(103, 17, false);
#line 7 "C:\Users\mt100388\source\repos\LoginSystem\Logins\Views\Departments\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(120, 18, true);
            WriteLiteral("</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(138, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c7477418f9e42a8af7efe061c1015e6", async() => {
                BeginContext(161, 23, true);
                WriteLiteral("Criar Novo Departamento");
                EndContext();
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
            EndContext();
            BeginContext(188, 94, true);
            WriteLiteral("\r\n</p>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(283, 38, false);
#line 17 "C:\Users\mt100388\source\repos\LoginSystem\Logins\Views\Departments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(321, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(377, 40, false);
#line 20 "C:\Users\mt100388\source\repos\LoginSystem\Logins\Views\Departments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(417, 88, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>  \r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 26 "C:\Users\mt100388\source\repos\LoginSystem\Logins\Views\Departments\Index.cshtml"
         foreach(var item in Model)
        {

#line default
#line hidden
            BeginContext(553, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(614, 37, false);
#line 30 "C:\Users\mt100388\source\repos\LoginSystem\Logins\Views\Departments\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(651, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(719, 39, false);
#line 33 "C:\Users\mt100388\source\repos\LoginSystem\Logins\Views\Departments\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(758, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(826, 63, false);
#line 36 "C:\Users\mt100388\source\repos\LoginSystem\Logins\Views\Departments\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { /*id=item.PrimaryKey*/ }));

#line default
#line hidden
            EndContext();
            BeginContext(889, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(914, 69, false);
#line 37 "C:\Users\mt100388\source\repos\LoginSystem\Logins\Views\Departments\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { /*id=item.PrimaryKey*/ }));

#line default
#line hidden
            EndContext();
            BeginContext(983, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1008, 67, false);
#line 38 "C:\Users\mt100388\source\repos\LoginSystem\Logins\Views\Departments\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { /*id=item.PrimaryKey*/ }));

#line default
#line hidden
            EndContext();
            BeginContext(1075, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 41 "C:\Users\mt100388\source\repos\LoginSystem\Logins\Views\Departments\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1130, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Logins.Models.Department>> Html { get; private set; }
    }
}
#pragma warning restore 1591
