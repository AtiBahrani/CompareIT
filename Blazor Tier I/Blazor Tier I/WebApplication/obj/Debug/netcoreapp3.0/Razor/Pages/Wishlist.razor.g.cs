#pragma checksum "C:\Users\Ati\OneDrive - ViaUC\Semester 3\SEP3\hand-in SEP3\CompareIT\Blazor Tier I\Blazor Tier I\WebApplication\Pages\Wishlist.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b2940a907a5b384b5d91ff00b80c089847e1b40"
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
#nullable restore
#line 3 "C:\Users\Ati\OneDrive - ViaUC\Semester 3\SEP3\hand-in SEP3\CompareIT\Blazor Tier I\Blazor Tier I\WebApplication\Pages\Wishlist.razor"
using WebApplication.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Wishlist")]
    public partial class Wishlist : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    #container {
        margin-top:1%;
        width: 100%;
    }
    #wish {
        width: 80%;
        border: 1px solid #ccc;
        border-radius: 4px;
        float: left;
    }
    #buttondiv {
        width: 9%;
        float: right;
    }
    #link {
        width: 100%;
    }
    #title {
        width:100%;
    }
    #delete {

    }
</style>

");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "text-center");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<h3>Your wishlist:</h3>\r\n    <br>\r\n    ");
            __builder.OpenElement(5, "ul");
            __builder.AddAttribute(6, "class", "list-unstyled");
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 37 "C:\Users\Ati\OneDrive - ViaUC\Semester 3\SEP3\hand-in SEP3\CompareIT\Blazor Tier I\Blazor Tier I\WebApplication\Pages\Wishlist.razor"
         foreach (var wish in internalWishlist.wishlist)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "        ");
            __builder.OpenElement(9, "li");
            __builder.AddAttribute(10, "id", 
#nullable restore
#line 39 "C:\Users\Ati\OneDrive - ViaUC\Semester 3\SEP3\hand-in SEP3\CompareIT\Blazor Tier I\Blazor Tier I\WebApplication\Pages\Wishlist.razor"
                 index

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "id", "container");
            __builder.AddAttribute(14, "class", "text-center");
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "id", "wish");
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "id", "link");
            __builder.AddAttribute(21, "href", 
#nullable restore
#line 42 "C:\Users\Ati\OneDrive - ViaUC\Semester 3\SEP3\hand-in SEP3\CompareIT\Blazor Tier I\Blazor Tier I\WebApplication\Pages\Wishlist.razor"
                                        wish.URL

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(22, "target", "_blank");
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "p");
            __builder.AddAttribute(25, "id", "title");
            __builder.AddContent(26, 
#nullable restore
#line 43 "C:\Users\Ati\OneDrive - ViaUC\Semester 3\SEP3\hand-in SEP3\CompareIT\Blazor Tier I\Blazor Tier I\WebApplication\Pages\Wishlist.razor"
                                       wish.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "id", "buttondiv");
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "id", "delete");
            __builder.AddAttribute(35, "class", "btn btn-danger");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\Ati\OneDrive - ViaUC\Semester 3\SEP3\hand-in SEP3\CompareIT\Blazor Tier I\Blazor Tier I\WebApplication\Pages\Wishlist.razor"
                                                                         () =>DeleteWish(wish)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "p");
            __builder.AddAttribute(41, "hidden", true);
            __builder.OpenElement(42, "span");
            __builder.AddAttribute(43, "hidden", true);
            __builder.AddContent(44, 
#nullable restore
#line 49 "C:\Users\Ati\OneDrive - ViaUC\Semester 3\SEP3\hand-in SEP3\CompareIT\Blazor Tier I\Blazor Tier I\WebApplication\Pages\Wishlist.razor"
                                         index++

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
#nullable restore
#line 52 "C:\Users\Ati\OneDrive - ViaUC\Semester 3\SEP3\hand-in SEP3\CompareIT\Blazor Tier I\Blazor Tier I\WebApplication\Pages\Wishlist.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\Ati\OneDrive - ViaUC\Semester 3\SEP3\hand-in SEP3\CompareIT\Blazor Tier I\Blazor Tier I\WebApplication\Pages\Wishlist.razor"
       
    int index { get; set; } = 0;
    private void DeleteWish(UserWish wish)
    {
        internalWishlist.DeleteWish(wish);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WebApplication.Data.Connection connection { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WebApplication.Data.Wishlist internalWishlist { get; set; }
    }
}
#pragma warning restore 1591
