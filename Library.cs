using System;
using System.Text;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;
using System.Linq;
using Windows.UI.Xaml.Controls;
using GW2Timer;
using System.Collections.ObjectModel;
using GW2Timer.Models;
using NotificationsExtensions.Toasts;
using Windows.UI.Xaml;
using NotificationsExtensions;
using Microsoft.QueryStringDotNET;
using System.Collections.Generic;

public class Library
{
    private ObservableCollection<BossItem> CheckedBosses;  
    private Random random = new Random((int)DateTime.Now.Ticks);
    public string idem = "Idem";
    public ToastNotifier notifier;
    TimeSpan offset = new TimeSpan(72000000000);
    public List<ToastItem> items = new List<ToastItem>();
    public class ToastItem
    {
        public string Id { get; set; }
        public string Category { get; set; }
    }
    
    public static ToastContent GenerateToastContent(string imeboss, DateTime when)
    {
        string content = " pocinje za par minuta";

        ToastBindingGeneric binding = new ToastBindingGeneric();
        binding.Children.Add(new AdaptiveText()
        {
            Text = imeboss + content + when.ToString()

        });
        return new ToastContent()
        {
            Visual = new ToastVisual()
            {
                BindingGeneric = binding
            },
            ActivationType = ToastActivationType.Background,
        };
    }

    public void provjera()
    {
        
        CheckedBosses = App.svibossevi;
        BossManager.GetCheckedBosses(CheckedBosses);
        for (int i = 0; i < App.svibossevi.Count; i++)
        {
            DateTime when = new DateTime(
                DateTime.Now.Year,
                DateTime.Now.Month,
                DateTime.Now.Day,
                CheckedBosses[i].TimeH,
                CheckedBosses[i].TimeM,
                CheckedBosses[i].TimeS                
                );
            if (when > DateTime.Now)
            {
                string imebossa = CheckedBosses[i].Category;
                XmlDocument content = GenerateToastContent(imebossa, when).GetXml();
                ScheduledToastNotification toast = new ScheduledToastNotification(content, when);
                toast.Id = random.Next(1, 1000000).ToString();
                ToastNotificationManager.CreateToastNotifier().AddToSchedule(toast);
                items.Add(new ToastItem { Id = toast.Id, Category = CheckedBosses[i].Category });
                //   notifier.AddToSchedule(toast);
            }
            else if (when < DateTime.Now)
            {
                when = when.AddDays(1);
                string imebossa = CheckedBosses[i].Category;
                XmlDocument content = GenerateToastContent(imebossa, when).GetXml();
                ScheduledToastNotification toast = new ScheduledToastNotification(content, when);
                toast.Id = random.Next(1, 1000000).ToString();
                ToastNotificationManager.CreateToastNotifier().AddToSchedule(toast);
                items.Add(new ToastItem { Id = toast.Id, Category = CheckedBosses[i].Category });
                // notifier.AddToSchedule(toast);
            }
        }
        //if (when.Hour == DateTime.Now.Hour) //&& when.Minute == DateTime.Now.Minute
       
    }
    public void ocisti()
    {
        var notifier = ToastNotificationManager.CreateToastNotifier();
        IReadOnlyList<ScheduledToastNotification> scheduled = notifier.GetScheduledToastNotifications();
        for (int i = 0; i < scheduled.Count;  i++ )
        {          
                notifier.RemoveFromSchedule(scheduled[i]);            
        }
        scheduled = notifier.GetScheduledToastNotifications();

    }
}
