using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        [Fact]
        public void Foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal("foo", Items[0].Name);
        }
        
        [Fact]
        public void FooQuality1()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 1 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal("foo", Items[0].Name);
        }
        
        [Fact]
        public void FooQuality2()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 2 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal("foo", Items[0].Name);
        }

        [Fact]
        public void BackStage()
        {
            IList<Item> Items = new List<Item> { new Item { Name =  "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal("Backstage passes to a TAFKAL80ETC concert", Items[0].Name);
        }

        
        [Fact]
        public void AgedBrie()
        {
            IList<Item> Items = new List<Item> { new Item { Name =  "Aged Brie", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal( "Aged Brie", Items[0].Name);
        }
        
        [Fact]
        public void Sulfurus()
        {
            IList<Item> Items = new List<Item> { new Item { Name =  "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 1 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal( "Sulfuras, Hand of Ragnaros", Items[0].Name);
        }
    }
}
