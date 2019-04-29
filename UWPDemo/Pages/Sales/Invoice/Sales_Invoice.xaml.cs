using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using UWPDemo.Data;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPDemo.Pages.Sales.Invoice
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 

    public sealed partial class Sales_Invoice : Page
    {
        

        private ObservableCollection<Sales_InvoiceItem> m_TableData;
        private List<HeaderItem> m_HeaderData;
        private int m_headerFontsize;


        public Sales_Invoice()
        {
            this.InitializeComponent();
            header.Height = 40;
            header.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 21, 107, 179));
            m_headerFontsize = 15;

            List<HeaderItem> headerList = new List<HeaderItem>();
            headerList.Add(new HeaderItem { Name = "Invoice No.", Width = 100 });
            headerList.Add(new HeaderItem { Name = "Date", Width = 100 });
            headerList.Add(new HeaderItem { Name = "So No", Width = 100 });
            headerList.Add(new HeaderItem { Name = "DO No", Width = 150 });
            headerList.Add(new HeaderItem { Name = "Customer / ID", Width = 150 });
            headerList.Add(new HeaderItem { Name = "Currency", Width = 100 });
            headerList.Add(new HeaderItem { Name = "Total", Width = 100 });
            headerList.Add(new HeaderItem { Name = "Status", Width = 100 });
            headerList.Add(new HeaderItem { Name = "Outstanding", Width = 100 });
            headerList.Add(new HeaderItem { Name = "Repeat", Width = 100 });
            headerList.Add(new HeaderItem { Name = "Aging Receivable", Width = 100 });
            m_HeaderData = headerList;
            m_TableData = new ObservableCollection<Sales_InvoiceItem>(); 
            Refresh();
        }
        public void Refresh()
        {
            header.ColumnDefinitions.Clear();
            int index = 0;
            foreach (HeaderItem item in m_HeaderData)
            {
                ColumnDefinition def = new ColumnDefinition();
                def.Width = new GridLength(item.Width);
                header.ColumnDefinitions.Add(def);

                Border border = new Border();
                border.BorderThickness = new Thickness(0, 0, 1, 0);
                border.BorderBrush = new SolidColorBrush(Colors.White);

                TextBlock txt = new TextBlock();
                txt.Foreground = new SolidColorBrush(Colors.White);
                txt.Margin = new Thickness(10, 0, 0, 0);
                txt.Tag = index;

                txt.Text = item.Name;
                txt.HorizontalAlignment = HorizontalAlignment.Stretch;
                txt.VerticalAlignment = VerticalAlignment.Center;
                txt.FontSize = m_headerFontsize;
                //txt.PointerPressed += Header_Item_Clicked;

                Grid.SetColumn(border, index); index++;
                border.Child = txt;
                header.Children.Add(border);
            }


            foreach (Sales_InvoiceItem item in m_TableData)
            {

                var prop = item.GetType().GetProperties();

                Grid grid = new Grid();
                foreach (HeaderItem hItem in m_HeaderData)
                {
                    ColumnDefinition def = new ColumnDefinition();
                    def.Width = new GridLength(hItem.Width);
                    grid.ColumnDefinitions.Add(def);
                }

                index = 0;
                foreach (var property in prop)
                {
                    TextBlock txt = new TextBlock();
                    txt.Margin = new Thickness(10, 0, 0, 0);
                    txt.Text = item.GetType().GetProperty(property.Name).GetValue(item).ToString();
                    txt.Foreground = new SolidColorBrush(Colors.Black);
                    txt.Tag = index;
                    Grid.SetColumn(txt, index); index++;
                    grid.Children.Add(txt);
                }

                list.Items.Add(grid);

            }

        }
    }
}
