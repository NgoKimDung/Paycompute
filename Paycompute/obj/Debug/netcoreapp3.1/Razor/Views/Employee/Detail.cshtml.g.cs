#pragma checksum "C:\Users\dungngo\Desktop\SourceCode\Git\Paycompute\Paycompute\Views\Employee\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23f27f55215851fbc95400ab8b0e27606f304bc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Detail), @"mvc.1.0.view", @"/Views/Employee/Detail.cshtml")]
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
#line 1 "C:\Users\dungngo\Desktop\SourceCode\Git\Paycompute\Paycompute\Views\_ViewImports.cshtml"
using Paycompute;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dungngo\Desktop\SourceCode\Git\Paycompute\Paycompute\Views\_ViewImports.cshtml"
using Paycompute.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23f27f55215851fbc95400ab8b0e27606f304bc2", @"/Views/Employee/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d82a17a92ca28dc354efe5ab80300d7aa4b038b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\dungngo\Desktop\SourceCode\Git\Paycompute\Paycompute\Views\Employee\Detail.cshtml"
  
    ViewData["Title"] = "Employee Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div>\r\n            <div>\r\n                <nav aria-label=\"breadscrumb\">\r\n                    <ol class=\"breadcrumb\">\r\n                        <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23f27f55215851fbc95400ab8b0e27606f304bc24232", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                        <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23f27f55215851fbc95400ab8b0e27606f304bc25650", async() => {
                WriteLiteral("Employee List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">Detail Employee</li>
                    </ol>
                </nav><br />
                <table class=""table table-success"">
                    <thead>
                        <tr>
                            <th>Photo</th>
                            <th>Full Name</th>
                            <th>Designation</th>
                            <th>Gender</th>
                            <th>Date Of Birth</th>
                            <th>Employee Number</th>
                            <th>NI Number</th>
                            <th>Email</th>
                            <th>Phone</th>
                            <th>Payment Method</th>
                            <th>Student Loan</th>
                            <th>Union Member</th>
                            <th>Address</th>
                            <th>City</th>
                            <th>Postcode</th>
                        </t");
            WriteLiteral("r>\r\n                    </thead>\r\n                    <tbody>\r\n                        <tr>\r\n                            <td>\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 1652, "\"", 1686, 1);
#nullable restore
#line 41 "C:\Users\dungngo\Desktop\SourceCode\Git\Paycompute\Paycompute\Views\Employee\Detail.cshtml"
WriteAttributeValue("", 1658, Url.Content(Model.ImageUrl), 1658, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-employee\"/>\r\n                            </td>\r\n                            <td>");
#nullable restore
#line 43 "C:\Users\dungngo\Desktop\SourceCode\Git\Paycompute\Paycompute\Views\Employee\Detail.cshtml"
                           Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 44 "C:\Users\dungngo\Desktop\SourceCode\Git\Paycompute\Paycompute\Views\Employee\Detail.cshtml"
                           Write(Model.Designation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 45 "C:\Users\dungngo\Desktop\SourceCode\Git\Paycompute\Paycompute\Views\Employee\Detail.cshtml"
                           Write(Model.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 46 "C:\Users\dungngo\Desktop\SourceCode\Git\Paycompute\Paycompute\Views\Employee\Detail.cshtml"
                           Write(Model.DOB);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 47 "C:\Users\dungngo\Desktop\SourceCode\Git\Paycompute\Paycompute\Views\Employee\Detail.cshtml"
                           Write(Model.EmployeeNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 48 "C:\Users\dungngo\Desktop\SourceCode\Git\Paycompute\Paycompute\Views\Employee\Detail.cshtml"
                           Write(Model.NationalInsuranceNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 2114, "\"", 2187, 6);
            WriteAttributeValue("", 2121, "mailto:", 2121, 7, true);
#nullable restore
#line 49 "C:\Users\dungngo\Desktop\SourceCode\Git\Paycompute\Paycompute\Views\Employee\Detail.cshtml"
WriteAttributeValue("", 2128, Model.Email, 2128, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2140, "?subject=Payslip&body=Attached", 2140, 30, true);
            WriteAttributeValue(" ", 2170, "is", 2171, 3, true);
            WriteAttributeValue(" ", 2173, "your", 2174, 5, true);
            WriteAttributeValue(" ", 2178, "payslip.", 2179, 9, true);
            EndWriteAttribute();
            WriteLiteral(">Send Payslip</a></td>\r\n                            <td>");
#nullable restore
#line 50 "C:\Users\dungngo\Desktop\SourceCode\Git\Paycompute\Paycompute\Views\Employee\Detail.cshtml"
                           Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 51 "C:\Users\dungngo\Desktop\SourceCode\Git\Paycompute\Paycompute\Views\Employee\Detail.cshtml"
                           Write(Model.PaymentMethod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 52 "C:\Users\dungngo\Desktop\SourceCode\Git\Paycompute\Paycompute\Views\Employee\Detail.cshtml"
                           Write(Model.StudentLoan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 53 "C:\Users\dungngo\Desktop\SourceCode\Git\Paycompute\Paycompute\Views\Employee\Detail.cshtml"
                           Write(Model.UnionMember);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 54 "C:\Users\dungngo\Desktop\SourceCode\Git\Paycompute\Paycompute\Views\Employee\Detail.cshtml"
                           Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 55 "C:\Users\dungngo\Desktop\SourceCode\Git\Paycompute\Paycompute\Views\Employee\Detail.cshtml"
                           Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 56 "C:\Users\dungngo\Desktop\SourceCode\Git\Paycompute\Paycompute\Views\Employee\Detail.cshtml"
                           Write(Model.Postcode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 67 "C:\Users\dungngo\Desktop\SourceCode\Git\Paycompute\Paycompute\Views\Employee\Detail.cshtml"
       await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
