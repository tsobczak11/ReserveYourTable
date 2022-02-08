#pragma checksum "/Users/tsobczak/440-Group-6-Fall-2021/Code/ReserveATable/Pages/UpdateMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "600e854147a94c9d6cd90d5f746b6f294e8b75db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ReserveATable.Pages.Pages_UpdateMenu), @"mvc.1.0.razor-page", @"/Pages/UpdateMenu.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"600e854147a94c9d6cd90d5f746b6f294e8b75db", @"/Pages/UpdateMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5638e6b43d180ee53bda6c6b2337da4c78148bcc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_UpdateMenu : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/tsobczak/440-Group-6-Fall-2021/Code/ReserveATable/Pages/UpdateMenu.cshtml"
  
    ViewData["Title"] = "Contact Menu";
    Layout = "_LayoutForRestaurant";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .updateMenu{
    background-color: #4CAF50;
    font-size: 24px;
    height:300px;
    width:500px;
    transition-duration: 0.4s;
    box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2), 0 6px 20px 0 rgba(0,0,0,0.19);
    }
    .addMenu{
    background-color: #FFFF00;
    font-size: 24px;
    height:300px;
    width:500px;
    transition-duration: 0.4s;
    box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2), 0 6px 20px 0 rgba(0,0,0,0.19);
    }
    .deleteMenu{
    background-color: #0000FF;
    font-size: 24px;
    height:300px;
    width:500px;
    transition-duration: 0.4s;
    box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2), 0 6px 20px 0 rgba(0,0,0,0.19);
    }
    .uploadMenu{
    background-color: #FFA500;
    font-size: 24px;
    height:300px;
    width:500px;
    transition-duration: 0.4s;
    box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2), 0 6px 20px 0 rgba(0,0,0,0.19);
    }
    .updateMenu:hover, .addMenu:hover, .deleteMenu:hover, .uploadMenu:hover {
    background-color: #D3D3D3;
    color: black;
    box-shadow: 0 1");
            WriteLiteral(@"2px 16px 0 rgba(0,0,0,0.24), 0 17px 50px 0 rgba(0,0,0,0.19);
    }
    
    
</style>

<div class=""text-center"">
    <h1 class=""display-4"">Menu</h1>
    <p>Please choose an option to modify menu</p>
</div>

<div class=""text-center"">
    <a href=""/MenuUpdate"">
        <button type=""button"" class=""updateMenu"">UPDATE <br> MENU</button>
    </a>
    <a href=""/MenuAdd"">
        <button type=""button"" class=""addMenu"">ADD <br> ITEM</button>
    </a>
</div>

<div class=""text-center"">
    <a href=""/MenuDelete"">
        <button type=""button"" class=""deleteMenu"">DELETE</button>
    </a>
    <a href=""/MenuUpload"">
        <button type=""button"" class=""uploadMenu"">UPLOAD</button>
    </a>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UpdateMenuModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UpdateMenuModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UpdateMenuModel>)PageContext?.ViewData;
        public UpdateMenuModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591