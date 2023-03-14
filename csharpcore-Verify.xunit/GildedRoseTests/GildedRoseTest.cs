using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        [Fact]
        public void FooQuality0DoesntChange()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(0, Items[0].Quality);
        }
        
        [Fact]
        public void FooQuality1WillGotoZero()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 1 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(0, Items[0].Quality);
        }
        
        [Fact]
        public void WhenFooSellIn0QualityWill0()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 2 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(0, Items[0].Quality);
        }
        
        [Fact]
        public void BackStageQuality0SellIn0IsTheSame()
        {
            IList<Item> Items = new List<Item> { new Item { Name =  "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal( 0, Items[0].Quality);
        }
        
        [Fact]
        public void BackStageQuality1SellIn0WillQuality0()
        {
            IList<Item> Items = new List<Item> { new Item { Name =  "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 1 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal( 0, Items[0].Quality);
        }
        
        [Fact]
        public void BackStageQuality1SellIn1WillQuality4()
        {
            IList<Item> Items = new List<Item> { new Item { Name =  "Backstage passes to a TAFKAL80ETC concert", SellIn = 1, Quality = 1 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal( 4, Items[0].Quality);
        }
        
        [Fact]
        public void BackStageQuality49SellIn1WillQuality50()
        {
            IList<Item> Items = new List<Item> { new Item { Name =  "Backstage passes to a TAFKAL80ETC concert", SellIn = 1, Quality = 49 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal( 50, Items[0].Quality);
        }
        
        [Fact]
        public void BackStageQuality48SellIn1WillQuality50()
        {
            IList<Item> Items = new List<Item> { new Item { Name =  "Backstage passes to a TAFKAL80ETC concert", SellIn = 1, Quality = 48 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal( 50, Items[0].Quality);
        }
        
        [Fact]
        public void BackStageQuality1SellIn11WillQuality2()
        {
            IList<Item> Items = new List<Item> { new Item { Name =  "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 1 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal( 2, Items[0].Quality);
        }
        
        [Fact]
        public void BackStageQuality1SellIn6WillQuality2()
        {
            IList<Item> Items = new List<Item> { new Item { Name =  "Backstage passes to a TAFKAL80ETC concert", SellIn = 6, Quality = 1 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal( 3, Items[0].Quality);
        }
        
        [Fact]
        public void BackStageQuality50WillQuality0()
        {
            IList<Item> Items = new List<Item> { new Item { Name =  "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 50 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal( 0, Items[0].Quality);
        }
        
        [Fact]
        public void AgedBrieQuality0Sellin0WillQuality2()
        {
            IList<Item> Items = new List<Item> { new Item { Name =  "Aged Brie", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal( 2, Items[0].Quality);
        }
        
        [Fact]
        public void AgedBrieQuality50WillQuality50()
        {
            IList<Item> Items = new List<Item> { new Item { Name =  "Aged Brie", SellIn = 0, Quality = 50 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal( 50, Items[0].Quality);
        }
        
        [Fact]
        public void Sulfurus()
        {
            IList<Item> Items = new List<Item> { new Item { Name =  "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 1 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal( 1, Items[0].Quality);
            //Assert.Equal(0,Items[0].SellIn);
        }
        
        [Fact]
        public void SulfurusSellInLessThan0()
        {
            IList<Item> Items = new List<Item> { new Item { Name =  "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 1 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal( 1, Items[0].Quality);
            Assert.Equal(-1,Items[0].SellIn);
        }
    }
}
