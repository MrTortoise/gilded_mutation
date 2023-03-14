using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using VerifyXunit;
using Xunit;

namespace GildedRoseTests
{
    [UsesVerify]
    public class ApprovalTest
    {
        [Fact]
        public Task ThirtyDays()
        {
            var fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            Console.SetIn(new StringReader("a\n"));
        
            Program.Main(new string[] { });
            var output = fakeoutput.ToString();
        
            return Verifier.Verify(output);
        }

        [Fact]
        public Task OneDay()
        {
            var fakeoutput = new StringBuilder();
            Worker.DoStuff(new List<Item>(), 3, (message) => fakeoutput.AppendLine(message));
            var output = fakeoutput.ToString();

            return Verifier.Verify(output);
        }
        
        [Fact]
        public Task OneDayWithFoo()
        {
            var fakeoutput = new StringBuilder();
            var items = new List<Item>()
            {
                new(){Name = "foo0", Quality = 0, SellIn = 0},
                new(){Name = "foo1", Quality = 1, SellIn = 0},
                new(){Name = "foo2", Quality = 2, SellIn = 0},
                new(){Name = "foo50", Quality = 50, SellIn = 0},
                new(){Name = "Aged Brie", Quality = 0, SellIn = 1},
                new(){Name = "Aged Brie", Quality = 48, SellIn = 3},
                new(){Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 0, SellIn = 0},
                new(){Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 1, SellIn = 0},
                new(){Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 1, SellIn = 1},
                new(){Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 50, SellIn = 5},
                new(){Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 48, SellIn = 11},
                new(){Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 47, SellIn = 6},
                new(){Name = "Sulfuras, Hand of Ragnaros", Quality = 1, SellIn = 0},
                new(){Name = "Sulfuras, Hand of Ragnaros", Quality = 1, SellIn = -1},
                new(){Name = "Sulfuras, Hand of Ragnaros", Quality = 50, SellIn = 0},
            };
            Worker.DoStuff(items, 3, (message) => fakeoutput.AppendLine(message));
            var output = fakeoutput.ToString();

            return Verifier.Verify(output);
        }
    }
}