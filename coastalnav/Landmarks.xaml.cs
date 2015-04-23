using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace CoastalNav
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Landmarks : Page
    {
        public Landmarks()
        {
            this.InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void btnConnaught_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Connaught));
        }

        private void btnUlster_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Ulster));
        }

        private void btnMunster_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Munster));
        }

        private void btnLeinster_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Leinster));
        }

        
    }
}
