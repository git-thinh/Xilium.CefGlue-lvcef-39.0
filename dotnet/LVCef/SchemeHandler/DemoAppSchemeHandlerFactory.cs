namespace LVCef
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Xilium.CefGlue;

    public class DemoAppSchemeHandlerFactory : CefSchemeHandlerFactory
    {
        protected override CefResourceHandler Create(CefBrowser browser, CefFrame frame, string schemeName, CefRequest request)
        {
            return new DumpRequestResourceHandler();
        }
    }
}
