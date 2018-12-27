﻿using OCMApp.Helper;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OCMApp.Info
{
    /// <summary>
    /// Interaction logic for InfoView.xaml
    /// </summary>
    public partial class InfoView : UserControl
    {
        public InfoView()
        {
            InitializeComponent();
        }

        private void WebsiteLink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            try
            {
                if (e.Uri.IsFile)
                {
                    Folder.GetFolder(e.Uri.PathAndQuery);
                }
                System.Diagnostics.Process.Start(e.Uri.ToString());
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Could not open Uri request");
            }
        }
    }
}