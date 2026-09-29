

using System.Collections.Generic;
using StardewModdingAPI;
using StardewValley;
using StardewValley.Menus;

namespace StardewTechAndMotors
{
    public class WorkshopManager
    {
        public static void OpenShop()
        {
            List<Item> options = new List<Item>
            {
                new StardewValley.Object("388", 10)
            };

            Game1.activeClickableMenu = new ShopMenu(options, 0, "PelicanMotors");
        }
    }
}
