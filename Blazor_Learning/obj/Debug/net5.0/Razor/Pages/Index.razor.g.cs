#pragma checksum "C:\Users\DuffeyAaron\OneDrive - University of Wisconsin-Stout\Desktop\Github_Repos\Blazor\Blazor_Learning\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "effe11e5cb05d8f80512c16946d0823686bc3922"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor_Learning.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\DuffeyAaron\OneDrive - University of Wisconsin-Stout\Desktop\Github_Repos\Blazor\Blazor_Learning\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DuffeyAaron\OneDrive - University of Wisconsin-Stout\Desktop\Github_Repos\Blazor\Blazor_Learning\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\DuffeyAaron\OneDrive - University of Wisconsin-Stout\Desktop\Github_Repos\Blazor\Blazor_Learning\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\DuffeyAaron\OneDrive - University of Wisconsin-Stout\Desktop\Github_Repos\Blazor\Blazor_Learning\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\DuffeyAaron\OneDrive - University of Wisconsin-Stout\Desktop\Github_Repos\Blazor\Blazor_Learning\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\DuffeyAaron\OneDrive - University of Wisconsin-Stout\Desktop\Github_Repos\Blazor\Blazor_Learning\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\DuffeyAaron\OneDrive - University of Wisconsin-Stout\Desktop\Github_Repos\Blazor\Blazor_Learning\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\DuffeyAaron\OneDrive - University of Wisconsin-Stout\Desktop\Github_Repos\Blazor\Blazor_Learning\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\DuffeyAaron\OneDrive - University of Wisconsin-Stout\Desktop\Github_Repos\Blazor\Blazor_Learning\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\DuffeyAaron\OneDrive - University of Wisconsin-Stout\Desktop\Github_Repos\Blazor\Blazor_Learning\_Imports.razor"
using Blazor_Learning;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\DuffeyAaron\OneDrive - University of Wisconsin-Stout\Desktop\Github_Repos\Blazor\Blazor_Learning\_Imports.razor"
using Blazor_Learning.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/{DarkMode:bool}")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 b-lreewtb8mp>Hello, world!</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"alert alert-warning\" role=\"alert\" b-lreewtb8mp>\r\n    Before authentication will function correctly, you must configure your provider details in <code b-lreewtb8mp>Program.cs</code></div>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "b-lreewtb8mp");
            __builder.AddContent(4, 
#nullable restore
#line 10 "C:\Users\DuffeyAaron\OneDrive - University of Wisconsin-Stout\Desktop\Github_Repos\Blazor\Blazor_Learning\Pages\Index.razor"
 currentToolTip

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "class", "tooltipButton");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\DuffeyAaron\OneDrive - University of Wisconsin-Stout\Desktop\Github_Repos\Blazor\Blazor_Learning\Pages\Index.razor"
                                        () => IterateAndAssign<string>(toolTips, ref currentToolTip, ref toolTipIndex)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "b-lreewtb8mp");
            __builder.AddContent(10, "Next");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(12, "<div class=\"toolTipButton\" style=\"background-color:aquamarine\" ; b-lreewtb8mp>\r\n    Test Div\r\n</div>\r\n\r\n");
            __builder.OpenComponent<Blazor_Learning.Shared.SurveyPrompt>(13);
            __builder.AddAttribute(14, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\DuffeyAaron\OneDrive - University of Wisconsin-Stout\Desktop\Github_Repos\Blazor\Blazor_Learning\Pages\Index.razor"
       
    private bool IS_DEBUGGING = true;
    private static Version languageVer = new Version("5.0");
    [Parameter]
    public bool DarkMode { get; set; }

    private List<string> toolTips = new List<string>()
    {
        "Use the search bar to find specific terms or keywords.",
        "This documentation is reflects the " + languageVer.ToString() + " version.",
        "ToolTips are fun."
    };
    private int toolTipIndex = 0;
    private string currentToolTip = "Welcome to your new app.";


    /// <summary>
    /// Iterates through the given List&lt;T&gt; and assigns the value at 
    /// <paramref name="iterator"/>'s position to <paramref name="element"/>.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="list">List&lt;T&gt; to iterate over.</param>
    /// <param name="element">Thing being assigned to.</param>
    /// <param name="iterator">Holds index for iterating.</param>
    private void IterateAndAssign<T>(List<T> list, ref T element, ref int iterator)
    {
        if (list != null)
        {
            iterator++;
            if (iterator > list.Count - 1) { iterator = 0; }
            element = list[iterator];
        }
        else if(IS_DEBUGGING)
        {
            Console.WriteLine($"{list} is null. Cannot iterate and assign using it.");
        }
    }

    /// <summary>
    /// Iterates through the given T[] and assigns the value at 
    /// <paramref name="iterator"/>'s position to <paramref name="element"/>.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="list">T[] to iterate over.</param>
    /// <param name="element">Thing being assigned to.</param>
    /// <param name="iterator">Holds index for iterating.</param>
    /// 
    private void IterateAndAssign<T>(T[] list, ref T element, ref int iterator)
    {
        if (list != null)
        {
            iterator++;
            if (iterator > list.Length - 1) { iterator = 0; }
            element = list[iterator];
        }
        else if(IS_DEBUGGING)
        {
            Console.WriteLine($"{list} is null. Cannot iterate and assign using it.");
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
