using System.Collections.Generic;
using GildedRoseKata;
using Xunit;

namespace GildedRoseTests;

public class BackStageTest
{
    [Fact]
    public void BackStageWhenQualityZeroThenSellInGoesToZero()
    {
        IList<Item> Items = new List<Item>
            { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 20 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(0, Items[0].Quality);
        Assert.Equal(-1, Items[0].SellIn);
    }

    [Fact]
    public void BackStageWhen5DaysOrLessLeftThenQualityUpBy3()
    {
        IList<Item> Items = new List<Item>
            { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 20 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(23, Items[0].Quality);
        Assert.Equal(4, Items[0].SellIn);
    }

    [Fact]
    public void BackStageWhen10DaysOrLessLeftThenQualityUpBy2()
    {
        IList<Item> Items = new List<Item>
            { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 20 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(22, Items[0].Quality);
        Assert.Equal(9, Items[0].SellIn);
    }

    [Fact]
    public void BackStageWhenMoreThan10DaysQualityGoesUpBy1()
    {
        IList<Item> Items = new List<Item>
            { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 20 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(21, Items[0].Quality);
        Assert.Equal(10, Items[0].SellIn);
    }

    [Fact]
    public void BackStageMaxQualityIs50()
    {
        IList<Item> Items = new List<Item>
            { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 50 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal(50, Items[0].Quality);
        Assert.Equal(10, Items[0].SellIn);
    }
}