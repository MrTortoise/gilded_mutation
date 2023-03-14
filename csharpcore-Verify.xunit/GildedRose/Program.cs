using System;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IList<Item> Items = new List<Item>{
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 49
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 49
                },
				// this conjured item does not work properly yet
				new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };

            DoStuff(Items, 31, (string message) => Console.WriteLine(message));
        }

        public static void DoStuff(IList<Item> items, int daysMax, Action<string> writer)
        {
            var app = new GildedRose(items);

            writer("OMGHAI!");
            for (var i = 0; i < daysMax; i++)
            {
                writer("-------- day " + i + " --------");
                writer("name, sellIn, quality");
                for (var j = 0; j < items.Count; j++)
                {
                    writer(items[j].Name + ", " + items[j].SellIn + ", " + items[j].Quality);
                }

                writer("");
                app.UpdateQuality();
            }
        }
    }
}
