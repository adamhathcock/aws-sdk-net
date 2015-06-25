﻿using CommonTests.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Core;

namespace WindowsPhoneApp
{
    public class WindowsPhoneRunner : TestRunner
    {
        private Windows.UI.Core.CoreDispatcher _dispatcher;
        private Windows.UI.Xaml.Controls.TextBlock _output;

        public WindowsPhoneRunner(Windows.UI.Core.CoreDispatcher dispatcher, Windows.UI.Xaml.Controls.TextBlock textBlock)
        {
            _dispatcher = dispatcher;
            _output = textBlock;
        }

        protected override string TestTypeNamePrefix
        {
            get { return "Windows Phone 8.1"; }
        }

        protected override void WriteLine(string message)
        {
            _dispatcher.RunAsync(CoreDispatcherPriority.Normal,
                () => { _output.Text = _output.Text + "\n" + message; }).AsTask().Wait();
        }
    }
}
