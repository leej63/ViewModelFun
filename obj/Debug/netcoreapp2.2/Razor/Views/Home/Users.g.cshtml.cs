#pragma checksum "C:\Coding Dojo\C#_stack\ASP.NET Core\ASP MVC II\ViewModelFun\Views\Home\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "388c2a435c1ac00592efdc8baed8f6660487c98d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Users), @"mvc.1.0.view", @"/Views/Home/Users.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Users.cshtml", typeof(AspNetCore.Views_Home_Users))]
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
#line 1 "C:\Coding Dojo\C#_stack\ASP.NET Core\ASP MVC II\ViewModelFun\Views\_ViewImports.cshtml"
using ViewModelFun;

#line default
#line hidden
#line 2 "C:\Coding Dojo\C#_stack\ASP.NET Core\ASP MVC II\ViewModelFun\Views\_ViewImports.cshtml"
using ViewModelFun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"388c2a435c1ac00592efdc8baed8f6660487c98d", @"/Views/Home/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7312364e6c23e4cb7805f9e5f986831fce186000", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 44, true);
            WriteLiteral("\r\n<div>\r\n    <h1>Here are some Users!</h1>\r\n");
            EndContext();
#line 5 "C:\Coding Dojo\C#_stack\ASP.NET Core\ASP MVC II\ViewModelFun\Views\Home\Users.cshtml"
      
        foreach(User name in Model)
        {

#line default
#line hidden
            BeginContext(119, 15, true);
            WriteLiteral("            <p>");
            EndContext();
            BeginContext(135, 14, false);
#line 8 "C:\Coding Dojo\C#_stack\ASP.NET Core\ASP MVC II\ViewModelFun\Views\Home\Users.cshtml"
          Write(name.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(149, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(151, 13, false);
#line 8 "C:\Coding Dojo\C#_stack\ASP.NET Core\ASP MVC II\ViewModelFun\Views\Home\Users.cshtml"
                          Write(name.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(164, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 9 "C:\Coding Dojo\C#_stack\ASP.NET Core\ASP MVC II\ViewModelFun\Views\Home\Users.cshtml"
        }
    

#line default
#line hidden
            BeginContext(188, 6, true);
            WriteLiteral("</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
