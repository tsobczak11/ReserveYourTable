#pragma checksum "/Users/tsobczak/440-Group-6-Fall-2021/Code/ReserveATable/Pages/RestAction.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2b168419565bd8b16513aa79a416cb193c857b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ReserveATable.Pages.Pages_RestAction), @"mvc.1.0.razor-page", @"/Pages/RestAction.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2b168419565bd8b16513aa79a416cb193c857b0", @"/Pages/RestAction.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5638e6b43d180ee53bda6c6b2337da4c78148bcc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_RestAction : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/tsobczak/440-Group-6-Fall-2021/Code/ReserveATable/Pages/RestAction.cshtml"
  
    ViewData["Title"] = "Resturaunt Login";
    Layout = "_LayoutForRestaurant";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .updatePage{
    background-color: #4CAF50;
    font-size: 24px;
    height:300px;
    width:500px;
    transition-duration: 0.4s;
    box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2), 0 6px 20px 0 rgba(0,0,0,0.19);
    }
    .managePage{
    background-color: #FFFF00;
    font-size: 24px;
    height:300px;
    width:500px;
    transition-duration: 0.4s;
    box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2), 0 6px 20px 0 rgba(0,0,0,0.19);
    }
    .confirmPage{
    background-color: #0000FF;
    font-size: 24px;
    height:300px;
    width:500px;
    transition-duration: 0.4s;
    box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2), 0 6px 20px 0 rgba(0,0,0,0.19);
    }
    .helpPage{
    background-color: #FFA500;
    font-size: 24px;
    height:300px;
    width:500px;
    transition-duration: 0.4s;
    box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2), 0 6px 20px 0 rgba(0,0,0,0.19);
    }
    .updatePage:hover, .managePage:hover, .confirmPage:hover, .helpPage:hover {
    background-color: #D3D3D3;
    color: black;
    box-shadow: ");
            WriteLiteral(@"0 12px 16px 0 rgba(0,0,0,0.24), 0 17px 50px 0 rgba(0,0,0,0.19);
    }
    
    
</style>

<div class=""text-center"">
    <h1 class=""display-4"">Welcome to Restaurant Application</h1>
</div>

<div class=""text-center"">
    <a href=""/RestUpdate"">
        <button type=""button"" class=""updatePage"">UPDATE</button>
    </a>
    <a href=""/RestManage"">
        <button type=""button"" class=""managePage"">MANAGE</button>
    </a>
</div>

<div class=""text-center"">
    <a href=""/RestConfirm"">
        <button type=""button"" class=""confirmPage"">CONFIRM</button>
    </a>
    <a href=""/RestHelp"">
        <button type=""button"" class=""helpPage"">HELP</button>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RestActionModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RestActionModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RestActionModel>)PageContext?.ViewData;
        public RestActionModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
