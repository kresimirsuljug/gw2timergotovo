using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using GW2Timer.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Threading.Tasks;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GW2Timer
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

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            if (TimerList.IsSelected)
            {
                MyFrame.Navigate(typeof(TimerPage),App.svibossevi);
                TitleTextBlock.Text = "Timer";
            }
            else if (ListOfBosses.IsSelected)
            {
                MyFrame.Navigate(typeof(ListPage), App.svibossevi);
                TitleTextBlock.Text = "List of Bosses";
            }
            else if (DoneEvents.IsSelected)
            {
                MyFrame.Navigate(typeof(DoneEventsPage), App.svibossevi);
                TitleTextBlock.Text = "Done Events";
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ListOfBosses.IsSelected = true;
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }
    }
}
