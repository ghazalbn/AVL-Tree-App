// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class Delete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "D:\uni\Ashrafi\P2\MyProject\Components\Delete.razor"
                                         
    private class Node
    {
        public string Word {get; set;}
    }
    Node node = new Node();
    private void Remove()
    {
        if(Main.aVLtree.Size != 0)
        {
            Main.aVLtree.Delete(node.Word);
            node = new Node();
        }
        System.Console.WriteLine(Main.aVLtree.Size);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
