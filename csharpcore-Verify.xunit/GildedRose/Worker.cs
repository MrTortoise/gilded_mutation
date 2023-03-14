using System;
using System.Collections.Generic;

namespace GildedRoseKata;

public static class Worker
{
    public static void DoStuff(IList<Item> items, int daysMax, Action<string> writer)
    {
        var app = new GildedRose(items);

        writer("OMGHAI!");
        for (var i = 0; i < daysMax; i++)
        {
            writer("-------- day " + i + " --------");
            writer("name, sellIn, quality");
            foreach (var item in items)
            {
                writer(item.Name + ", " + item.SellIn + ", " + item.Quality);
            }

            writer("");
            app.UpdateQuality();
        }
    }
}