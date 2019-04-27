using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWPDemo.Controls;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPDemo.Pages.Dashboard
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DashboardPage : Page
    {
        public DashboardPage()
        {
            this.InitializeComponent();

            List<ChartControl> chartList = new List<ChartControl>();
            chartList.Add(graph1);
            chartList.Add(graph2);
            chartList.Add(graph3);
            chartList.Add(graph4);

            foreach (ChartControl chart in chartList)
            {
                List<DataItem> data = new List<DataItem>();
                Random r = new Random();
                data.Add(new DataItem { BarColor = Color.FromArgb(255, 92, 140, 150), Name = "January", Amount = r.Next(0, 100) });
                data.Add(new DataItem { BarColor = Color.FromArgb(255, 188, 59, 76), Name = "Feburary", Amount = r.Next(0, 100) });
                data.Add(new DataItem { BarColor = Color.FromArgb(255, 171, 133, 69), Name = "March", Amount = r.Next(0, 100) });
                data.Add(new DataItem { BarColor = Color.FromArgb(255, 145, 79, 112), Name = "April", Amount = r.Next(0, 100) });
                data.Add(new DataItem { BarColor = Color.FromArgb(255, 125, 152, 90), Name = "May", Amount = r.Next(0, 100) });
                data.Add(new DataItem { BarColor = Color.FromArgb(255, 121, 94, 143), Name = "June", Amount = r.Next(0, 100) });
                chart.ChartData = data;
            }
            
            graph1.CharTitle = "Net Income";
            graph2.CharTitle = "Cost";
            graph3.CharTitle = "EBITDA";
            graph4.CharTitle = "Net Income";
        }

        private void Size_Changed(object sender, SizeChangedEventArgs e)
        {

        }
    }
}
