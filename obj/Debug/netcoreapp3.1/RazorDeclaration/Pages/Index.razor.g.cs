// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ManikandanLakshmanan\Downloads\Spinner_Tab-1437981428 (1)\Toast_reusable-1920152305\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ManikandanLakshmanan\Downloads\Spinner_Tab-1437981428 (1)\Toast_reusable-1920152305\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ManikandanLakshmanan\Downloads\Spinner_Tab-1437981428 (1)\Toast_reusable-1920152305\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ManikandanLakshmanan\Downloads\Spinner_Tab-1437981428 (1)\Toast_reusable-1920152305\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ManikandanLakshmanan\Downloads\Spinner_Tab-1437981428 (1)\Toast_reusable-1920152305\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ManikandanLakshmanan\Downloads\Spinner_Tab-1437981428 (1)\Toast_reusable-1920152305\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ManikandanLakshmanan\Downloads\Spinner_Tab-1437981428 (1)\Toast_reusable-1920152305\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ManikandanLakshmanan\Downloads\Spinner_Tab-1437981428 (1)\Toast_reusable-1920152305\_Imports.razor"
using Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ManikandanLakshmanan\Downloads\Spinner_Tab-1437981428 (1)\Toast_reusable-1920152305\_Imports.razor"
using Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ManikandanLakshmanan\Downloads\Spinner_Tab-1437981428 (1)\Toast_reusable-1920152305\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ManikandanLakshmanan\Downloads\Spinner_Tab-1437981428 (1)\Toast_reusable-1920152305\_Imports.razor"
using Syncfusion.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ManikandanLakshmanan\Downloads\Spinner_Tab-1437981428 (1)\Toast_reusable-1920152305\Pages\Index.razor"
using Syncfusion.Blazor.Spinner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ManikandanLakshmanan\Downloads\Spinner_Tab-1437981428 (1)\Toast_reusable-1920152305\Pages\Index.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ManikandanLakshmanan\Downloads\Spinner_Tab-1437981428 (1)\Toast_reusable-1920152305\Pages\Index.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\ManikandanLakshmanan\Downloads\Spinner_Tab-1437981428 (1)\Toast_reusable-1920152305\Pages\Index.razor"
 
    SfSpinner _spinner;
    private bool _showSpinner = false;
    private string _textInput = string.Empty;

    private async void click()
    {
        _showSpinner = true;
        await jsRuntime.InvokeAsync<object>("accessDOMElement");


    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
#pragma warning restore 1591
