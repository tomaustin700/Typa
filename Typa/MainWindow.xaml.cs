using System;
using System.Windows;
using System.Windows.Forms;
using Typa.Helpers;
using WindowsInput;

namespace Typa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private uint _hotKey1;
        private HotKeyHelper _hotKeys;

        public MainWindow()
        {
            InitializeComponent();

            _hotKeys = new HotKeyHelper(this, HandleHotKey);
            _hotKey1 = _hotKeys.ListenForHotKey(System.Windows.Forms.Keys.V, HotKeyModifiers.Control | HotKeyModifiers.Alt);

            notifyIcon.Visibility = Visibility.Collapsed;
            notifyIcon.Visibility = Visibility.Visible;

            //Hide();


        }


        // minimize to system tray when applicaiton is minimized
        //protected override void OnStateChanged(EventArgs e)
        //{
        //    if (WindowState == WindowState.Minimized)
        //    {
        //        Hide();
        //    }


        //    base.OnStateChanged(e);
        //}

        // minimize to system tray when applicaiton is closed
        //protected override void OnClosing(CancelEventArgs e)
        //{
        //    // setting cancel to true will cancel the close request
        //    // so the application is not closed

        //    e.Cancel = true;

        //    Hide();

        //    base.OnClosing(e);
        //}

        //protected override void OnSourceInitialized(EventArgs e)
        //{
        //    base.OnSourceInitialized(e);


        //}



        [STAThread]
        void HandleHotKey(int keyId)
        {
            if (keyId == _hotKey1)
            {
                var clipboardText = System.Windows.Clipboard.GetText();
                
                var test = new InputSimulator();
                test.Keyboard.TextEntry(clipboardText);
            }

        }

      
    }
}
