#pragma checksum "C:\Users\t-xinma\source\repos\SSLTLSWeb\Views\tls\attack.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74aba974982583840116f9bcfb9d495267a73bab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_tls_attack), @"mvc.1.0.view", @"/Views/tls/attack.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/tls/attack.cshtml", typeof(AspNetCore.Views_tls_attack))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74aba974982583840116f9bcfb9d495267a73bab", @"/Views/tls/attack.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21148e7936e0be25ff36149f596c27e0e342f215", @"/Views/_ViewImports.cshtml")]
    public class Views_tls_attack : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\t-xinma\source\repos\SSLTLSWeb\Views\tls\attack.cshtml"
  
    ViewData["title"] = "attack";

#line default
#line hidden
            BeginContext(165, 3141, true);
            WriteLiteral(@"
<h3 style=""text-align:center""><strong>Transport Layer Security Attack</strong></h3>

<br/>
<h4><strong>Renegotiation attack</strong></h4>
<p>
    A vulnerability of the renegotiation procedure was discovered in <strong>August 2009</strong> that can lead to plaintext injection attacks against SSL 3.0 and all current versions of TLS.
</p>
<p>
    For example, it allows an attacker who can hijack an https connection to splice their own requests into the beginning of the conversation the client has with the web server. The attacker can't actually decrypt the client–server communication, so it is different from a typical man-in-the-middle attack.
</p>
<p>
    A short-term fix is for web servers to stop allowing renegotiation, which typically will not require other changes unless client certificate authentication is used. To fix the vulnerability, a renegotiation indication extension was proposed for TLS. It will require the client and server to include and verify information about previous handshakes ");
            WriteLiteral(@"in any renegotiation handshakes. This extension has become a proposed standard and has been assigned the number RFC 5746. The RFC has been implemented by several libraries.
</p>

<br/>
<h4><strong>Downgrade attacks: FREAK attack and Logjam attack</strong></h4>
<i>Main articles: FREAK and Logjam (computer security)</i>
<p>
    A protocol downgrade attack (also called a version rollback attack) tricks a web server into negotiating connections with previous versions of TLS (such as SSLv2) that have long since been abandoned as insecure.
    Previous modifications to the original protocols, like False Start (adopted and enabled by Google Chrome) or Snap Start, reportedly introduced limited TLS protocol downgrade attacks or allowed modifications to the cipher suite list sent by the client to the server. <strong>In doing so, an attacker might succeed in influencing the cipher suite selection in an attempt to downgrade the cipher suite negotiated to use either a weaker symmetric encryption algorithm or a wea");
            WriteLiteral(@"ker key exchange.</strong> A paper presented at an ACM conference on computer and communications security in 2012 demonstrated that the False Start extension was at risk: in certain circumstances it could allow an attacker to recover the encryption keys offline and to access the encrypted data.
</p>
<p>
    Encryption downgrade attacks can force servers and clients to negotiate a connection using cryptographically weak keys. In 2014, a man-in-the-middle attack called FREAK was discovered affecting the OpenSSL stack, the default Android web browser, and some Safari browsers. The attack involved tricking servers into negotiating a TLS connection using cryptographically weak 512 bit encryption keys.
    Logjam is a security exploit discovered in May 2015 that exploits the option of using legacy ""export-grade"" 512-bit Diffie–Hellman groups dating back to the 1990s. It forces susceptible servers to downgrade to cryptographically weak 512-bit Diffie–Hellman groups. An attacker can then deduce the keys the clien");
            WriteLiteral("t and server determine using the Diffie–Hellman key exchange.\r\n</p>\r\n");
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