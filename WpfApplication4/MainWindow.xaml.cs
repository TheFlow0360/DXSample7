using System;
using System.Windows;
using DevExpress.Xpf.Ribbon;

namespace WpfApplication4
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(Object sender, RoutedEventArgs e)
        {
            var dxWin = new DXRibbonWindow();
            dxWin.Icon = this.Icon;
            dxWin.Show();
        }
    }
}
