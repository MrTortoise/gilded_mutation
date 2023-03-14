using System.Collections.Generic;
using GildedRoseKata;
using Xunit;

namespace GildedRoseTests;

public class ItemTest
{
    [Fact]
    public void ItemQualityDecreasesBy1WhenOver0()
    {
        IList<Item> Items = new List<Item>
            { new Item { Name = "dave", SellIn = 11, Quality = 4 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(3, Items[0].Quality);
        Assert.Equal(10, Items[0].SellIn);
    }
        
    [Fact]
    public void ItemQualityDoesntGoUnder0()
    {
        IList<Item> Items = new List<Item>
            { new Item { Name = "dave", SellIn = 11, Quality = 0 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(0, Items[0].Quality);
        Assert.Equal(10, Items[0].SellIn);
    }
        
    [Fact]
    public void ItemQualityGoesDownBy2WhenSellinLessThan0()
    {
        IList<Item> Items = new List<Item>
            { new Item { Name = "dave", SellIn = -1, Quality = 10 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(8, Items[0].Quality);
        Assert.Equal(-2, Items[0].SellIn);
    }
}