using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWPDemo.Pages.Dashboard;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPDemo.Pages.Salesboard
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SalesboardPage : Page
    {
        private List<ProductTableItem> m_goingProductList1;
        private List<ProductTableItem> m_goingProductList2;
        public SalesboardPage()
        {
            this.InitializeComponent();

            // For test
            m_goingProductList1 = new List<ProductTableItem>();
            m_goingProductList1.Add(new ProductTableItem { Color="Red", Product_Name="Barang A", Total = 1, Unit = "Pcs", Price="Rp 50.000", Total2 = "Rp50.000", Job="", Account=""});
            m_goingProductList1.Add(new ProductTableItem { Color = "Green", Product_Name = "Barang B", Total = 1, Unit = "Pcs", Price = "Rp 150.000", Total2 = "Rp50.000", Job = "", Account = "" });
            m_goingProductList1.Add(new ProductTableItem { Color = "Red", Product_Name = "biaya rakit", Total2 = "Rp150.000", Account="Kas" });
            m_goingProductList1.Add(new ProductTableItem { Color = "Red", Product_Name = "biaya rakit", Total2 = "Rp150.000", Account = "Kas" });
            m_goingProductList1.Add(new ProductTableItem { Color = "Red", Product_Name = "biaya rakit", Total2 = "Rp150.000", Account = "Kas" });
            m_goingProductList1.Add(new ProductTableItem { Color = "Red", Product_Name = "biaya rakit", Total2 = "Rp150.000", Account = "Kas" });

            m_goingProductList2 = new List<ProductTableItem>();
            m_goingProductList2.Add(new ProductTableItem { Color = "Red", Product_Name = "Barang A", Total = 1, Unit = "Pcs", Price = "Rp 50.000", Total2 = "Rp50.000", Job = "", Account = "" });

            this.btnCalculate.Click += Btn_Calculate_Clicked;

        }
        private void Btn_Calculate_Clicked(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DashboardPage), "TQWER");
        }
    }
}
