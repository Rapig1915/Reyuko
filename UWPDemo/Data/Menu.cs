using System.Collections.ObjectModel;
using UWPDemo.Models;

namespace UWPDemo.Data
{
    public class Menu
    {
        

        public static ObservableCollection<MenuItem> GetMenu()
        {
            var menuLst = new ObservableCollection<MenuItem>();

            menuLst.Add(new MenuItem { Title = "Menu", IconPath = "ms-appx:///Assets/Icons/Menu_drawer.png" });
            menuLst.Add(new MenuItem { Title = "Dashboard", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
            menuLst.Add(new MenuItem { Title = "Sales", IconPath = "ms-appx:///Assets/Icons/sales_drawer.png", SubMenus = GetSubMenu("Sales") });
            menuLst.Add(new MenuItem { Title = "Purchasing", IconPath = "ms-appx:///Assets/Icons/purchasing_drawer.png" });
            menuLst.Add(new MenuItem { Title = "Product", IconPath = "ms-appx:///Assets/Icons/product_drawer.png" });
            menuLst.Add(new MenuItem { Title = "Inventory", IconPath = "ms-appx:///Assets/Icons/inventory_drawer.png" });
            menuLst.Add(new MenuItem { Title = "Payment", IconPath = "ms-appx:///Assets/Icons/payment_drawer.png" });
            menuLst.Add(new MenuItem { Title = "Accounting", IconPath = "ms-appx:///Assets/Icons/accounting_drawer.png" });
            menuLst.Add(new MenuItem { Title = "Contact", IconPath = "ms-appx:///Assets/Icons/contact_drawer.png" });
            menuLst.Add(new MenuItem { Title = "Reporting", IconPath = "ms-appx:///Assets/Icons/reporting_drawer.png" });
            menuLst.Add(new MenuItem { Title = "Document", IconPath = "ms-appx:///Assets/Icons/document_drawer.png", SubMenus = GetSubMenu("Document") });
            menuLst.Add(new MenuItem { Title = "Calander", IconPath = "ms-appx:///Assets/Icons/calendar_drawer.png" });
            menuLst.Add(new MenuItem { Title = "POS", IconPath = "ms-appx:///Assets/Icons/pos_drawer.png" });
            menuLst.Add(new MenuItem { Title = "Services", IconPath = "ms-appx:///Assets/Icons/services_drawer.png" });
            menuLst.Add(new MenuItem { Title = "Settings", IconPath = "ms-appx:///Assets/Icons/setting_drawer.png" });

            return menuLst;
        }

        private static ObservableCollection<MenuItem> GetSubMenu(string strMenu)
        {
            var menuLst = new ObservableCollection<MenuItem>();
            switch(strMenu)
            {
                case "Sales":
                    menuLst.Add(new MenuItem { Title = "Production", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    menuLst.Add(new MenuItem { Title = "Invoice", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    menuLst.Add(new MenuItem { Title = "Document", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    menuLst.Add(new MenuItem { Title = "Delivery Order", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    menuLst.Add(new MenuItem { Title = "Return", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    break;
                case "Purchasing":
                    menuLst.Add(new MenuItem { Title = "Production", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    menuLst.Add(new MenuItem { Title = "Invoice", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    menuLst.Add(new MenuItem { Title = "Document", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    menuLst.Add(new MenuItem { Title = "Delivery Order", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    menuLst.Add(new MenuItem { Title = "Return", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    break;
                case "Product":
                    menuLst.Add(new MenuItem { Title = "Production", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    menuLst.Add(new MenuItem { Title = "Invoice", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    menuLst.Add(new MenuItem { Title = "Document", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    menuLst.Add(new MenuItem { Title = "Delivery Order", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    menuLst.Add(new MenuItem { Title = "Return", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    break;

                case "Inventory":
                    menuLst.Add(new MenuItem { Title = "Production", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    menuLst.Add(new MenuItem { Title = "Invoice", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    menuLst.Add(new MenuItem { Title = "Document", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    menuLst.Add(new MenuItem { Title = "Delivery Order", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    menuLst.Add(new MenuItem { Title = "Return", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    break;

                case "Payment":
                    menuLst.Add(new MenuItem { Title = "Production", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    menuLst.Add(new MenuItem { Title = "Invoice", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    menuLst.Add(new MenuItem { Title = "Document", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    menuLst.Add(new MenuItem { Title = "Delivery Order", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    menuLst.Add(new MenuItem { Title = "Return", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    break;

                case "Accounting":
                    menuLst.Add(new MenuItem { Title = "Production", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    menuLst.Add(new MenuItem { Title = "Invoice", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    menuLst.Add(new MenuItem { Title = "Document", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    menuLst.Add(new MenuItem { Title = "Delivery Order", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    menuLst.Add(new MenuItem { Title = "Return", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    break;

                case "Contact":
                    menuLst.Add(new MenuItem { Title = "Production", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    menuLst.Add(new MenuItem { Title = "Invoice", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    menuLst.Add(new MenuItem { Title = "Document", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    menuLst.Add(new MenuItem { Title = "Delivery Order", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    menuLst.Add(new MenuItem { Title = "Return", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    break;

                case "Reporting":
                    menuLst.Add(new MenuItem { Title = "Production", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    menuLst.Add(new MenuItem { Title = "Invoice", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    menuLst.Add(new MenuItem { Title = "Document", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    menuLst.Add(new MenuItem { Title = "Delivery Order", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    menuLst.Add(new MenuItem { Title = "Return", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    break;
                case "Document":
                    menuLst.Add(new MenuItem { Title = "Document", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    menuLst.Add(new MenuItem { Title = "Document Type", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    menuLst.Add(new MenuItem { Title = "Note Type", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    menuLst.Add(new MenuItem { Title = "Interal Notes", IconPath = "ms-appx:///Assets/Icons/dashboard_drawer.png" });
                    
                    break;
                    
            }

            return menuLst;
        }
    }
}
