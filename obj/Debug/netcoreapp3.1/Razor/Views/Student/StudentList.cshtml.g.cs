#pragma checksum "E:\git\LMS\LibraryManagmentSystem\Views\Student\StudentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4746dec22be98685111f6523ecdc005816da27fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_StudentList), @"mvc.1.0.view", @"/Views/Student/StudentList.cshtml")]
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
#line 1 "E:\git\LMS\LibraryManagmentSystem\Views\_ViewImports.cshtml"
using SchoolLibraryManagment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\git\LMS\LibraryManagmentSystem\Views\_ViewImports.cshtml"
using SchoolLibraryManagment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4746dec22be98685111f6523ecdc005816da27fc", @"/Views/Student/StudentList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6609296df01001cd75176910dea010d2173c958f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_StudentList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SchoolLibraryManagment.Models.StudentEntity>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddStudent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\git\LMS\LibraryManagmentSystem\Views\Student\StudentList.cshtml"
  
    ViewData["Title"] = "StudentList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Student Section</h1>\r\n\r\n<hr />\r\n\r\n<p class=\"float-left\">\r\n   ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4746dec22be98685111f6523ecdc005816da27fc4491", async() => {
                WriteLiteral("Add Student");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n\r\n<p class=\"float-right\">\r\n");
            WriteLiteral("</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            \r\n            <th>\r\n                ");
#nullable restore
#line 26 "E:\git\LMS\LibraryManagmentSystem\Views\Student\StudentList.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "E:\git\LMS\LibraryManagmentSystem\Views\Student\StudentList.cshtml"
           Write(Html.DisplayNameFor(model => model.FatherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n           \r\n            <th>\r\n                ");
#nullable restore
#line 33 "E:\git\LMS\LibraryManagmentSystem\Views\Student\StudentList.cshtml"
           Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n              <th>\r\n                ");
#nullable restore
#line 37 "E:\git\LMS\LibraryManagmentSystem\Views\Student\StudentList.cshtml"
           Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n              <th>\r\n                ");
#nullable restore
#line 41 "E:\git\LMS\LibraryManagmentSystem\Views\Student\StudentList.cshtml"
           Write(Html.DisplayNameFor(model => model.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n              <th>\r\n                ");
#nullable restore
#line 45 "E:\git\LMS\LibraryManagmentSystem\Views\Student\StudentList.cshtml"
           Write(Html.DisplayNameFor(model => model.Mail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 49 "E:\git\LMS\LibraryManagmentSystem\Views\Student\StudentList.cshtml"
           Write(Html.DisplayNameFor(model => model.Contact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 53 "E:\git\LMS\LibraryManagmentSystem\Views\Student\StudentList.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n                     \r\n            <th>Actions</th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 61 "E:\git\LMS\LibraryManagmentSystem\Views\Student\StudentList.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "E:\git\LMS\LibraryManagmentSystem\Views\Student\StudentList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "E:\git\LMS\LibraryManagmentSystem\Views\Student\StudentList.cshtml"
           Write(Html.DisplayFor(modelItem => item.FatherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n           \r\n            <td>\r\n                ");
#nullable restore
#line 71 "E:\git\LMS\LibraryManagmentSystem\Views\Student\StudentList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n             <td>\r\n                ");
#nullable restore
#line 74 "E:\git\LMS\LibraryManagmentSystem\Views\Student\StudentList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n             <td>\r\n                ");
#nullable restore
#line 77 "E:\git\LMS\LibraryManagmentSystem\Views\Student\StudentList.cshtml"
           Write(Html.DisplayFor(modelItem => item.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n             <td>\r\n                ");
#nullable restore
#line 80 "E:\git\LMS\LibraryManagmentSystem\Views\Student\StudentList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Mail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 85 "E:\git\LMS\LibraryManagmentSystem\Views\Student\StudentList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Contact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 90 "E:\git\LMS\LibraryManagmentSystem\Views\Student\StudentList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </td>\r\n                      \r\n             <td>\r\n                ");
#nullable restore
#line 95 "E:\git\LMS\LibraryManagmentSystem\Views\Student\StudentList.cshtml"
           Write(Html.ActionLink( "Update", "AddStudent", new {  item.StudentId, item.Name, item.FatherName, item.Gender, item.Age, item.DOB, item.Mail, item.Contact, item.Address } , new { @class="btn btn-outline-success rounded-pill"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br/> <br/>\r\n\r\n                ");
#nullable restore
#line 97 "E:\git\LMS\LibraryManagmentSystem\Views\Student\StudentList.cshtml"
           Write(Html.ActionLink("Delete", "DeleteStudent", new {  item.StudentId  }, new { @class = "btn btn-outline-danger rounded-pill",onclick="return confirm('Do you really want this record?')" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 101 "E:\git\LMS\LibraryManagmentSystem\Views\Student\StudentList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SchoolLibraryManagment.Models.StudentEntity>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
