using System.Linq;
using UWPDemo.Data;
using UWPDemo.Models;
using UWPDemo.Pages.Dashboard;
using UWPDemo.Pages.Sales;
using UWPDemo.Pages.Sales.Invoice;
using UWPDemo.Pages.Sales.Return;
using UWPDemo.Pages.Sales.Delivery_Order;
using UWPDemo.Pages.Sales.Document;
using UWPDemo.Pages.TransactionCode;
using UWPDemo.Pages.Document;
using UWPDemo.Pages.Calendar;
using UWPDemo.Pages.Pos;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPDemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private string m_strMenuTitle;
        public MainPage()
        {
            this.InitializeComponent();
            m_strMenuTitle = "";
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            lvNavigationMenuMain.ItemsSource = Menu.GetMenu();
            ContentFrame.Navigate(typeof(DashboardPage));
        }

        private void LvNavigationMenuMain_ItemClick(object sender, ItemClickEventArgs e)
        {
            var model = (MenuItem)e.ClickedItem;
            if (model != null)
            {
                if (model.Title == "Menu")
                {
                    MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
                }
                else
                {
                    string menuTitle = model.Title;
                    m_strMenuTitle = menuTitle;
                    switch (menuTitle)
                    {
                        case "Dashboard":
                            ContentFrame.Navigate(typeof(DashboardPage));
                            break;
                        case "Sales":
                            break;
                        case "Purchasing":
                            break;
                        case "Product":
                            break;
                        case "Inventory":
                            break;
                        case "Payment":
                            break;
                        case "Accounting":
                            break;
                        case "Contact":
                            break;
                        case "Reporting":   //Empty
                            break;
                        case "Document":
                            break;
                        case "Calander":
                            ContentFrame.Navigate(typeof(Calendar));
                            break;
                        case "POS":
                            ContentFrame.Navigate(typeof(POS));
                            break;
                        case "Services":    //Empty
                            break;
                        case "Settings":
                            ContentFrame.Navigate(typeof(Transaction_Code));
                            break;
                    }
                   
                    //tbDescription.Text = $"You clicked MainMenu1 : {model.Title}";
                }

                SubMenuSplitView.IsPaneOpen = model.SubMenus.Any();
            }
        }

        private void LvNavigationMenuSub_ItemClick(object sender, ItemClickEventArgs e)
        {
            var model = (MenuItem)e.ClickedItem;
            if (model == null)
                return;
            if(m_strMenuTitle == "Sales")
            {
                string menuTitle = model.Title;
                if (menuTitle == "Production")
                    ContentFrame.Navigate(typeof(Sales_Production));
                else if(menuTitle == "Invoice")
                    ContentFrame.Navigate(typeof(Sales_Invoice));
                else if (menuTitle == "Document")
                    ContentFrame.Navigate(typeof(Sales_Document));
                else if (menuTitle == "Delivery Order")
                    ContentFrame.Navigate(typeof(Sales_DeliveryOrder));
                else if (menuTitle == "Return")
                    ContentFrame.Navigate(typeof(Sales_Return));
            }
            else if (m_strMenuTitle == "Document")
            {
                string menuTitle = model.Title;
                if (menuTitle == "Document")
                    ContentFrame.Navigate(typeof(Sales_Production));
                else if (menuTitle == "Document Type")
                    ContentFrame.Navigate(typeof(Sales_Invoice));
                else if (menuTitle == "Document")
                    ContentFrame.Navigate(typeof(Sales_Document));
                else if (menuTitle == "Interal Notes")
                    ContentFrame.Navigate(typeof(Sales_DeliveryOrder));
            }
            SubMenuSplitView.IsPaneOpen = model.SubMenus.Any();
        }
    }
}
