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
        // [Fact]
        // public Task ThirtyDays()
        // {
        //     var fakeoutput = new StringBuilder();
        //     Console.SetOut(new StringWriter(fakeoutput));
        //     Console.SetIn(new StringReader("a\n"));
        //
        //     Program.Main(new string[] { });
        //     var output = fakeoutput.ToString();
        //
        //     return Verifier.Verify(output);
        // }

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
                new Item(){Name = "foo", Quality = 0, SellIn = 0}
            };
            Worker.DoStuff(items, 3, (message) => fakeoutput.AppendLine(message));
            var output = fakeoutput.ToString();

            return Verifier.Verify(output);
        }
    }
}