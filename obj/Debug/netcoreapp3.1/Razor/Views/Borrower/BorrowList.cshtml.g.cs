#pragma checksum "E:\git\LMS\LibraryManagmentSystem\Views\Borrower\BorrowList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d05a5823043c44ecd6595dcd1c56894d3228d9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Borrower_BorrowList), @"mvc.1.0.view", @"/Views/Borrower/BorrowList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d05a5823043c44ecd6595dcd1c56894d3228d9c", @"/Views/Borrower/BorrowList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6609296df01001cd75176910dea010d2173c958f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Borrower_BorrowList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SchoolLibraryManagment.Models.BorrowerEntity>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddBorrower", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Borrower", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "E:\git\LMS\LibraryManagmentSystem\Views\Borrower\BorrowList.cshtml"
  
    ViewData["Title"] = "BorrowList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Borrower List</h1>\r\n\r\n<p class=\"float-left\">\r\n   ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d05a5823043c44ecd6595dcd1c56894d3228d9c4442", async() => {
                WriteLiteral("Add Borrower Record");
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
            WriteLiteral("</p>\r\n<table class=\"table table-bordered mg-b-0\">\r\n    <thead>\r\n        \r\n        <tr>\r\n            \r\n            <th>\r\n                ");
#nullable restore
#line 24 "E:\git\LMS\LibraryManagmentSystem\Views\Borrower\BorrowList.cshtml"
           Write(Html.DisplayNameFor(model => model.DateBorrowed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "E:\git\LMS\LibraryManagmentSystem\Views\Borrower\BorrowList.cshtml"
           Write(Html.DisplayNameFor(model => model.ReturnDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 31 "E:\git\LMS\LibraryManagmentSystem\Views\Borrower\BorrowList.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n");
            WriteLiteral("\r\n            <th>\r\n                ");
#nullable restore
#line 39 "E:\git\LMS\LibraryManagmentSystem\Views\Borrower\BorrowList.cshtml"
           Write(Html.DisplayNameFor(model => model.StudentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n         \r\n            <th>Actions</th>\r\n\r\n        </tr>\r\n      \r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 48 "E:\git\LMS\LibraryManagmentSystem\Views\Borrower\BorrowList.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "E:\git\LMS\LibraryManagmentSystem\Views\Borrower\BorrowList.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateBorrowed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 54 "E:\git\LMS\LibraryManagmentSystem\Views\Borrower\BorrowList.cshtml"
           Write(Html.DisplayFor(modelItem => item.ReturnDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n           \r\n            <td>\r\n                ");
#nullable restore
#line 58 "E:\git\LMS\LibraryManagmentSystem\Views\Borrower\BorrowList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
            WriteLiteral("\r\n                <td>\r\n                    ");
#nullable restore
#line 65 "E:\git\LMS\LibraryManagmentSystem\Views\Borrower\BorrowList.cshtml"
               Write(Html.DisplayFor(modelItem => item.StudentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                  \r\n             <td>\r\n                ");
#nullable restore
#line 69 "E:\git\LMS\LibraryManagmentSystem\Views\Borrower\BorrowList.cshtml"
           Write(Html.ActionLink( "Update", "AddBorrower", new {  item.BorrowerId, item.DateBorrowed, item.ReturnDate, item.BookId, item.StudentId, item.StudentName } , new { @class="btn btn-outline-success rounded-pill"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n\r\n                ");
#nullable restore
#line 71 "E:\git\LMS\LibraryManagmentSystem\Views\Borrower\BorrowList.cshtml"
           Write(Html.ActionLink("Delete", "DeleteBorrower", new {  item.BorrowerId  }, new { @class = "btn btn-outline-danger rounded-pill",onclick="return confirm('Do you really want this record?')" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 75 "E:\git\LMS\LibraryManagmentSystem\Views\Borrower\BorrowList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SchoolLibraryManagment.Models.BorrowerEntity>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
