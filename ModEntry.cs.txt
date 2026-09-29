

using System;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;

namespace StardewTechAndMotors
{
    public class ModEntry : Mod
    {
        public override void Entry(IModHelper helper)
        {
            helper.Events.GameLoop.DayStarted += OnDayStarted;
            helper.Events.Input.ButtonPressed += OnButtonPressed;

            Monitor.Log("Stardew Tech & Motors cargado con éxito.", LogLevel.Info);
        }

        private void OnDayStarted(object? sender, DayStartedEventArgs e)
        {
            if (Game1.currentSeason == "fall" && Game1.dayOfMonth == 15)
            {
                Game1.showGlobalMessage("¡Hoy se celebra la Feria Tecnológica de Pelícano en la playa!");
            }
        }

        private void OnButtonPressed(object? sender, ButtonPressedEventArgs e)
        {
            if (!Context.IsWorldReady) return;

            if (e.Button == SButton.K && Context.IsPlayerFree)
            {
                Game1.addHUDMessage(new HUDMessage("Dron / Moto desplegado correctamente.", 2));
            }
        }
    }
}
