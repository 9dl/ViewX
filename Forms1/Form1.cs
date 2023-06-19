using CefSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms1
{
    public partial class Form1 : Form
    {
        public static string URL = "";

        public Form1()
        {
            InitializeComponent();

            if (URL == string.Empty)
                chromiumWebBrowser1.LoadUrl("http://127.0.0.1:3000/index.html");
            else
                chromiumWebBrowser1.LoadUrl(URL);
        }
    }
}