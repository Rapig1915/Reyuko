using System.Collections.Generic;
using UWPDemo.Pages.Dashboard;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPDemo.Pages.Sales
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Sales_Production : Page
    {
        private List<SalesProductTableItem> m_goingProductList1;
        private List<SalesProductTableItem> m_goingProductList2;
        public Sales_Production()
        {
            this.InitializeComponent();

            // For test
            m_goingProductList1 = new List<SalesProductTableItem>();
            m_goingProductList1.Add(new SalesProductTableItem { Color="Red", Product_Name="Barang A", Total = 1, Unit = "Pcs", Price="Rp 50.000", Total2 = "Rp50.000", Job="", Account=""});
            m_goingProductList1.Add(new SalesProductTableItem { Color = "Green", Product_Name = "Barang B", Total = 1, Unit = "Pcs", Price = "Rp 150.000", Total2 = "Rp50.000", Job = "", Account = "" });
            m_goingProductList1.Add(new SalesProductTableItem { Color = "Red", Product_Name = "biaya rakit", Total2 = "Rp150.000", Account="Kas" });
            m_goingProductList1.Add(new SalesProductTableItem { Color = "Red", Product_Name = "biaya rakit", Total2 = "Rp150.000", Account = "Kas" });
            m_goingProductList1.Add(new SalesProductTableItem { Color = "Red", Product_Name = "biaya rakit", Total2 = "Rp150.000", Account = "Kas" });
            m_goingProductList1.Add(new SalesProductTableItem { Color = "Red", Product_Name = "biaya rakit", Total2 = "Rp150.000", Account = "Kas" });

            m_goingProductList2 = new List<SalesProductTableItem>();
            m_goingProductList2.Add(new SalesProductTableItem { Color = "Red", Product_Name = "Barang A", Total = 1, Unit = "Pcs", Price = "Rp 50.000", Total2 = "Rp50.000", Job = "", Account = "" });

            this.btnCalculate.Click += Btn_Calculate_Clicked;

        }
        private void Btn_Calculate_Clicked(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DashboardPage), "TQWER");
        }
    }
}
