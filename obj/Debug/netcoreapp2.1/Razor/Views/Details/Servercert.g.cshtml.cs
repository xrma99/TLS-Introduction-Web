#pragma checksum "C:\Users\t-xinma\source\repos\SSLTLSWeb\Views\Details\Servercert.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19769385ced55912c238c55fef4fc4b1c73d09fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Details_Servercert), @"mvc.1.0.view", @"/Views/Details/Servercert.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Details/Servercert.cshtml", typeof(AspNetCore.Views_Details_Servercert))]
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
#line 1 "C:\Users\t-xinma\source\repos\SSLTLSWeb\Views\_ViewImports.cshtml"
using SSLTLSWeb;

#line default
#line hidden
#line 2 "C:\Users\t-xinma\source\repos\SSLTLSWeb\Views\_ViewImports.cshtml"
using SSLTLSWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19769385ced55912c238c55fef4fc4b1c73d09fc", @"/Views/Details/Servercert.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21148e7936e0be25ff36149f596c27e0e342f215", @"/Views/_ViewImports.cshtml")]
    public class Views_Details_Servercert : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(130, 564, true);
            WriteLiteral(@"
    

<h3><strong>Server cert</strong></h3>
<ul>
    <li>Server's Certificate message. Depending on the selected cipher suite, this may be omitted by the server.</li>
    <li>ServerKeyExchange message (depending on the selected cipher suite, this may be omitted by the server). This message is sent for all DHE and DH_anon ciphersuites.</li>
    <li>ServerHelloDone message. Indicating it is done with handshake negotiation.</li>
</ul>

<div>
    <a href=""/Details/Index"">
        <strong>
            &larr; Back
        </strong>
    </a>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
