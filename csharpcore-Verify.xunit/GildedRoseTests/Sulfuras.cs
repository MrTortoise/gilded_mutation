using System.Collections.Generic;
using GildedRoseKata;
using Xunit;

namespace GildedRoseTests;

public class Sulfuras
{
    [Fact]
    public void DoesNothing()
    {
        IList<Item> Items = new List<Item>
            { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 10 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(10, Items[0].Quality);
        Assert.Equal(-1, Items[0].SellIn);
    }
}