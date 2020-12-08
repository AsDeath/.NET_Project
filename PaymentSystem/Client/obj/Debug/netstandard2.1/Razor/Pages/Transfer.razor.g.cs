#pragma checksum "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\Pages\Transfer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51bc221f939bc88d01cf9e4710acd9d520c33e5e"
// <auto-generated/>
#pragma warning disable 1591
namespace PaymentSystem.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\_Imports.razor"
using PaymentSystem.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\_Imports.razor"
using PaymentSystem.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\Pages\Transfer.razor"
using PaymentSystem.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\Pages\Transfer.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\Pages\Transfer.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\Pages\Transfer.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/transfer/{sourceWalletId}")]
    public partial class Transfer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Transfer</h3>");
#nullable restore
#line 11 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\Pages\Transfer.razor"
 if (wallet == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<div>Loading...</div>");
#nullable restore
#line 14 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\Pages\Transfer.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card");
            __builder.AddAttribute(4, "style", "width: 18rem;");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-body");
            __builder.OpenElement(7, "h5");
            __builder.AddAttribute(8, "class", "card-title");
            __builder.AddContent(9, "Wallet ");
            __builder.AddContent(10, 
#nullable restore
#line 19 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\Pages\Transfer.razor"
                                           wallet.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "p");
            __builder.AddAttribute(13, "class", "card-text");
            __builder.AddContent(14, "Amount: ");
            __builder.AddContent(15, 
#nullable restore
#line 20 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\Pages\Transfer.razor"
                                          wallet.Amount

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(16, " ");
            __builder.AddContent(17, 
#nullable restore
#line 20 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\Pages\Transfer.razor"
                                                         wallet.Currency

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "p");
            __builder.AddMarkupContent(20, "\r\n                Amount:<br>\r\n                ");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\Pages\Transfer.razor"
                              transferData.Amount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => transferData.Amount = __value, transferData.Amount));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "p");
            __builder.AddMarkupContent(26, "\r\n                Username:<br>\r\n                ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\Pages\Transfer.razor"
                              transferData.Username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => transferData.Username = __value, transferData.Username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "class", "btn btn-primary");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\Pages\Transfer.razor"
                                                      MakeTransfer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, "Transfer");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\Pages\Transfer.razor"
   
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\Mortis\source\repos\PaymentSystem\PaymentSystem\Client\Pages\Transfer.razor"
       
    [Parameter]
    public string SourceWalletId { get; set; }
    public Wallet wallet { get; set; }

    public TransferDto transferData { get; set; } = new TransferDto();

    protected override async Task OnInitializedAsync()
    {
        try
        {
            wallet = await HttpClient.GetFromJsonAsync<Wallet>($"api/wallet/{SourceWalletId}");
        }
        catch (AccessTokenNotAvailableException exception)
        {
            exception.Redirect();
        }
    }

    private async Task MakeTransfer()
    {
        try
        {
            transferData.SourceWalletId = SourceWalletId;
            transferData.Currency = wallet.Currency;
            var response = await HttpClient.PostAsJsonAsync($"api/wallet/transfer", transferData);
            if (response.IsSuccessStatusCode)
            {
                navManger.NavigateTo("wallets");
            }
        }
        catch (AccessTokenNotAvailableException exception)
        {
            exception.Redirect();
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591
