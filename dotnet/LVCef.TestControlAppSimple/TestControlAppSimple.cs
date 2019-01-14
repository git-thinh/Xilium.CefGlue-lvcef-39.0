using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using LVCef.ClientHandlers;

namespace TestControlAppSimple
{
    public partial class TestControlAppSimpleForm : Form
    {
        private const string DBGPREFIX = "[TestControlAppSimple]: ";

        public TestControlAppSimpleForm()
        {
            InitializeComponent();
            txtUrl.Text = "http://localhost:8000/jstest.html";
            //lvCefControl1.StartUrl = "http://localhost:8000/jstest.html";
            //lvCefControl1.StartUrl = "https://dictionary.cambridge.org/grammar/british-grammar/";
            LVCefClient lvcefclient = lvCefControl1.CefClient;
            if (lvCefControl1.CefClient != null)
            {
                lvcefclient.MessageRouterHandler.OnQueryEvent += (src, onquery) =>
                {
                    onquery.Handled = true;
                    onquery.callback.Success("huzzah");
                };
                lvcefclient.LifeSpanHandler.OnAfterCreatedEvent += (src, onafter) =>
                {
                    if (button2.InvokeRequired)
                        button2.Invoke((Action)delegate { button2.Enabled = true; });
                    else
                        button2.Enabled = true;
                };
                lvcefclient.RequestHandler.OnGetResourceHandlerEvent += (src, onget) =>
                {
                    if (onget.request.Url.Contains("stop"))
                        onget.DelegateRequest = true;
                };
                lvcefclient.RequestHandler.OnProcessRequestEvent += (src, onprocess) =>
                {
                    onprocess.continueRequest = false;
                };

                lvcefclient.LoadHandler.LoadStart += (se, ev) =>
                {
                    lvCefControl1.ExecuteJavaScript("console.log('LoadStart: " + ev.Url + "');");
                };
                lvcefclient.LoadHandler.LoadEnd += (se, ev) =>
                {
                    lvCefControl1.ExecuteJavaScript("console.log('LoadEnd: " + ev.Url + "');");
                };

                lvCefControl1.createBrowser();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lvCefControl1.Browser.GetMainFrame().LoadUrl(txtUrl.Text);
            //lvCefControl1.StartUrl = txtUrl.Text;
        }

        private void TestControlAppSimpleForm_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(DBGPREFIX + "Navigating to new URL");
            lvCefControl1.Browser.GetMainFrame().LoadUrl("http://localhost:8000/dummy.html");
        }

        private void btnDevTool_Click(object sender, EventArgs e)
        {
            lvCefControl1.openDevTools();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            lvCefControl1.Browser.GetMainFrame().LoadUrl(txtUrl.Text); 
        }
    }
}
