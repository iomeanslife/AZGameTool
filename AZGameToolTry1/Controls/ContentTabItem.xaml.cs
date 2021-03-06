﻿using AZGameToolTry1.Model;
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

namespace AZGameToolTry1.Controls
{
    /// <summary>
    /// Interaction logic for ContentTabItem.xaml
    /// </summary>
    public partial class ContentTabItem : TabItem
    {
        public ContentTabItem()
        {
            InitializeComponent();
        }

        private void WebBrowser_Loaded(object sender, RoutedEventArgs e)
        {
            mdWebViewer.NavigateToString(((ReadMe)DataContext).Text);
        }
    }
}
