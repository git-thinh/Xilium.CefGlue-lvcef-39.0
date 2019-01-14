namespace LVCef.ClientHandlers
{
    using System;
    using System.Collections.Generic;
    using Xilium.CefGlue;
    using Xilium.CefGlue.Wrapper;
    using LVCef.Control;
    using System.Diagnostics;

    public sealed class LVCefLoadHandler : CefLoadHandler
    {
        private readonly LVCefControl _lvCefControl;

        public LVCefLoadHandler(LVCefControl core)
        {
            _lvCefControl = core;
        }

        protected override void OnLoadingStateChange(CefBrowser browser, bool isLoading, bool canGoBack, bool canGoForward)
        {
            _lvCefControl.OnLoadingStateChanged(isLoading, canGoBack, canGoForward);
        }

        protected override void OnLoadStart(CefBrowser browser, CefFrame frame)
        {
            var handler = LoadStart;
            if (handler != null)
                handler(this, new LoadStartUrlEventArgs(frame.Url));
        }

        protected override void OnLoadEnd(CefBrowser browser, CefFrame frame, int httpStatusCode)
        {
            var handler = LoadEnd;
            if (handler != null)
                handler(this, new LoadEndUrlEventArgs(frame.Url, httpStatusCode));
        }

        public event EventHandler<LoadStartUrlEventArgs> LoadStart;
        public event EventHandler<LoadEndUrlEventArgs> LoadEnd;
        public sealed class LoadStartUrlEventArgs : EventArgs
        {
            public readonly string Url;
            public LoadStartUrlEventArgs(string url)
            {
                this.Url = url;
            }
        }
        public sealed class LoadEndUrlEventArgs : EventArgs
        {
            public readonly string Url;
            public readonly int httpStatusCode;
            public LoadEndUrlEventArgs(string url, int httpStatusCode)
            {
                this.Url = url;
                this.httpStatusCode = httpStatusCode;
            }
        }
    }
}
