using GW2Timer.Models;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace GW2Timer
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>

   
    public sealed partial class DoneEventsPage : Page
    {
        private ObservableCollection<BossItem> bossDoneItems;
        public DoneEventsPage()
        {
            this.InitializeComponent();
            bossDoneItems = new ObservableCollection<BossItem>();
        }
       protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            bossDoneItems = App.svibossevi;
            BossManager.GetDoneBosses(bossDoneItems);
    
            
           
            for (int i = 0; i < bossDoneItems.Count; i++)
            {
                if (bossDoneItems[i].Category == "Shatterer")
                {
                    ShattererStackpannel.Visibility = Visibility.Visible;
                }
                if (bossDoneItems[i].Category == "Svanir Shaman")
                {
                    SvanirStackpannel.Visibility = Visibility.Visible;
                }
                if (bossDoneItems[i].Category == "Modniir Ulgoth")
                {
                    ModniirStackpannel.Visibility = Visibility.Visible;
                }
                if (bossDoneItems[i].Category == "Fire Elemental")
                {
                    FireStackpannel.Visibility = Visibility.Visible;
                }
                if (bossDoneItems[i].Category == "Karka Queen")
                {
                    KarkaStackpannel.Visibility = Visibility.Visible;
                }
                if (bossDoneItems[i].Category == "Golem Mark II")
                {
                    GolemStackpannel.Visibility = Visibility.Visible;
                }
                if (bossDoneItems[i].Category == "Jungle Wurm")
                {
                    JungleStackpannel.Visibility = Visibility.Visible;
                }
                if (bossDoneItems[i].Category == "Claw of Jormag")
                {
                    ClawStackpannel.Visibility = Visibility.Visible;
                }
                if (bossDoneItems[i].Category == "Shadow Behemoth")
                {
                    ShadowStackpannel.Visibility = Visibility.Visible;
                }
                if (bossDoneItems[i].Category == "Tequatl the Sunless")
                {
                    TequatlStackpannel.Visibility = Visibility.Visible;
                }
                if (bossDoneItems[i].Category == "Taidha Covington")
                {
                    TaidhaStackpannel.Visibility = Visibility.Visible;
                }
                if (bossDoneItems[i].Category == "Megadestroyer")
                {
                    MegadestroyerStackpannel.Visibility = Visibility.Visible;
                }
                if (bossDoneItems[i].Category == "Evolved Jungle Wurm")
                {
                    EvolvedStackpannel.Visibility = Visibility.Visible;
                }

            }
        }

    }
}
