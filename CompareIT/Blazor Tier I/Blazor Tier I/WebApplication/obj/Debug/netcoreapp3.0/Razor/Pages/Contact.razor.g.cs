#pragma checksum "C:\Users\Ati\OneDrive - ViaUC\Semester 3\SEP3\hand-in SEP3\CompareIT\Blazor Tier I\Blazor Tier I\WebApplication\Pages\Contact.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ce976e10b271d888f2dc8350eefeaba96afb2df"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Ati\OneDrive - ViaUC\Semester 3\SEP3\hand-in SEP3\CompareIT\Blazor Tier I\Blazor Tier I\WebApplication\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ati\OneDrive - ViaUC\Semester 3\SEP3\hand-in SEP3\CompareIT\Blazor Tier I\Blazor Tier I\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ati\OneDrive - ViaUC\Semester 3\SEP3\hand-in SEP3\CompareIT\Blazor Tier I\Blazor Tier I\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ati\OneDrive - ViaUC\Semester 3\SEP3\hand-in SEP3\CompareIT\Blazor Tier I\Blazor Tier I\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ati\OneDrive - ViaUC\Semester 3\SEP3\hand-in SEP3\CompareIT\Blazor Tier I\Blazor Tier I\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ati\OneDrive - ViaUC\Semester 3\SEP3\hand-in SEP3\CompareIT\Blazor Tier I\Blazor Tier I\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ati\OneDrive - ViaUC\Semester 3\SEP3\hand-in SEP3\CompareIT\Blazor Tier I\Blazor Tier I\WebApplication\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ati\OneDrive - ViaUC\Semester 3\SEP3\hand-in SEP3\CompareIT\Blazor Tier I\Blazor Tier I\WebApplication\_Imports.razor"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ati\OneDrive - ViaUC\Semester 3\SEP3\hand-in SEP3\CompareIT\Blazor Tier I\Blazor Tier I\WebApplication\_Imports.razor"
using WebApplication.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Contact")]
    public partial class Contact : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    #navlist {
        float: right;
        position: absolute;
    }

    #bigdiv {
        width: 100%;
        border: 1px solid #ccc;
        border-radius: 7px;
        text-align: center;
    }

    #title {
        font-size: 3em;
    }

    #subtitle {
        font-size: 1.5em;
    }

    .name {
        width: 60%;
        height: 35px;
        border-radius: 3px;
    }

    #message {
        width: 60%;
        height: 170px;
        border: 2px solid #aaa;
        border-radius: 3px;
    }

    #send {
        border: 2px solid #bbb;
        border-radius: 3px;
        width: 20%;
    }
</style>
");
            __builder.AddMarkupContent(1, @"<div id=""bigdiv"">
    <p id=""title"" class=""text-center"">Contact us</p>
    <br>
    <p id=""subtitle"" class=""text-center"">Send us information about any problems or advice you might have.</p>
    <hr>
    <form action=""mailto:raducutu99@gmail.com"">
        <p class=""text-center"">First Name</p>
        <input type=""text"" class=""name"" name=""fname"" required>
        <br>
        <br>
        <p class=""text-center"">Last Name</p>
        <input type=""text"" class=""name"" name=""lname"" required>
        <br>
        <br>
        <p class=""text-center"">Your Email Address</p>
        <input type=""text"" class=""name"" name=""email"" required>
        <br>
        <br>
        <p class=""text-center"">Email Subject</p>
        <input type=""text"" class=""name"" name=""subject"" required>
        <br>
        <br>
        <p class=""text-center"">Your Message</p>
        <textarea id=""message"" required spellcheck=""false""></textarea>
        <br>
        <br>
        <input type=""checkbox"" id=""checkbox"" required> By checking this box and submitting your information, you are granting us permission to email you.
        <br>
        <br>
        <input type=""submit"" class=""btn btn-default"" id=""send"" value=""Send Message"">
    </form>
</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
