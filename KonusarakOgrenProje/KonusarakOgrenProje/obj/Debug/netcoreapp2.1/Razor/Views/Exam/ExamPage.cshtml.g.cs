#pragma checksum "C:\Users\Erdem\Desktop\KonusarakOgrenExamProject-main\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92654b7baa1e67f12b9b78b51f332eb13ef50fa9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Exam_ExamPage), @"mvc.1.0.view", @"/Views/Exam/ExamPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Exam/ExamPage.cshtml", typeof(AspNetCore.Views_Exam_ExamPage))]
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
#line 1 "C:\Users\Erdem\Desktop\KonusarakOgrenExamProject-main\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
using KonusarakOgrenExamProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92654b7baa1e67f12b9b78b51f332eb13ef50fa9", @"/Views/Exam/ExamPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7180f8f3dc2a41ed91056a68b176ba6d40a86ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Exam_ExamPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Exam>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/Exam/Js/ExamPage.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "C:\Users\Erdem\Desktop\KonusarakOgrenExamProject-main\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
  
    ViewData["Title"] = "Sınav";

#line default
#line hidden
            BeginContext(91, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("styles", async() => {
                BeginContext(108, 147, true);
                WriteLiteral("\n\n    <style>\n        a {\n            cursor: pointer;\n        }\n\n        \n        .question a{\n            margin-top:1px;\n        }\n    </style>\n");
                EndContext();
            }
            );
            BeginContext(257, 54, true);
            WriteLiteral("\n<div style=\"margin-top: 20px;\" class=\"exam mx-auto\">\n");
            EndContext();
#line 23 "C:\Users\Erdem\Desktop\KonusarakOgrenExamProject-main\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
     if (Model != null)
    {
        

#line default
#line hidden
            BeginContext(350, 40, true);
            WriteLiteral("        <input type=\"hidden\" id=\"examId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 390, "\"", 413, 1);
#line 26 "C:\Users\Erdem\Desktop\KonusarakOgrenExamProject-main\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
WriteAttributeValue("", 398, Model.ExamId, 398, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(414, 42, true);
            WriteLiteral(" />\n        <h1 style=\"text-align:center\">");
            EndContext();
            BeginContext(457, 11, false);
#line 27 "C:\Users\Erdem\Desktop\KonusarakOgrenExamProject-main\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                 Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(468, 60, true);
            WriteLiteral("</h1>\n        <p style=\"text-align:center;margin-top:10px;\">");
            EndContext();
            BeginContext(529, 13, false);
#line 28 "C:\Users\Erdem\Desktop\KonusarakOgrenExamProject-main\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                                 Write(Model.Content);

#line default
#line hidden
            EndContext();
            BeginContext(542, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 30 "C:\Users\Erdem\Desktop\KonusarakOgrenExamProject-main\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
         for (int i = 0; i < Model.ExamQuestions.Count; i++)
        {

#line default
#line hidden
            BeginContext(619, 158, true);
            WriteLiteral("            <div class=\"row\" style=\"margin-top:7vh;\">\n                <div class=\"col-xs-12 col-sm-12 col-md-6 col-lg-6 question\">\n                    <h4><b>");
            EndContext();
            BeginContext(779, 37, false);
#line 34 "C:\Users\Erdem\Desktop\KonusarakOgrenExamProject-main\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                       Write(Model.ExamQuestions[i].QuestionNumber);

#line default
#line hidden
            EndContext();
            BeginContext(817, 6, true);
            WriteLiteral(")</b> ");
            EndContext();
            BeginContext(824, 31, false);
#line 34 "C:\Users\Erdem\Desktop\KonusarakOgrenExamProject-main\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                                                    Write(Model.ExamQuestions[i].Question);

#line default
#line hidden
            EndContext();
            BeginContext(855, 30, true);
            WriteLiteral("</h4>\n                    <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 885, "\"", 939, 2);
            WriteAttributeValue("", 890, "listGroup", 890, 9, true);
#line 35 "C:\Users\Erdem\Desktop\KonusarakOgrenExamProject-main\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
WriteAttributeValue("", 899, Model.ExamQuestions[i].QuestionNumber, 899, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(940, 174, true);
            WriteLiteral(" class=\"list-group\">\n                        <a class=\"list-group-item list-group-item-action\"\n                           data-answer=\"A\"\n                           data-id=\"");
            EndContext();
            BeginContext(1116, 37, false);
#line 38 "C:\Users\Erdem\Desktop\KonusarakOgrenExamProject-main\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                Write(Model.ExamQuestions[i].QuestionNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1154, 41, true);
            WriteLiteral("\">\n                            <b>A)</b> ");
            EndContext();
            BeginContext(1196, 30, false);
#line 39 "C:\Users\Erdem\Desktop\KonusarakOgrenExamProject-main\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                 Write(Model.ExamQuestions[i].AnswerA);

#line default
#line hidden
            EndContext();
            BeginContext(1226, 184, true);
            WriteLiteral("\n                        </a>\n\n                        <a class=\"list-group-item list-group-item-action\"\n                           data-answer=\"B\"\n                           data-id=\"");
            EndContext();
            BeginContext(1412, 37, false);
#line 44 "C:\Users\Erdem\Desktop\KonusarakOgrenExamProject-main\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                Write(Model.ExamQuestions[i].QuestionNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1450, 40, true);
            WriteLiteral("\">\n                           <b>B)</b> ");
            EndContext();
            BeginContext(1491, 30, false);
#line 45 "C:\Users\Erdem\Desktop\KonusarakOgrenExamProject-main\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                Write(Model.ExamQuestions[i].AnswerB);

#line default
#line hidden
            EndContext();
            BeginContext(1521, 184, true);
            WriteLiteral("\n                        </a>\n\n                        <a class=\"list-group-item list-group-item-action\"\n                           data-answer=\"C\"\n                           data-id=\"");
            EndContext();
            BeginContext(1707, 37, false);
#line 50 "C:\Users\Erdem\Desktop\KonusarakOgrenExamProject-main\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                Write(Model.ExamQuestions[i].QuestionNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1745, 40, true);
            WriteLiteral("\">\n                           <b>C)</b> ");
            EndContext();
            BeginContext(1786, 30, false);
#line 51 "C:\Users\Erdem\Desktop\KonusarakOgrenExamProject-main\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                Write(Model.ExamQuestions[i].AnswerC);

#line default
#line hidden
            EndContext();
            BeginContext(1816, 184, true);
            WriteLiteral("\n                        </a>\n\n                        <a class=\"list-group-item list-group-item-action\"\n                           data-answer=\"D\"\n                           data-id=\"");
            EndContext();
            BeginContext(2002, 37, false);
#line 56 "C:\Users\Erdem\Desktop\KonusarakOgrenExamProject-main\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                Write(Model.ExamQuestions[i].QuestionNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2040, 40, true);
            WriteLiteral("\">\n                           <b>D)</b> ");
            EndContext();
            BeginContext(2081, 30, false);
#line 57 "C:\Users\Erdem\Desktop\KonusarakOgrenExamProject-main\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                Write(Model.ExamQuestions[i].AnswerD);

#line default
#line hidden
            EndContext();
            BeginContext(2111, 185, true);
            WriteLiteral("\n                        </a>\n                    </div>\n                </div>\n\n                <div class=\"col-xs-12 col-sm-12 col-md-6 col-lg-6 question\">\n                    <h4><b>");
            EndContext();
            BeginContext(2298, 41, false);
#line 63 "C:\Users\Erdem\Desktop\KonusarakOgrenExamProject-main\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                       Write(Model.ExamQuestions[i + 1].QuestionNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2340, 6, true);
            WriteLiteral(")</b> ");
            EndContext();
            BeginContext(2347, 35, false);
#line 63 "C:\Users\Erdem\Desktop\KonusarakOgrenExamProject-main\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                                                        Write(Model.ExamQuestions[i + 1].Question);

#line default
#line hidden
            EndContext();
            BeginContext(2382, 30, true);
            WriteLiteral("</h4>\n                    <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2412, "\"", 2468, 2);
            WriteAttributeValue("", 2417, "listGroup", 2417, 9, true);
#line 64 "C:\Users\Erdem\Desktop\KonusarakOgrenExamProject-main\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
WriteAttributeValue("", 2426, Model.ExamQuestions[i+1].QuestionNumber, 2426, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2469, 174, true);
            WriteLiteral(" class=\"list-group\">\n                        <a class=\"list-group-item list-group-item-action\"\n                           data-answer=\"A\"\n                           data-id=\"");
            EndContext();
            BeginContext(2645, 39, false);
#line 67 "C:\Users\Erdem\Desktop\KonusarakOgrenExamProject-main\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                Write(Model.ExamQuestions[i+1].QuestionNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2685, 41, true);
            WriteLiteral("\">\n                            <b>A)</b> ");
            EndContext();
            BeginContext(2727, 34, false);
#line 68 "C:\Users\Erdem\Desktop\KonusarakOgrenExamProject-main\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                 Write(Model.ExamQuestions[i + 1].AnswerA);

#line default
#line hidden
            EndContext();
            BeginContext(2761, 184, true);
            WriteLiteral("\n                        </a>\n\n                        <a class=\"list-group-item list-group-item-action\"\n                           data-answer=\"B\"\n                           data-id=\"");
            EndContext();
            BeginContext(2947, 39, false);
#line 73 "C:\Users\Erdem\Desktop\KonusarakOgrenExamProject-main\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                Write(Model.ExamQuestions[i+1].QuestionNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2987, 41, true);
            WriteLiteral("\">\n                            <b>B)</b> ");
            EndContext();
            BeginContext(3029, 34, false);
#line 74 "C:\Users\Erdem\Desktop\KonusarakOgrenExamProject-main\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                 Write(Model.ExamQuestions[i + 1].AnswerB);

#line default
#line hidden
            EndContext();
            BeginContext(3063, 184, true);
            WriteLiteral("\n                        </a>\n\n                        <a class=\"list-group-item list-group-item-action\"\n                           data-answer=\"C\"\n                           data-id=\"");
            EndContext();
            BeginContext(3249, 39, false);
#line 79 "C:\Users\Erdem\Desktop\KonusarakOgrenExamProject-main\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                Write(Model.ExamQuestions[i+1].QuestionNumber);

#line default
#line hidden
            EndContext();
            BeginContext(3289, 41, true);
            WriteLiteral("\">\n                            <b>C)</b> ");
            EndContext();
            BeginContext(3331, 34, false);
#line 80 "C:\Users\Erdem\Desktop\KonusarakOgrenExamProject-main\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                 Write(Model.ExamQuestions[i + 1].AnswerC);

#line default
#line hidden
            EndContext();
            BeginContext(3365, 184, true);
            WriteLiteral("\n                        </a>\n\n                        <a class=\"list-group-item list-group-item-action\"\n                           data-answer=\"D\"\n                           data-id=\"");
            EndContext();
            BeginContext(3551, 39, false);
#line 85 "C:\Users\Erdem\Desktop\KonusarakOgrenExamProject-main\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                Write(Model.ExamQuestions[i+1].QuestionNumber);

#line default
#line hidden
            EndContext();
            BeginContext(3591, 41, true);
            WriteLiteral("\">\n                            <b>D)</b> ");
            EndContext();
            BeginContext(3633, 34, false);
#line 86 "C:\Users\Erdem\Desktop\KonusarakOgrenExamProject-main\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                 Write(Model.ExamQuestions[i + 1].AnswerD);

#line default
#line hidden
            EndContext();
            BeginContext(3667, 131, true);
            WriteLiteral("\n                        </a>\n                    </div>\n                </div>\n            </div>\n            <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3798, "\"", 3812, 1);
#line 91 "C:\Users\Erdem\Desktop\KonusarakOgrenExamProject-main\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
WriteAttributeValue("", 3806, i++, 3806, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3813, 4, true);
            WriteLiteral(" />\n");
            EndContext();
#line 92 "C:\Users\Erdem\Desktop\KonusarakOgrenExamProject-main\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
        }

#line default
#line hidden
            BeginContext(3828, 293, true);
            WriteLiteral(@"        <div class=""form-row"">
            <div class=""form-group col-md-4 mx-auto"">
                <input type=""button"" class=""btn btn-success col-12 btn-lg mx-auto"" style=""margin-top:20px; margin-bottom:20px;"" id=""btnExamControl"" value=""Sınavı Tamamla"" />
            </div>
        </div>
");
            EndContext();
#line 99 "C:\Users\Erdem\Desktop\KonusarakOgrenExamProject-main\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
    }

#line default
#line hidden
            BeginContext(4127, 8, true);
            WriteLiteral("</div>\n\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(4152, 6, true);
                WriteLiteral("\n\n    ");
                EndContext();
                BeginContext(4158, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9a84b95992045be8b6f0f5b96eec326", async() => {
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
                EndContext();
                BeginContext(4211, 1, true);
                WriteLiteral("\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Exam> Html { get; private set; }
    }
}
#pragma warning restore 1591
