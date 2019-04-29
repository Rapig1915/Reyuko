using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWPDemo.Data;
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

namespace UWPDemo.Pages.Sales.Document
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Sales_Document : Page
    {
        private ObservableCollection<Sales_DocumentItem> m_TableData;
        private List<HeaderItem> m_HeaderData;

        public Sales_Document()
        {
            this.InitializeComponent();
            header.Height = 40;
            header.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 21, 107, 179));


            List<HeaderItem> headerList = new List<HeaderItem>();
            headerList.Add(new HeaderItem { Name = "Transaction No.", Width = 100 });
            headerList.Add(new HeaderItem { Name = "Date", Width = 100 });
            headerList.Add(new HeaderItem { Name = "Referal No.", Width = 100 });
            headerList.Add(new HeaderItem { Name = "Customer/ID", Width = 150 });
            headerList.Add(new HeaderItem { Name = "Currency", Width = 150 });
            headerList.Add(new HeaderItem { Name = "Total", Width = 100 });
            headerList.Add(new HeaderItem { Name = "Annual", Width = 100 });
            headerList.Add(new HeaderItem { Name = "Complete", Width = 100 });
            m_HeaderData = headerList;
            m_TableData = new ObservableCollection<Sales_DocumentItem>();
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
                txt.FontSize = 15;
                //txt.PointerPressed += Header_Item_Clicked;

                Grid.SetColumn(border, index); index++;
                border.Child = txt;
                header.Children.Add(border);
            }


            foreach (Sales_DocumentItem item in m_TableData)
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
