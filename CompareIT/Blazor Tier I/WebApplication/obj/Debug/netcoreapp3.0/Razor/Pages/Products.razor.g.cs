#pragma checksum "C:\Users\Radu\Desktop\SEP3-Switchers\Blazor Tier I\WebApplication\Pages\Products.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fa0c4e3abe2b62e0541c4121ab179b4c33ad271"
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
#nullable restore
#line 3 "C:\Users\Radu\Desktop\SEP3-Switchers\Blazor Tier I\WebApplication\Pages\Products.razor"
using RestSharp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Radu\Desktop\SEP3-Switchers\Blazor Tier I\WebApplication\Pages\Products.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Radu\Desktop\SEP3-Switchers\Blazor Tier I\WebApplication\Pages\Products.razor"
using WebApplication.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Products")]
    public partial class Products : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    #titlediv {
        margin-top: 5%;
        margin-left: 5%;
    }

    #itemdiv {
        margin-top: 1.5%;
        height: 160px;
        width: 90%;
        border: 1px solid #ccc;
        border-radius: 4px;
    }

    #imagediv {
        float: left;
        width: 23%;
        height: 158px;
        border: 1px solid #ccc;
        border-radius: 2px;
    }

    #link{
        width:100%;
    }
    #photo {
        width: 100%;
        height: 100%;
    }

    #itemDescDiv {
        float: left;
        width: 70.9%;
        height: 100%;
        border: 1px solid #ccc;
        border-radius: 2px;
    }

    #adddiv {
        width: 6%;
        float: right;
    }
</style>

");
            __builder.AddMarkupContent(1, "<div id=\"titlediv\">\r\n    <h2 class=\"display-4\">Your search results:</h2>\r\n</div>\r\n\r\n");
            __builder.OpenElement(2, "ul");
            __builder.AddAttribute(3, "class", "list-unstyled");
            __builder.AddMarkupContent(4, "\r\n");
#nullable restore
#line 58 "C:\Users\Radu\Desktop\SEP3-Switchers\Blazor Tier I\WebApplication\Pages\Products.razor"
     foreach (var item in connection.Final)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "        ");
            __builder.OpenElement(6, "li");
            __builder.AddAttribute(7, "id", 
#nullable restore
#line 60 "C:\Users\Radu\Desktop\SEP3-Switchers\Blazor Tier I\WebApplication\Pages\Products.razor"
                 index

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "id", "itemdiv");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "a");
            __builder.AddAttribute(13, "href", 
#nullable restore
#line 62 "C:\Users\Radu\Desktop\SEP3-Switchers\Blazor Tier I\WebApplication\Pages\Products.razor"
                          item.URL

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(14, "target", "_blank");
            __builder.AddAttribute(15, "id", "link");
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.AddMarkupContent(17, "<div id=\"imagediv\"><img src=\"~/Images/no-img.png\" id=\"photo\" alt=\"Product image.\"></div>\r\n                    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "id", "itemDescDiv");
            __builder.AddMarkupContent(20, "\r\n                        ");
            __builder.OpenElement(21, "p");
            __builder.AddContent(22, 
#nullable restore
#line 65 "C:\Users\Radu\Desktop\SEP3-Switchers\Blazor Tier I\WebApplication\Pages\Products.razor"
                            item.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                        <br>\r\n                        ");
            __builder.OpenElement(24, "p");
            __builder.AddContent(25, "Rating of the product: ");
            __builder.AddContent(26, 
#nullable restore
#line 67 "C:\Users\Radu\Desktop\SEP3-Switchers\Blazor Tier I\WebApplication\Pages\Products.razor"
                                                    Math.Round(item.Rating)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                        <br>\r\n                        ");
            __builder.OpenElement(28, "p");
            __builder.AddContent(29, "Price: ");
            __builder.AddContent(30, 
#nullable restore
#line 69 "C:\Users\Radu\Desktop\SEP3-Switchers\Blazor Tier I\WebApplication\Pages\Products.razor"
                                   item.Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(31, " ");
            __builder.AddContent(32, 
#nullable restore
#line 69 "C:\Users\Radu\Desktop\SEP3-Switchers\Blazor Tier I\WebApplication\Pages\Products.razor"
                                               item.PriceCurrency

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "id", "adddiv");
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "id", "add");
            __builder.AddAttribute(41, "class", "btn btn-danger");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\Radu\Desktop\SEP3-Switchers\Blazor Tier I\WebApplication\Pages\Products.razor"
                                                                      () => AddToWishList(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(43, "Add to wishlist");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n        ");
            __builder.OpenElement(48, "li");
            __builder.AddAttribute(49, "hidden", true);
            __builder.AddContent(50, 
#nullable restore
#line 77 "C:\Users\Radu\Desktop\SEP3-Switchers\Blazor Tier I\WebApplication\Pages\Products.razor"
                     index++

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
#nullable restore
#line 78 "C:\Users\Radu\Desktop\SEP3-Switchers\Blazor Tier I\WebApplication\Pages\Products.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "C:\Users\Radu\Desktop\SEP3-Switchers\Blazor Tier I\WebApplication\Pages\Products.razor"
      
    public int index { get; set; } = 0;

    private void AddToWishList(Item item)
    {

        UserWish userWish = new UserWish { ID = internalWishlist.Username, Title = item.Title, URL = item.URL };
        internalWishlist.AddWish(userWish);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WebApplication.Data.Wishlist internalWishlist { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WebApplication.Data.Connection connection { get; set; }
    }
}
#pragma warning restore 1591
