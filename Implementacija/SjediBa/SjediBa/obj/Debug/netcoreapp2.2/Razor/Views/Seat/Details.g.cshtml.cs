#pragma checksum "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/Seat/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0b1520c3acf3e9b6333f41e264e410e11a20d7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Seat_Details), @"mvc.1.0.view", @"/Views/Seat/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Seat/Details.cshtml", typeof(AspNetCore.Views_Seat_Details))]
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
#line 1 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/_ViewImports.cshtml"
using SjediBa;

#line default
#line hidden
#line 2 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/_ViewImports.cshtml"
using SjediBa.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0b1520c3acf3e9b6333f41e264e410e11a20d7c", @"/Views/Seat/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0df0b4e190489e8f40fcad2efbdd912db6fe1b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Seat_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SjediBa.Models.SeatModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(32, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/Seat/Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(73, 112, true);
            WriteLiteral("\n<h1>Details</h1>\n\n<div>\n    <h4>SeatModel</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n");
            EndContext();
            BeginContext(253, 47, true);
            WriteLiteral("        </dt>\n        <dd class = \"col-sm-10\">\n");
            EndContext();
            BeginContext(379, 58, true);
            WriteLiteral("        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(438, 43, false);
#line 20 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/Seat/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RowSeat));

#line default
#line hidden
            EndContext();
            BeginContext(481, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(542, 39, false);
#line 23 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/Seat/Details.cshtml"
       Write(Html.DisplayFor(model => model.RowSeat));

#line default
#line hidden
            EndContext();
            BeginContext(581, 42, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(623, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0b1520c3acf3e9b6333f41e264e410e11a20d7c5414", async() => {
                BeginContext(678, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 28 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/Seat/Details.cshtml"
                           WriteLiteral(Model.SeatModelId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(686, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(693, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0b1520c3acf3e9b6333f41e264e410e11a20d7c7738", async() => {
                BeginContext(715, 12, true);
                WriteLiteral("Back to List");
                EndContext();
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
            EndContext();
            BeginContext(731, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SjediBa.Models.SeatModel> Html { get; private set; }
    }
}
#pragma warning restore 1591