#pragma checksum "C:\Users\Dell\Desktop\aspCodes\FinalProject\Views\Students\ShowStudentSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03c37965e0a475955a29292bbffdcf4771b3e2c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_ShowStudentSummary), @"mvc.1.0.view", @"/Views/Students/ShowStudentSummary.cshtml")]
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
#line 1 "C:\Users\Dell\Desktop\aspCodes\FinalProject\Views\_ViewImports.cshtml"
using FinalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell\Desktop\aspCodes\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03c37965e0a475955a29292bbffdcf4771b3e2c2", @"/Views/Students/ShowStudentSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1cd403b176af46e85ea812cbc8b3a7a1a86d4d8", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_ShowStudentSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentSummary>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-check"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowStudentSummary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Dell\Desktop\aspCodes\FinalProject\Views\Students\ShowStudentSummary.cshtml"
  
    ViewData["Title"] = "StudentSummaryReport";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>StudentSummaryReport</h1>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03c37965e0a475955a29292bbffdcf4771b3e2c24494", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"form-group \">\r\n\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03c37965e0a475955a29292bbffdcf4771b3e2c24803", async() => {
                    WriteLiteral("\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 14 "C:\Users\Dell\Desktop\aspCodes\FinalProject\Views\Students\ShowStudentSummary.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.studentName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <div>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "03c37965e0a475955a29292bbffdcf4771b3e2c26384", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 17 "C:\Users\Dell\Desktop\aspCodes\FinalProject\Views\Students\ShowStudentSummary.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.studentName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n        <div style=\"position:relative; top:20px;\">\r\n            <input type=\"submit\" value=\"Search\" class=\"btn btn-secondary\" />\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\"card border-primary mb-3\" style=\"max-width: 500rem; position:relative; top:30px; \">\r\n    <div class=\"card-header\">Employee Summary Report</div>\r\n    <div class=\"card-body\">\r\n");
#nullable restore
#line 34 "C:\Users\Dell\Desktop\aspCodes\FinalProject\Views\Students\ShowStudentSummary.cshtml"
         if (Model.Students is null || Model.Students.Count() == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""alert alert-dismissible alert-warning"">
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""alert""></button>
                <h4 class=""alert-heading"">Warning!</h4>
                <p class=""mb-0"">No Students match .</p>
            </div>
");
#nullable restore
#line 41 "C:\Users\Dell\Desktop\aspCodes\FinalProject\Views\Students\ShowStudentSummary.cshtml"
        }
        else
        {
            foreach (var student in Model.Students)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card border-warning mb-3\" style=\"max-width: 60rem; \">\r\n                    <div class=\"card-header\">\r\n                        ");
#nullable restore
#line 49 "C:\Users\Dell\Desktop\aspCodes\FinalProject\Views\Students\ShowStudentSummary.cshtml"
                   Write(student.studentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <span class=\"badge rounded-pill bg-secondary\" style=\"margin-left:50%; height:20px;\">\r\n");
#nullable restore
#line 51 "C:\Users\Dell\Desktop\aspCodes\FinalProject\Views\Students\ShowStudentSummary.cshtml"
                              
                                int total = 0;
                                foreach (var studentCourse in student.StudentCourses)
                                    total += studentCourse.Course.totalHours;

                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
#nullable restore
#line 57 "C:\Users\Dell\Desktop\aspCodes\FinalProject\Views\Students\ShowStudentSummary.cshtml"
                       Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Hours Done
                        </span>
                    </div>
                    <div style=""display:flex; justify-content:flex-start;"">
                        <div style=""width:35%; display:inline; background-color: #eeeff3; text-align: center; padding-top: 10px; padding-bottom: 10px; border-right: solid 3px #cfd5eb; "">
                            <img");
            BeginWriteAttribute("src", " src=\"", 2158, "\"", 2207, 1);
#nullable restore
#line 62 "C:\Users\Dell\Desktop\aspCodes\FinalProject\Views\Students\ShowStudentSummary.cshtml"
WriteAttributeValue("", 2164, Url.Content("~/Images/"+student.imagePath), 2164, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""img-thumbnail"" style=""width:18rem; height:15rem; border-radius: 50%; align-content:center;"" alt=""Employee Image"" />
                        </div>
                        <div class=""card-body"" style=""background-color: #f5f5f575; display:inline; padding-top:3%; "">
");
#nullable restore
#line 65 "C:\Users\Dell\Desktop\aspCodes\FinalProject\Views\Students\ShowStudentSummary.cshtml"
                             foreach (var studentCourse in student.StudentCourses)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h4 class=\"card-title\" style=\"margin-left:10%;\">\r\n                                    ");
#nullable restore
#line 68 "C:\Users\Dell\Desktop\aspCodes\FinalProject\Views\Students\ShowStudentSummary.cshtml"
                               Write(studentCourse.Course.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <span class=\"badge rounded-pill bg-secondary\" style=\"margin-left:30%;\">\r\n                                        ");
#nullable restore
#line 70 "C:\Users\Dell\Desktop\aspCodes\FinalProject\Views\Students\ShowStudentSummary.cshtml"
                                    Write((studentCourse.Course.totalHours));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Hours\r\n\r\n                                    </span>\r\n                                </h4>\r\n");
#nullable restore
#line 74 "C:\Users\Dell\Desktop\aspCodes\FinalProject\Views\Students\ShowStudentSummary.cshtml"


                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 80 "C:\Users\Dell\Desktop\aspCodes\FinalProject\Views\Students\ShowStudentSummary.cshtml"


            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentSummary> Html { get; private set; }
    }
}
#pragma warning restore 1591
