using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class AgedBrieTest
    {
        [Fact]
        public void AgedBrieHasMaxQualityOf50()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 50 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(50, Items[0].Quality);
            Assert.Equal(-1, Items[0].SellIn);
        }

        [Fact]
        public void AgedBrieHQualityIncreaseBy2WithNegativeOrZeroSellIn()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = -1, Quality = 10 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(12, Items[0].Quality);
            Assert.Equal(-2, Items[0].SellIn);
        }
    }
}