using JewelSuite.DesktopClient.ViewModels;
using System;
using System.Windows;

namespace JewelSuite.DesktopClient.Views
{
    
    public partial class ReservoirView : Window
    {
        public ReservoirView()
        {
            InitializeComponent();
            DataContext = new ReservoirViewModel();


        }

        
    }
}
