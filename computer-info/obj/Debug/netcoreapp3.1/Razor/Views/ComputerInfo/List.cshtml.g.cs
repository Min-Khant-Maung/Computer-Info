#pragma checksum "C:\Users\Min Khant Maung\source\repos\computer-info\computer-info\Views\ComputerInfo\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2e19973f4e2ec923490236d2987944d60857497"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ComputerInfo_List), @"mvc.1.0.view", @"/Views/ComputerInfo/List.cshtml")]
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
#line 1 "C:\Users\Min Khant Maung\source\repos\computer-info\computer-info\Views\_ViewImports.cshtml"
using computer_info;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Min Khant Maung\source\repos\computer-info\computer-info\Views\_ViewImports.cshtml"
using computer_info.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Min Khant Maung\source\repos\computer-info\computer-info\Views\ComputerInfo\List.cshtml"
using computer_info.Models.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2e19973f4e2ec923490236d2987944d60857497", @"/Views/ComputerInfo/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43444ddd9eb5afd16b7d403c62129e7ab7cde72a", @"/Views/_ViewImports.cshtml")]
    public class Views_ComputerInfo_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<ComputerInfoViewModel>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2e19973f4e2ec923490236d2987944d608574973564", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Document</title>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-KK94CHFLLe+nY2dmCWGMq91rCGa5gtU4mk92HdvYe+M/SXH301p5ILy+dN9+nJOZ"" crossorigin=""anonymous"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2e19973f4e2ec923490236d2987944d608574974962", async() => {
                WriteLiteral("\r\n    <h1>Exam-List</h1>\r\n");
#nullable restore
#line 15 "C:\Users\Min Khant Maung\source\repos\computer-info\computer-info\Views\ComputerInfo\List.cshtml"
     if (TempData["msg"] != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"alert alert-success\">\r\n            ");
#nullable restore
#line 18 "C:\Users\Min Khant Maung\source\repos\computer-info\computer-info\Views\ComputerInfo\List.cshtml"
       Write(TempData["msg"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 20 "C:\Users\Min Khant Maung\source\repos\computer-info\computer-info\Views\ComputerInfo\List.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">ID</th>
                <th scope=""col"">Level Name</th>
                <th scope=""col"">Type</th>
                <th scope=""col"">Brand</th>
                <th scope=""col"">CPU</th>
                <th scope=""col"">RAM</th>
                <th scope=""col"">Storage Size</th>
                <th scope=""col"">Is SSD</th>
                <th scope=""col"">Is Active</th>
                <th scope=""col"">Created User ID</th>
                <th scope=""col"">Created At</th>
                <th scope=""col"">Updated User ID</th>
                <th scope=""col"">Updated At</th>
                <th scope=""col""></th>
                <th scope=""col""></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 42 "C:\Users\Min Khant Maung\source\repos\computer-info\computer-info\Views\ComputerInfo\List.cshtml"
             foreach (var s in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 45 "C:\Users\Min Khant Maung\source\repos\computer-info\computer-info\Views\ComputerInfo\List.cshtml"
               Write(s.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 46 "C:\Users\Min Khant Maung\source\repos\computer-info\computer-info\Views\ComputerInfo\List.cshtml"
               Write(s.LevelName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 47 "C:\Users\Min Khant Maung\source\repos\computer-info\computer-info\Views\ComputerInfo\List.cshtml"
               Write(s.Type);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 48 "C:\Users\Min Khant Maung\source\repos\computer-info\computer-info\Views\ComputerInfo\List.cshtml"
               Write(s.Brand);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 49 "C:\Users\Min Khant Maung\source\repos\computer-info\computer-info\Views\ComputerInfo\List.cshtml"
               Write(s.CPU);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 50 "C:\Users\Min Khant Maung\source\repos\computer-info\computer-info\Views\ComputerInfo\List.cshtml"
               Write(s.RAM);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 51 "C:\Users\Min Khant Maung\source\repos\computer-info\computer-info\Views\ComputerInfo\List.cshtml"
               Write(s.StorageSize);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 52 "C:\Users\Min Khant Maung\source\repos\computer-info\computer-info\Views\ComputerInfo\List.cshtml"
               Write(s.isSSD);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 53 "C:\Users\Min Khant Maung\source\repos\computer-info\computer-info\Views\ComputerInfo\List.cshtml"
               Write(s.isActive);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 54 "C:\Users\Min Khant Maung\source\repos\computer-info\computer-info\Views\ComputerInfo\List.cshtml"
               Write(s.CreatedUserId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 55 "C:\Users\Min Khant Maung\source\repos\computer-info\computer-info\Views\ComputerInfo\List.cshtml"
               Write(s.CreatedAt);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 56 "C:\Users\Min Khant Maung\source\repos\computer-info\computer-info\Views\ComputerInfo\List.cshtml"
               Write(s.UpdatedUserId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 57 "C:\Users\Min Khant Maung\source\repos\computer-info\computer-info\Views\ComputerInfo\List.cshtml"
               Write(s.UpdatedAt);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n\r\n                <td><a");
                BeginWriteAttribute("href", " href=\"", 2103, "\"", 2137, 2);
                WriteAttributeValue("", 2110, "/ComputerInfo/Edit?Id=", 2110, 22, true);
#nullable restore
#line 60 "C:\Users\Min Khant Maung\source\repos\computer-info\computer-info\Views\ComputerInfo\List.cshtml"
WriteAttributeValue("", 2132, s.Id, 2132, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-success\" role=\"button\">Edit</a></td>\r\n                <td><a");
                BeginWriteAttribute("href", " href=\"", 2214, "\"", 2250, 2);
                WriteAttributeValue("", 2221, "/ComputerInfo/Delete?Id=", 2221, 24, true);
#nullable restore
#line 61 "C:\Users\Min Khant Maung\source\repos\computer-info\computer-info\Views\ComputerInfo\List.cshtml"
WriteAttributeValue("", 2245, s.Id, 2245, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" onclick=\"return confirm(\'Are you sure to delete this record?\')\" class=\"btn btn-danger\" role=\"button\">Delete</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 63 "C:\Users\Min Khant Maung\source\repos\computer-info\computer-info\Views\ComputerInfo\List.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha3/dist/js/bootstrap.bundle.min.js\" integrity=\"sha384-ENjdO4Dr2bkBIFxQpeoTz1HIcje39Wm4jDKdf19U8gI4ddQ3GYNS7NTKfAdVQSZe\" crossorigin=\"anonymous\"></script>\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<ComputerInfoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
