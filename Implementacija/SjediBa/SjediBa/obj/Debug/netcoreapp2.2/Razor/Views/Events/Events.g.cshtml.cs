#pragma checksum "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/Events/Events.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce6638510125f1340db4a365a2b86a14534a93ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_Events), @"mvc.1.0.view", @"/Views/Events/Events.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Events/Events.cshtml", typeof(AspNetCore.Views_Events_Events))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce6638510125f1340db4a365a2b86a14534a93ca", @"/Views/Events/Events.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0df0b4e190489e8f40fcad2efbdd912db6fe1b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_Events : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("booking"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/Events/Events.cshtml"
  
    ViewData["Title"] = "Događaji";

#line default
#line hidden
            BeginContext(41, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(46, 17, false);
#line 4 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/Events/Events.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(63, 7, true);
            WriteLiteral("</h1>\n\n");
            EndContext();
#line 6 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/Events/Events.cshtml"
    
    List<EventModel> events = new List<EventModel>();
    events.Add(new EventModel(new OrganizerModel("ime",  "prezime", "adresa", DateTime.Now, new ProxyModel(new AccountModel("admin", "admin", 1), 1), 1), new SpaceModel("adresa", new List<SectionModel>{new SectionModel(new List<SeatModel>{new SeatModel("10", 1)}, 100, "naziv", 1)}, new LocalAdministratorModel("name1", "surname1", DateTime.Now, "adresa1", new ProxyModel(new AccountModel("admin", "admin", 1), 1), 1),  1), DateTime.Now, DateTime.Now, "Dogadjaj 1", 1));
    events.Add(new EventModel(new OrganizerModel("ime",  "prezime", "adresa", DateTime.Now, new ProxyModel(new AccountModel("admin", "admin", 1), 1), 1), new SpaceModel("adresa", new List<SectionModel>{new SectionModel(new List<SeatModel>{new SeatModel("10", 1)}, 100, "naziv", 1)}, new LocalAdministratorModel("name1", "surname1", DateTime.Now, "adresa1", new ProxyModel(new AccountModel("admin", "admin", 1), 1), 1),  1), DateTime.Today, DateTime.Now, "Dogadjaj 2", 1));


#line default
#line hidden
            BeginContext(1076, 499, true);
            WriteLiteral(@"
<div class=""clearfix"">
    <div class=""form-group float-right"">
        <div>
            <i class=""fa fa-search position-absolute pt-2 pl-3""></i>
            <input type=""text"" class=""form-control pl-5"" id=""search"" placeholder=""Search"">
        </div>
    </div>
    <table class=""float-left w-100"">
        <tr>
            <th>ID</th>
            <th>Naziv</th>
            <th>Lokacija</th>
            <th>Datum</th>
            <th>Vrijeme</th>
            <th>Organizator</th>
        </tr>
");
            EndContext();
#line 29 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/Events/Events.cshtml"
         foreach (var e in events)
        {

#line default
#line hidden
            BeginContext(1620, 37, true);
            WriteLiteral("            <tr>\n                <td>");
            EndContext();
            BeginContext(1658, 4, false);
#line 32 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/Events/Events.cshtml"
               Write(e.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1662, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(1689, 6, false);
#line 33 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/Events/Events.cshtml"
               Write(e.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1695, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(1722, 15, false);
#line 34 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/Events/Events.cshtml"
               Write(e.Space.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1737, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(1764, 35, false);
#line 35 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/Events/Events.cshtml"
               Write(e.StartDate.ToString("dd. MM. yy."));

#line default
#line hidden
            EndContext();
            BeginContext(1799, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(1826, 31, false);
#line 36 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/Events/Events.cshtml"
               Write(e.StartDate.ToShortTimeString());

#line default
#line hidden
            EndContext();
            BeginContext(1857, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(1884, 16, false);
#line 37 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/Events/Events.cshtml"
               Write(e.Organizer.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1900, 27, true);
            WriteLiteral("</td>\n                <td>\n");
            EndContext();
#line 39 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/Events/Events.cshtml"
                       var json = Newtonsoft.Json.JsonConvert.SerializeObject(e); 

#line default
#line hidden
            BeginContext(2011, 113, true);
            WriteLiteral("                    <button type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#bookingPopup\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2124, "\"", 2156, 3);
            WriteAttributeValue("", 2134, "SetCurrentEvent(", 2134, 16, true);
#line 40 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/Events/Events.cshtml"
WriteAttributeValue("", 2150, json, 2150, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 2155, ")", 2155, 1, true);
            EndWriteAttribute();
            BeginContext(2157, 106, true);
            WriteLiteral(">\n                        Rezerviši\n                    </button>\n                </td>\n            </tr>\n");
            EndContext();
#line 45 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/Events/Events.cshtml"
        }

#line default
#line hidden
            BeginContext(2273, 726, true);
            WriteLiteral(@"    </table>
</div>


<!-- Modal -->
<div class=""modal fade"" id=""bookingPopup"" tabindex=""-1"" role=""dialog"" aria-labelledby=""modalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""modalLabel"">Rezerviši događaj</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""mb-3"">
                    <span class=""h3"" id=""eventName""></span><br>
                </div>
                ");
            EndContext();
            BeginContext(2999, 1596, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce6638510125f1340db4a365a2b86a14534a93ca12282", async() => {
                BeginContext(3067, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 65 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/Events/Events.cshtml"
                     if(true)
                    {

#line default
#line hidden
                BeginContext(3120, 792, true);
                WriteLiteral(@"                        <div class=""form-group row"">
                            <label for=""name"" class=""col-form-label col-sm-2"">Ime i prezime:</label>
                            <div class=""col-sm-10"">
                                <input type=""text"" class=""form-control"" name=""name"" id=""name"" placeholder=""Ime i prezime"">
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label for=""date"" class=""col-form-label col-sm-2"">Datum rodjenja:</label>
                            <div class=""col-sm-10"">
                                <input type=""text"" class=""form-control"" name=""date"" id=""date"" placeholder=""Datum rodjenja"">
                            </div>
                        </div>
");
                EndContext();
#line 79 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/Events/Events.cshtml"
                    }

#line default
#line hidden
                BeginContext(3934, 246, true);
                WriteLiteral("                    <div class=\"form-group row\">\n                        <div class=\"col-sm-6\">\n                            <select class=\"form-control\" name=\"sector\" id=\"section\" onclick=\"SetSeats(); SetPrice()\">\n                                ");
                EndContext();
                BeginContext(4180, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce6638510125f1340db4a365a2b86a14534a93ca14353", async() => {
                    BeginContext(4197, 6, true);
                    WriteLiteral("Sektor");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4212, 229, true);
                WriteLiteral("\n                            </select>\n                        </div>\n                        <div class=\"col-sm-6\">\n                            <select class=\"form-control\" name=\"seat\" id=\"seat\">\n                                ");
                EndContext();
                BeginContext(4441, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce6638510125f1340db4a365a2b86a14534a93ca16036", async() => {
                    BeginContext(4458, 8, true);
                    WriteLiteral("Sjedište");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4475, 113, true);
                WriteLiteral("\n                            </select>\n                        </div>\n                    </div>\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4595, 373, true);
            WriteLiteral(@"
                <span id=""seatPrice""> </span>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary"" onclick=""$('#booking').submit()"">Rezerviši</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Odustani</button>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
