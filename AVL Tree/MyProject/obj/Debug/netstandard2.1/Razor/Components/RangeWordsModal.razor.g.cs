#pragma checksum "D:\uni\Ashrafi\P2\MyProject\Components\RangeWordsModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30be129fad699cdfce8977e91bc1f8e2d54c24d3"
// <auto-generated/>
#pragma warning disable 1591
namespace MyProject.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\uni\Ashrafi\P2\MyProject\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\uni\Ashrafi\P2\MyProject\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\uni\Ashrafi\P2\MyProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\uni\Ashrafi\P2\MyProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\uni\Ashrafi\P2\MyProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\uni\Ashrafi\P2\MyProject\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\uni\Ashrafi\P2\MyProject\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\uni\Ashrafi\P2\MyProject\_Imports.razor"
using MyProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\uni\Ashrafi\P2\MyProject\_Imports.razor"
using MyProj.Shared.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\uni\Ashrafi\P2\MyProject\_Imports.razor"
using MyProject.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\uni\Ashrafi\P2\MyProject\_Imports.razor"
using MyProject.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\uni\Ashrafi\P2\MyProject\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\uni\Ashrafi\P2\MyProject\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\uni\Ashrafi\P2\MyProject\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\uni\Ashrafi\P2\MyProject\_Imports.razor"
using MyProject.Shared;

#line default
#line hidden
#nullable disable
    public partial class RangeWordsModal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal fade");
            __builder.AddAttribute(2, "id", "modal2");
            __builder.AddAttribute(3, "role", "dialog");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "modal-dialog modal-lg");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "modal-content");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "modal-header");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "type", "button");
            __builder.AddAttribute(12, "class", "close");
            __builder.AddAttribute(13, "data-dismiss", "modal");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "D:\uni\Ashrafi\P2\MyProject\Components\RangeWordsModal.razor"
                                                                           ()=>Show = false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(15, "×");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.AddMarkupContent(17, "<h4 class=\"modal-title\">Show Words In Range</h4>");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "modal-body");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "container");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "row justify-content-center");
#nullable restore
#line 14 "D:\uni\Ashrafi\P2\MyProject\Components\RangeWordsModal.razor"
                 if(!Show)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Radzen.Blazor.RadzenTemplateForm<Word>>(25);
            __builder.AddAttribute(26, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Word>(
#nullable restore
#line 16 "D:\uni\Ashrafi\P2\MyProject\Components\RangeWordsModal.razor"
                                                           word

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Word>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Word>(this, 
#nullable restore
#line 16 "D:\uni\Ashrafi\P2\MyProject\Components\RangeWordsModal.razor"
                                                                        ShowRange

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenFieldset>(29);
                __builder2.AddAttribute(30, "Text", "Show Words In Range");
                __builder2.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(32, "div");
                    __builder3.AddAttribute(33, "class", "row justify-content-center");
                    __builder3.AddAttribute(34, "style", "margin-bottom:-8px;");
                    __builder3.OpenElement(35, "div");
                    __builder3.AddAttribute(36, "class", "input-group");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(37);
                    __builder3.AddAttribute(38, "Placeholder", "Start char");
                    __builder3.AddAttribute(39, "style", "display: block");
                    __builder3.AddAttribute(40, "Name", "First");
                    __builder3.AddAttribute(41, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "D:\uni\Ashrafi\P2\MyProject\Components\RangeWordsModal.razor"
                                                                                                                             word.first

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(42, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => word.first = __value, word.first))));
                    __builder3.AddAttribute(43, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => word.first));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(44, "\r\n\r\n                                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(45);
                    __builder3.AddAttribute(46, "Placeholder", "End char");
                    __builder3.AddAttribute(47, "style", "display: block");
                    __builder3.AddAttribute(48, "Name", "Last");
                    __builder3.AddAttribute(49, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "D:\uni\Ashrafi\P2\MyProject\Components\RangeWordsModal.razor"
                                                                                                                          word.last

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(50, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => word.last = __value, word.last))));
                    __builder3.AddAttribute(51, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => word.last));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(52, "\r\n\r\n                                    ");
                    __builder3.AddMarkupContent(53, "<button type=\"submit\" class=\"rz-button btn-primary\" id=\"TVulRwc6Zk\" _bl_5cbe03e1-db98-48f9-904f-8daa0ab2b17a>\r\n                                        Show    \r\n                                    </button>");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(54, "\r\n                                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(55);
                    __builder3.AddAttribute(56, "Component", "Last");
                    __builder3.AddAttribute(57, "Text", "it\'s required");
                    __builder3.AddAttribute(58, "Popup", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "D:\uni\Ashrafi\P2\MyProject\Components\RangeWordsModal.razor"
                                                                                                     true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(59, "Style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(60, "\r\n                                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(61);
                    __builder3.AddAttribute(62, "Component", "First");
                    __builder3.AddAttribute(63, "Text", "it\'s required");
                    __builder3.AddAttribute(64, "Popup", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 30 "D:\uni\Ashrafi\P2\MyProject\Components\RangeWordsModal.razor"
                                                                                                      true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(65, "Style", "position: absolute");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 33 "D:\uni\Ashrafi\P2\MyProject\Components\RangeWordsModal.razor"
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\uni\Ashrafi\P2\MyProject\Components\RangeWordsModal.razor"
                     if (Words.Length != 0)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(66, "table");
            __builder.AddAttribute(67, "class", "table");
            __builder.AddMarkupContent(68, "<thead><tr><th>Words</th>\r\n                                <th>Meanings</th></tr></thead>\r\n                            ");
            __builder.OpenElement(69, "tbody");
#nullable restore
#line 46 "D:\uni\Ashrafi\P2\MyProject\Components\RangeWordsModal.razor"
                                 foreach (var word in Words)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(70, "tr");
            __builder.AddAttribute(71, "class", "warning");
            __builder.OpenElement(72, "td");
            __builder.AddContent(73, 
#nullable restore
#line 49 "D:\uni\Ashrafi\P2\MyProject\Components\RangeWordsModal.razor"
                                             word.Word

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                                        ");
            __builder.OpenElement(75, "td");
            __builder.AddContent(76, 
#nullable restore
#line 50 "D:\uni\Ashrafi\P2\MyProject\Components\RangeWordsModal.razor"
                                             word.Meaning

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 52 "D:\uni\Ashrafi\P2\MyProject\Components\RangeWordsModal.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 55 "D:\uni\Ashrafi\P2\MyProject\Components\RangeWordsModal.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(77, "<p>No Words!</p>");
#nullable restore
#line 59 "D:\uni\Ashrafi\P2\MyProject\Components\RangeWordsModal.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "D:\uni\Ashrafi\P2\MyProject\Components\RangeWordsModal.razor"
                     
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n    ");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "modal-footer");
            __builder.OpenElement(81, "button");
            __builder.AddAttribute(82, "type", "button");
            __builder.AddAttribute(83, "class", "btn btn-default");
            __builder.AddAttribute(84, "data-dismiss", "modal");
            __builder.AddAttribute(85, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "D:\uni\Ashrafi\P2\MyProject\Components\RangeWordsModal.razor"
                                                                                     ()=>Show = false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(86, "Close");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "D:\uni\Ashrafi\P2\MyProject\Components\RangeWordsModal.razor"
      
    private bool Show {get; set;}
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "D:\uni\Ashrafi\P2\MyProject\Components\RangeWordsModal.razor"
                                         
    private class Word
    {
        public string first {get; set;}
        public string last {get; set;}
    }
    Word word = new Word();
    private Entry[] Words = {};
    private void ShowRange()
    {
        Words = Main.aVLtree.ShowWordsInRange(word.first[0], word.last[0]).ToArray();
        word = new Word();
        Show = true;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
