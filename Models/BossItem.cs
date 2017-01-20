using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace GW2Timer.Models
{
        public class BossItem
        {
            public int id { get; set; }
            public string Category { get; set; }
            public int TimeH { get; set; }
            public int TimeM { get; set; }
            public int TimeS { get; set; }
        public bool Checked { get; set; }
            public bool Done { get; set; }
        }
        public class BossManager
        {
            

        public static ObservableCollection<BossItem> GetCheckedBosses(ObservableCollection<BossItem> bossCheckedItems)
        {
            var allBosses = bossCheckedItems;
                var filteredBossItems = allBosses.Where(p => (p.Checked == true && p.Done == false) ).ToList();
                bossCheckedItems.Clear();
                filteredBossItems.ForEach(p => bossCheckedItems.Add(p));
                return bossCheckedItems;
        }
        public static ObservableCollection<BossItem> GetDoneBosses(ObservableCollection<BossItem> bossDoneItems)
        {
                var allBosses = bossDoneItems;
                var filteredBossItems = allBosses.Where(p => p.Done == true).ToList();
                bossDoneItems.Clear();
                filteredBossItems.ForEach(p => bossDoneItems.Add(p));
                return bossDoneItems;
        }
        public static ObservableCollection<BossItem> GetAllBosses()
        {
            ObservableCollection<BossItem> SviBossevi = new ObservableCollection<BossItem>();
            var allBosses = getBossItems();
            var filteredBossItems = allBosses.Where(p=> (p.id == 1)).ToList();
            filteredBossItems.ForEach(p => SviBossevi.Add(p));
            return SviBossevi;

        }

        public static List<BossItem> getBossItems()
        {
            var items = new List<BossItem>();
            items.Add(new BossItem() { id = 1, Category = "Shatterer", TimeH = 00 , TimeM = 00 , TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Svanir Shaman", TimeH = 00, TimeM = 15, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Modniir Ulgoth", TimeH = 00, TimeM = 30, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Fire Elemental", TimeH = 00, TimeM = 45, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Karka Queen", TimeH = 00, TimeM = 55, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Golem Mark II", TimeH = 01, TimeM = 00, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Jungle Wurm", TimeH = 01, TimeM = 15, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Claw of Jormag", TimeH = 01, TimeM = 30, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Shadow Behemoth", TimeH = 01, TimeM = 45, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Tequatl the Sunless", TimeH = 01, TimeM = 55, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Svanir Shaman", TimeH = 02, TimeM = 15, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Fire Elemental", TimeH = 02, TimeM = 45, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Taidha Covington", TimeH = 02, TimeM = 00, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Megadestroyer", TimeH = 02, TimeM = 30, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Evolved Jungle Wurm", TimeH = 02, TimeM = 55, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Shatterer", TimeH = 03, TimeM = 00, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Jungle Wurm", TimeH = 03, TimeM = 15, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Modniir Ulgoth", TimeH = 03, TimeM = 30, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Shadow Behemoth", TimeH = 03, TimeM = 45, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Karka Queen", TimeH = 03, TimeM = 55, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Golem Mark II", TimeH = 04, TimeM = 00, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Svanir Shaman", TimeH = 04, TimeM = 15, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Claw of Jormag", TimeH = 04, TimeM = 30, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Fire Elemental", TimeH = 04, TimeM = 45, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Tequatl the Sunless", TimeH = 04, TimeM = 55, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Taidha Covington", TimeH = 05, TimeM = 00, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Jungle Wurm", TimeH = 05, TimeM = 15, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Megadestroyer", TimeH = 05, TimeM = 30, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Shadow Behemoth", TimeH = 05, TimeM = 45, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Evolved Jungle Wurm", TimeH = 05, TimeM = 55, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Shatterer", TimeH = 06, TimeM = 00, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Svanir Shaman", TimeH = 06, TimeM = 15, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Modniir Ulgoth", TimeH = 06, TimeM = 30, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Fire Elemental", TimeH = 06, TimeM = 45, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Golem Mark II", TimeH = 07, TimeM = 00, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Jungle Wurm", TimeH = 07, TimeM = 15, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Claw of Jormag", TimeH = 07, TimeM = 30, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Shadow Behemoth", TimeH = 07, TimeM = 45, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Karka Queen", TimeH = 07, TimeM = 55, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Taidha Covington", TimeH = 08, TimeM = 00, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Svanir Shaman", TimeH = 08, TimeM = 15, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Megadestroyer", TimeH = 08, TimeM = 30, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Fire Elemental", TimeH = 08, TimeM = 45, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Tequatl the Sunless", TimeH = 08, TimeM = 55, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Shatterer", TimeH = 09, TimeM = 00, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Jungle Wurm", TimeH = 09, TimeM = 15, TimeS = 00, Checked = false, Done = false });    
            items.Add(new BossItem() { id = 1, Category = "Modniir Ulgoth", TimeH = 09, TimeM = 30, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Shadow Behemoth", TimeH = 09, TimeM = 45, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Evolved Jungle Wurm", TimeH = 09, TimeM = 55, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Golem Mark II", TimeH = 10, TimeM = 00, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Svanir Shaman", TimeH = 10, TimeM = 15, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Claw of Jormag", TimeH = 10, TimeM = 30, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Fire Elemental", TimeH = 10, TimeM = 45, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Taidha Covington", TimeH = 11, TimeM = 00, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Jungle Wurm", TimeH = 11, TimeM = 15, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Megadestroyer", TimeH = 11, TimeM = 30, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Shadow Behemoth", TimeH = 11, TimeM = 45, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Shatterer", TimeH = 12, TimeM = 00, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Svanir Shaman", TimeH = 12, TimeM = 15, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Modniir Ulgoth", TimeH = 12, TimeM = 30, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Fire Elemental", TimeH = 12, TimeM = 45, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Karka Queen", TimeH = 12, TimeM = 55, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Golem Mark II", TimeH = 13, TimeM = 00, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Jungle Wurm", TimeH = 13, TimeM = 15, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Tequatl the Sunless", TimeH = 13, TimeM = 25, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Claw of Jormag", TimeH = 13, TimeM = 30, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Shadow Behemoth", TimeH = 13, TimeM = 45, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Taidha Covington", TimeH = 14, TimeM = 00, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Svanir Shaman", TimeH = 14, TimeM = 15, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Evolved Jungle Wurm", TimeH = 14, TimeM = 25, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Megadestroyer", TimeH = 14, TimeM = 30, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Fire Elemental", TimeH = 14, TimeM = 45, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Shatterer", TimeH = 15, TimeM = 00, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Jungle Wurm", TimeH = 15, TimeM = 15, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Modniir Ulgoth", TimeH = 15, TimeM = 30, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Shadow Behemoth", TimeH = 15, TimeM = 45, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Golem Mark II", TimeH = 16, TimeM = 00, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Svanir Shaman", TimeH = 16, TimeM = 15, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Claw of Jormag", TimeH = 16, TimeM = 30, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Fire Elemental", TimeH = 16, TimeM = 45, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Karka Queen", TimeH = 16, TimeM = 55, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Taidha Covington", TimeH = 17, TimeM = 00, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Jungle Wurm", TimeH = 17, TimeM = 15, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Megadestroyer", TimeH = 17, TimeM = 30, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Shadow Behemoth", TimeH = 17, TimeM = 45, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Tequatl the Sunless", TimeH = 17, TimeM = 55, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Shatterer", TimeH = 18, TimeM = 00, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Svanir Shaman", TimeH = 18, TimeM = 15, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Modniir Ulgoth", TimeH = 18, TimeM = 30, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Fire Elemental", TimeH = 18, TimeM = 45, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Evolved Jungle Wurm", TimeH = 18, TimeM = 55, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Golem Mark II", TimeH = 19, TimeM = 00, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Jungle Wurm", TimeH = 19, TimeM = 15, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Claw of Jormag", TimeH = 19, TimeM = 30, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Shadow Behemoth", TimeH = 19, TimeM = 45, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Karka Queen", TimeH = 19, TimeM = 55, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Taidha Covington", TimeH = 20, TimeM = 00, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Svanir Shaman", TimeH = 20, TimeM = 15, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Megadestroyer", TimeH = 20, TimeM = 30, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Fire Elemental", TimeH = 20, TimeM = 45, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Tequatl the Sunless", TimeH = 20, TimeM = 55, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Shatterer", TimeH = 21, TimeM = 00, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Jungle Wurm", TimeH = 21, TimeM = 15, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Modniir Ulgoth", TimeH = 21, TimeM = 30, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Shadow Behemoth", TimeH = 21, TimeM = 45, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Evolved Jungle Wurm", TimeH = 21, TimeM = 55, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Golem Mark II", TimeH = 22, TimeM = 00, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Svanir Shaman", TimeH = 22, TimeM = 15, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Claw of Jormag", TimeH = 22, TimeM = 30, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Fire Elemental", TimeH = 22, TimeM = 45, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Taidha Covington", TimeH = 23, TimeM = 00, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Jungle Wurm", TimeH = 23, TimeM = 15, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id = 1, Category = "Megadestroyer", TimeH = 23, TimeM = 30, TimeS = 00, Checked = false, Done = false });
            items.Add(new BossItem() { id=1,Category = "Shadow Behemoth", TimeH = 23, TimeM = 45, TimeS = 00, Checked = false, Done = false });
         

        

            return items;
        }
    }
}

