using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        readonly IList<Item> _items;

        public GildedRose(IList<Item> items)
        {
            this._items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in _items)
            {
                switch (item.Name)
                {
                    case "Aged Brie":
                        UpdateAgedBrie(item);
                        break;
                    case "Backstage passes to a TAFKAL80ETC concert":
                        UpdateBackstage(item);
                        break;
                    case "Sulfuras, Hand of Ragnaros":
                        break;
                    default:
                        UpdateItem(item);
                        break;
                }
            }
        }

        private static void UpdateItem(Item item)
        {
            item.SellIn -= 1;
            switch (item.SellIn)
            {
                case <0:
                    item.Quality -= 2;
                    break;
                default:
                    item.Quality--;
                    break;
            }

            if (item.Quality < 0) item.Quality = 0;
        }

        private static void UpdateBackstage(Item item)
        {
            switch (item.SellIn)
            {
                case <= 0:
                    item.Quality = 0;
                    break;
                case < 6:
                    item.Quality += 3;
                    break;
                case < 11:
                    item.Quality += 2;
                    break;
                default:
                    item.Quality++;
                    break;
            }

            if (item.Quality > 50) item.Quality = 50;
            item.SellIn--;
        }

        private static void UpdateAgedBrie(Item item)
        {
            item.SellIn--;
            if (item.SellIn < 0)
            {
                item.Quality += 2;
            }
            else
            {
                item.Quality += 1;
            }

            if (item.Quality > 50) item.Quality = 50;
        }
    }
}