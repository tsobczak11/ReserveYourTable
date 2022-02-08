#pragma checksum "/Users/tsobczak/440-Group-6-Fall-2021/Code/ReserveATable/Pages/RestHelp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "243c6ebcdb7e70d798092f5b010b18a903564173"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ReserveATable.Pages.Pages_RestHelp), @"mvc.1.0.razor-page", @"/Pages/RestHelp.cshtml")]
namespace ReserveATable.Pages
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
#line 1 "/Users/tsobczak/440-Group-6-Fall-2021/Code/ReserveATable/Pages/_ViewImports.cshtml"
using ReserveATable;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"243c6ebcdb7e70d798092f5b010b18a903564173", @"/Pages/RestHelp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5638e6b43d180ee53bda6c6b2337da4c78148bcc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_RestHelp : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/tsobczak/440-Group-6-Fall-2021/Code/ReserveATable/Pages/RestHelp.cshtml"
  
    ViewData["Title"] = "Resturaunt Help";
    Layout = "_LayoutForRestaurant";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome to Restaurant Help</h1>
</div>

<h1 class=""subHdHelpPage"">Login</h1>
<p>Use your restaurant's username and password to login to the restaurant portal.</p>

<h2 class=""subHdHelpPage"">Update</h2>
<p>On the ""Update"" page, you can update the restaurant's contact information, menu items, seating, or account information.</p>

<h3 class=""subHdHelpPage"">Manage</h3>
<p>The ""Manage"" page will allow you to manage customers' reservations, accept reservations, and manually add walk in reservation details.</p>

<h4 class=""subHdHelpPage"">Confirm</h4>
<p>On the ""Confirm"" page, you will be able to see customers' payment information, then you can accept and confirm the customers' payments.</p>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RestHelpModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RestHelpModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RestHelpModel>)PageContext?.ViewData;
        public RestHelpModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
