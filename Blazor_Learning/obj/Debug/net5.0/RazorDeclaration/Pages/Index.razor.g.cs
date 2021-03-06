// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/{darkMode:bool}")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\DuffeyAaron\OneDrive - University of Wisconsin-Stout\Desktop\Github_Repos\Blazor\Blazor_Learning\Pages\Index.razor"
      
    private bool IS_DEBUGGING = true;
    private static Version languageVer = new Version("5.0");
    [Parameter]
    public bool darkMode { get; set; }

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
        else if (IS_DEBUGGING)
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
        else if (IS_DEBUGGING)
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
