using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWPDemo.Data;
using UWPDemo.Models;
using UWPDemo.Pages.Dashboard;
using UWPDemo.Pages.Salesboard;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPDemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            lvNavigationMenuMain.ItemsSource = Menu.GetMenu();
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
                    if (menuTitle == "Dashboard")
                        ContentFrame.Navigate(typeof(DashboardPage));
                    else if(menuTitle == "Sales")
                        ContentFrame.Navigate(typeof(SalesboardPage));
                   
                    else
                        ContentFrame.Navigate(typeof(SalesboardPage));
                    //tbDescription.Text = $"You clicked MainMenu1 : {model.Title}";
                }

                SubMenuSplitView.IsPaneOpen = model.SubMenus.Any();
            }
        }

        private void LvNavigationMenuSub_ItemClick(object sender, ItemClickEventArgs e)
        {
            var model = (MenuItem)e.ClickedItem;
            if (model != null)
            {
                string menuTitle = model.Title;
                if (menuTitle == "Sales Proposal")
                    ContentFrame.Navigate(typeof(SalesboardPage));
            }
            SubMenuSplitView.IsPaneOpen = model.SubMenus.Any();
        }
    }
}
