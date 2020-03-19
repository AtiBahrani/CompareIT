#pragma checksum "C:\Users\Radu\Desktop\SEP3-Switchers\Blazor Tier I\WebApplication\Pages\Account\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56705a23c1bc72ceae995289ee903861ed2656b0"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Radu\Desktop\SEP3-Switchers\Blazor Tier I\WebApplication\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Radu\Desktop\SEP3-Switchers\Blazor Tier I\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Radu\Desktop\SEP3-Switchers\Blazor Tier I\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Radu\Desktop\SEP3-Switchers\Blazor Tier I\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Radu\Desktop\SEP3-Switchers\Blazor Tier I\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Radu\Desktop\SEP3-Switchers\Blazor Tier I\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Radu\Desktop\SEP3-Switchers\Blazor Tier I\WebApplication\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Radu\Desktop\SEP3-Switchers\Blazor Tier I\WebApplication\_Imports.razor"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Radu\Desktop\SEP3-Switchers\Blazor Tier I\WebApplication\_Imports.razor"
using WebApplication.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\Radu\Desktop\SEP3-Switchers\Blazor Tier I\WebApplication\Pages\Account\Register.razor"
       
    private string firstName;
    private string lastName;
    private string _username;
    private string _password;
    private string email;

    private string errormessage = "";

    public async Task PerformRegister()
    {
        try
        {
            //connection.sendRegisterRequest(firstName, lastName, _username, _password, email);
            var interop = new Interop(jsRuntime);
            string antiforgerytoken = await interop.GetElementByName("__RequestVerificationToken");

            // Here I provide fields matching the arguments of my login method, in LoginRequester.cshtml.cs
            var fields = new { __RequestVerificationToken = antiforgerytoken, username = _username, password = _password };

            // Here I make a call to the loginRequester.cshtml.cs, the post method, with fields as argument.
            // it happens through the Interop.cs class
            await interop.SubmitForm("/loginRequester/", fields);
        }
        catch (Exception e)
        {
            if (e.Message.Equals("Username already used."))
            {
                errormessage = e.Message;
            }
        }

    }
    public void Cancel()
    {
        NavigationManager.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WebApplication.Data.Connection connection { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
