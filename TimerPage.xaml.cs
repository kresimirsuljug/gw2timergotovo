using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using GW2Timer.Models;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace GW2Timer
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 
    
    public sealed partial class TimerPage : Page
    {
        private ObservableCollection<BossItem> CheckedBossItems;
     

        public TimerPage()
        {
            this.InitializeComponent();
            CheckedBossItems = new ObservableCollection<BossItem>();
          
        }
      
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
                CheckedBossItems = BossManager.GetCheckedBosses(App.svibossevi);

            App.svibossevi = BossManager.GetAllBosses();
            /* if (CheckedBossItems == null)
                 ZaDoneTextblock.Visibility = Visibility.Visible;
        */
        }

    /*    private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            BossManager.GetCheckedBosses(CheckedBossItems);
        }*/
    }
}
