using System;
using System.Collections.Generic;
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
using System.Collections.ObjectModel;
using System.Threading.Tasks;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace GW2Timer
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ListPage : Page
    {
        Library Library = new Library();
        public ListPage()
        {
            this.InitializeComponent();
         
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
          
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
           
            App.svibossevi= BossManager.GetAllBosses();
            ShattererToggle.IsOn = App.toggle1;
            SvanirToggle.IsOn = App.toggle2;
            ModniirToggle.IsOn = App.toggle3;
            FireToggle.IsOn = App.toggle4;
            KarkaToggle.IsOn = App.toggle5;
            GolemToggle.IsOn = App.toggle6;
            JungleWurmToggle.IsOn = App.toggle7;
            ClawToggle.IsOn = App.toggle8;
            ShadowToggle.IsOn = App.toggle9;
            TequatlToggle.IsOn = App.toggle10;
            TaidhaToggle.IsOn = App.toggle11;
            MegadestroyerToggle.IsOn = App.toggle12;
            EvolvedToggle.IsOn = App.toggle13;
            shatterercheckbox.IsChecked = App.checkbox1;
            svanircheckbox.IsChecked = App.checkbox2;
            modniircheckbox.IsChecked = App.checkbox3;
            firecheckbox.IsChecked = App.checkbox4;
            karkacheckbox.IsChecked = App.checkbox5;
            golemcheckbox.IsChecked = App.checkbox6;
            junglecheckbox.IsChecked = App.checkbox7;
            clawcheckbox.IsChecked = App.checkbox8;
            shadowcheckbox.IsChecked = App.checkbox9;
            tequatlcheckbox.IsChecked = App.checkbox10;
            taidhacheckbox.IsChecked = App.checkbox11;
            megadestroyercheckbox.IsChecked = App.checkbox12;
            evolvedcheckbox.IsChecked = App.checkbox13;
        }
        private void ocistibutton_Click(object sender, RoutedEventArgs e)
        {
            Library.ocisti();
           
        }

        private void Resetbutton_Click(object sender, RoutedEventArgs e)
        {
            App.checkbox1 = false;
            App.checkbox2 = false;
            App.checkbox3 = false;
            App.checkbox4 = false;
            App.checkbox5 = false;
            App.checkbox6 = false;
            App.checkbox7 = false;
            App.checkbox8 = false;
            App.checkbox9 = false;
            App.checkbox10 = false;
            App.checkbox11 = false;
            App.checkbox12 = false;
            App.checkbox13 = false;
            shatterercheckbox.IsChecked = false;
            svanircheckbox.IsChecked = false;
            modniircheckbox.IsChecked = false;
            firecheckbox.IsChecked = false;
            karkacheckbox.IsChecked = false;
            golemcheckbox.IsChecked = false;
            junglecheckbox.IsChecked = false;
            clawcheckbox.IsChecked = false;
            shadowcheckbox.IsChecked = false;
            tequatlcheckbox.IsChecked = false;
            taidhacheckbox.IsChecked = false;
            megadestroyercheckbox.IsChecked = false;
            evolvedcheckbox.IsChecked = false;
        }
        private void provjerabutton_Click(object sender, RoutedEventArgs e)
        {
            Library.provjera();
        }
        private void ShattererToggle_Toggled(object sender, RoutedEventArgs e)
        {
            if(ShattererToggle != null)
            {
                if(ShattererToggle.IsOn == true)
                {
                    for (int i = 0; i < App.svibossevi.Count; i++)
                    {
                        if (App.svibossevi[i].Category == "Shatterer")
                        {
                            App.svibossevi[i].Checked = true;
                        }
                    }
                   App.toggle1 = true;
                }
                else if(ShattererToggle.IsOn == false)
                {
                    for (int i = 0; i < App.svibossevi.Count; i++)
                    {
                        if (App.svibossevi[i].Category == "Shatterer")
                        {
                            App.svibossevi[i].Checked = false;
                        }
                    }
                    App.toggle1 = false;
                }
            }
            
        }
        private void SvanirToggle_Toggled(object sender, RoutedEventArgs e)
        {
            if (SvanirToggle != null)
            {
                if (SvanirToggle.IsOn == true)
                {
                    for (int i = 0; i < App.svibossevi.Count; i++)
                    {
                        if (App.svibossevi[i].Category == "Svanir Shaman")
                        {
                            App.svibossevi[i].Checked = true;
                        }
                    }
                    App.toggle2 = true;
                }
                else if (SvanirToggle.IsOn == false)
                {
                    for (int i = 0; i < App.svibossevi.Count; i++)
                    {
                        if (App.svibossevi[i].Category == "Svanir Shaman")
                        {
                            App.svibossevi[i].Checked = false;
                        }
                    }
                    App.toggle2 = false;
                }
            }

        }
        private void ModniirToggle_Toggled(object sender, RoutedEventArgs e)
        {
            if (ModniirToggle != null)
            {
                if (ModniirToggle.IsOn == true)
                {
                    for (int i = 0; i < App.svibossevi.Count; i++)
                    {
                        if (App.svibossevi[i].Category == "Modniir Ulgoth")
                        {
                            App.svibossevi[i].Checked = true;
                        }
                    }
                    App.toggle3 = true;
                }
                else if (ModniirToggle.IsOn == false)
                {
                    for (int i = 0; i < App.svibossevi.Count; i++)
                    {
                        if (App.svibossevi[i].Category == "Modniir Ulgoth")
                        {
                            App.svibossevi[i].Checked = false;
                        }
                    }
                    App.toggle3 = false;
                }
            }
        }
        private void FireToggle_Toggled(object sender, RoutedEventArgs e)
        {
            if (FireToggle != null)
            {
                if (FireToggle.IsOn == true)
                {
                    for (int i = 0; i < App.svibossevi.Count; i++)
                    {
                        if (App.svibossevi[i].Category == "Fire Elemental")
                        {
                            App.svibossevi[i].Checked = true;
                        }
                    }
                    App.toggle4 = true;
                }
                else if (FireToggle.IsOn == false)
                {
                    for (int i = 0; i < App.svibossevi.Count; i++)
                    {
                        if (App.svibossevi[i].Category == "Fire Elemental")
                        {
                            App.svibossevi[i].Checked = false;
                        }
                    }
                    App.toggle4 = false;
                }
            }
        }
        private void KarkaToggle_Toggled(object sender, RoutedEventArgs e)
        {
            if (KarkaToggle != null)
            {
                if (KarkaToggle.IsOn == true)
                {
                    for (int i = 0; i < App.svibossevi.Count; i++)
                    {
                        if (App.svibossevi[i].Category == "Karka Queen")
                        {
                            App.svibossevi[i].Checked = true;
                        }
                    }
                    App.toggle5 = true;
                }
                else if(KarkaToggle.IsOn == false)
                {
                    for (int i = 0; i < App.svibossevi.Count; i++)
                    {
                        if (App.svibossevi[i].Category == "Karka Queen")
                        {
                            App.svibossevi[i].Checked = false;
                        }
                    }
                    App.toggle5 = false;
                }
            }
        }
        private void GolemToggle_Toggled(object sender, RoutedEventArgs e)
        {
            if (GolemToggle != null)
            {
                if (GolemToggle.IsOn == true)
                {
                    for (int i = 0; i < App.svibossevi.Count; i++)
                    {
                        if (App.svibossevi[i].Category == "Golem Mark II")
                        {
                            App.svibossevi[i].Checked = true;
                        }
                    }
                    App.toggle6 = true;
                }
                else if (GolemToggle.IsOn == false)
                {
                    for (int i = 0; i < App.svibossevi.Count; i++)
                    {
                        if (App.svibossevi[i].Category == "Golem Mark II")
                        {
                            App.svibossevi[i].Checked = false;
                        }
                    }
                    App.toggle6 = false;
                }
            }
        }
        private void JungleWurmToggle_Toggled(object sender, RoutedEventArgs e)
        {
            if (JungleWurmToggle != null)
            {
                if (JungleWurmToggle.IsOn == true)
                {
                    for (int i = 0; i < App.svibossevi.Count; i++)
                    {
                        if (App.svibossevi[i].Category == "Jungle Wurm")
                        {
                            App.svibossevi[i].Checked = true;
                        }
                    }
                    App.toggle7 = true;
                }
                else if (JungleWurmToggle.IsOn == false)
                {
                    for (int i = 0; i < App.svibossevi.Count; i++)
                    {
                        if (App.svibossevi[i].Category == "Jungle Wurm")
                        {
                            App.svibossevi[i].Checked = false;
                        }
                    }
                    App.toggle7 = false;
                }
            }
        }
        private void ClawToggle_Toggled(object sender, RoutedEventArgs e)
        {
            if (ClawToggle != null)
            {
                if (ClawToggle.IsOn == true)
                {
                    for (int i = 0; i < App.svibossevi.Count; i++)
                    {
                        if (App.svibossevi[i].Category == "Claw of Jormag")
                        {
                            App.svibossevi[i].Checked = true;
                        }
                    }
                    App.toggle8 = true;
                }
                else if (ClawToggle.IsOn == false)
                {
                    for (int i = 0; i < App.svibossevi.Count; i++)
                    {
                        if (App.svibossevi[i].Category == "Claw of Jormag")
                        {
                            App.svibossevi[i].Checked = false;
                        }
                    }
                    App.toggle8 = false;
                }
            }
        }
        private void ShadowToggle_Toggled(object sender, RoutedEventArgs e)
        {
            if (ShadowToggle != null)
            {
                if (ShadowToggle.IsOn == true)
                {
                    for (int i = 0; i < App.svibossevi.Count; i++)
                    {
                        if (App.svibossevi[i].Category == "Shadow Behemoth")
                        {
                            App.svibossevi[i].Checked = true;
                        }
                    }
                    App.toggle9 = true;
                }
                else if (ShadowToggle.IsOn == false)
                {
                    for (int i = 0; i < App.svibossevi.Count; i++)
                    {
                        if (App.svibossevi[i].Category == "Shadow Behemoth")
                        {
                            App.svibossevi[i].Checked = false;
                        }
                    }
                    App.toggle9 = false;
                }
            }
        }
        private void TequatlToggle_Toggled(object sender, RoutedEventArgs e)
        {
            if (TequatlToggle != null)
            {
                if (TequatlToggle.IsOn == true)
                {
                    for (int i = 0; i < App.svibossevi.Count; i++)
                    {
                        if (App.svibossevi[i].Category == "Tequatl the Sunless")
                        {
                            App.svibossevi[i].Checked = true;
                        }
                    }
                    App.toggle10 = true;
                }
                else if (TequatlToggle.IsOn == false)
                {
                    for (int i = 0; i < App.svibossevi.Count; i++)
                    {
                        if (App.svibossevi[i].Category == "Tequatl the Sunless")
                        {
                            App.svibossevi[i].Checked = false;
                        }
                    }
                    App.toggle10 = false;
                }
            }
        }
        private void TaidhaToggle_Toggled(object sender, RoutedEventArgs e)
        {
            if (TaidhaToggle != null)
            {
                if (TaidhaToggle.IsOn == true)
                {
                    for (int i = 0; i < App.svibossevi.Count; i++)
                    {
                        if (App.svibossevi[i].Category == "Taidha Covington")
                        {
                            App.svibossevi[i].Checked = true;
                        }
                    }
                    App.toggle11 = true;
                }
                else if (TaidhaToggle.IsOn == false)
                {
                    for (int i = 0; i < App.svibossevi.Count; i++)
                    {
                        if (App.svibossevi[i].Category == "Taidha Covington")
                        {
                            App.svibossevi[i].Checked = false;
                        }
                    }
                    App.toggle11 = false;
                }
            }
        }
        private void MegadestroyerToggle_Toggled(object sender, RoutedEventArgs e)
        {
            if (MegadestroyerToggle != null)
            {
                if (MegadestroyerToggle.IsOn == true)
                {
                    for (int i = 0; i < App.svibossevi.Count; i++)
                    {
                        if (App.svibossevi[i].Category == "Megadestroyer")
                        {
                            App.svibossevi[i].Checked = true;
                        }
                    }
                    App.toggle12 = true;
                }
                else if (MegadestroyerToggle.IsOn == false)
                {
                    for (int i = 0; i < App.svibossevi.Count; i++)
                    {
                        if (App.svibossevi[i].Category == "Megadestroyer")
                        {
                            App.svibossevi[i].Checked = false;
                        }
                    }
                    App.toggle12 = false;
                }
            }
        }
        private void EvolvedToggle_Toggled(object sender, RoutedEventArgs e)
        {
            if (EvolvedToggle != null)
            {
                if (EvolvedToggle.IsOn == true)
                {
                    for (int i = 0; i < App.svibossevi.Count; i++)
                    {
                        if (App.svibossevi[i].Category == "Evolved Jungle Wurm")
                        {
                            App.svibossevi[i].Checked = true;
                        }
                    }
                    App.toggle13 = true;
                }
                else if (EvolvedToggle.IsOn == false)
                {
                    for (int i = 0; i < App.svibossevi.Count; i++)
                    {
                        if (App.svibossevi[i].Category == "Evolved Jungle Wurm")
                        {
                            App.svibossevi[i].Checked = false;
                        }
                    }
                    App.toggle13 = false;
                }
            }
        }
        private void shatterercheckbox_Checked(object sender, RoutedEventArgs e)
        {
            for(int i= 0;i< App.svibossevi.Count;i++)
            {
                if(App.svibossevi[i].Category == "Shatterer")
                App.svibossevi[i].Done = true;         
            }
            App.checkbox1 = true;
        }
        private void svanircheckbox_Checked(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < App.svibossevi.Count; i++)
            {
                if (App.svibossevi[i].Category == "Svanir Shaman")
                    App.svibossevi[i].Done = true;
            }
            App.checkbox2 = true;
        }
        private void modniircheckbox_Checked(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < App.svibossevi.Count; i++)
            {
                if (App.svibossevi[i].Category == "Modniir Ulgoth")
                    App.svibossevi[i].Done = true;
            }
            App.checkbox3 = true;
        }
        private void firecheckbox_Checked(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < App.svibossevi.Count; i++)
            {
                if (App.svibossevi[i].Category == "Fire Elemental")
                    App.svibossevi[i].Done = true;
            }
            App.checkbox4 = true;
        }
        private void karkacheckbox_Checked(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < App.svibossevi.Count; i++)
            {
                if (App.svibossevi[i].Category == "Karka Queen")
                    App.svibossevi[i].Done = true;
            }
            App.checkbox5 = true;
        }
        private void golemcheckbox_Checked(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < App.svibossevi.Count; i++)
            {
                if (App.svibossevi[i].Category == "Golem Mark II")
                    App.svibossevi[i].Done = true;
            }
            App.checkbox6 = true;
        }
        private void junglecheckbox_Checked(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < App.svibossevi.Count; i++)
            {
                if (App.svibossevi[i].Category == "Jungle Wurm")
                    App.svibossevi[i].Done = true;
            }
            App.checkbox7 = true;
        }
        private void clawcheckbox_Checked(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < App.svibossevi.Count; i++)
            {
                if (App.svibossevi[i].Category == "Claw of Jormag")
                    App.svibossevi[i].Done = true;
            }
            App.checkbox8 = true;
        }
        private void shadowcheckbox_Checked(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < App.svibossevi.Count; i++)
            {
                if (App.svibossevi[i].Category == "Shadow Behemoth")
                    App.svibossevi[i].Done = true;
            }
            App.checkbox9 = true;
        }
        private void tequatlcheckbox_Checked(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < App.svibossevi.Count; i++)
            {
                if (App.svibossevi[i].Category == "Tequatl the Sunless")
                    App.svibossevi[i].Done = true;
            }
            App.checkbox10 = true;
        }
        private void taidhacheckbox_Checked(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < App.svibossevi.Count; i++)
            {
                if (App.svibossevi[i].Category == "Taidha Covington")
                    App.svibossevi[i].Done = true;
            }
            App.checkbox11 = true;
        }
        private void megadestroyercheckbox_Checked(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < App.svibossevi.Count; i++)
            {
                if (App.svibossevi[i].Category == "Megadestroyer")
                    App.svibossevi[i].Done = true;
            }
            App.checkbox12 = true;
        }
        private void evolvedcheckbox_Checked(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < App.svibossevi.Count; i++)
            {
                if (App.svibossevi[i].Category == "Evolved Jungle Wurm")
                    App.svibossevi[i].Done = true;
            }
            App.checkbox13 = true;
        }

    }
}
