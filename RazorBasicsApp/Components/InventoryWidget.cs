using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorBasicsApp.Components
{
    public class InventoryWidget: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int threshold=10)
        {
            await Task.Delay(0);
            var inventory = new List<InventoryItem>()
            {
                new InventoryItem() {  Name = "Banner", Count = 8 },
                new InventoryItem() {  Name = "Markers", Count = 3 },
                new InventoryItem() {  Name = "Jacket", Count = 14 },
                new InventoryItem() {  Name = "Hoodie", Count = 1 },
                new InventoryItem() {  Name = "Poster", Count = 6 },
                new InventoryItem() {  Name = "Pens", Count = 16 }
            };
            inventory = inventory.Where(x => x.Count <= threshold).ToList();
            return View(inventory);
        }
    }

    public class InventoryItem
    {
        public string Name { get;  set; }
        public int Count { get;  set; }
    }
}
