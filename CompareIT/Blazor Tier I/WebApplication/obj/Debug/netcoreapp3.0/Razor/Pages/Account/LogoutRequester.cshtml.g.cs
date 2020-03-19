#pragma checksum "C:\Users\Radu\Desktop\SEP3-Switchers\Blazor Tier I\WebApplication\Pages\Account\LogoutRequester.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c6cb7fe1bb125fe222c8a142bdd89c188b8ae48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Account_LogoutRequester), @"mvc.1.0.razor-page", @"/Pages/Account/LogoutRequester.cshtml")]
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
#line 3 "C:\Users\Radu\Desktop\SEP3-Switchers\Blazor Tier I\WebApplication\Pages\Account\LogoutRequester.cshtml"
using WebApplication.Shared;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/logoutRequester")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c6cb7fe1bb125fe222c8a142bdd89c188b8ae48", @"/Pages/Account/LogoutRequester.cshtml")]
    public class Pages_Account_LogoutRequester : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Users\Radu\Desktop\SEP3-Switchers\Blazor Tier I\WebApplication\Pages\Account\LogoutRequester.cshtml"
           
    private string _username;
    private string _password;

    public async Task PerformLogin()
    {
        Console.WriteLine("Login here");
        var interop = new Interop(jsRuntime);
        string antiforgerytoken = await interop.GetElementByName("__RequestVerificationToken");

        // Here I provide fields matching the arguments of my login method, in LoginRequester.cshtml.cs
        var fields = new { __RequestVerificationToken = antiforgerytoken, username = _username, password = _password };

        // Here I make a call to the loginRequester.cshtml.cs, the post method, with fields as argument.
        // it happens through the Interop.cs class
        await interop.SubmitForm("/logoutRequester/", fields);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.JSInterop.IJSRuntime jsRuntime { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication.Pages.Account.LogoutRequesterModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication.Pages.Account.LogoutRequesterModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication.Pages.Account.LogoutRequesterModel>)PageContext?.ViewData;
        public WebApplication.Pages.Account.LogoutRequesterModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
