using System;
using StardewModdingAPI;

namespace Starno0d.TestMod
{
    public class ModEntry : Mod
    {
        public override void Entry(IModHelper helper)
        {
            Monitor.Log(helper.Translation.Get("common.starting"), LogLevel.Debug);

            System.Threading.Thread.Sleep(3000);

            Monitor.Log(helper.Translation.Get("common.started"), LogLevel.Debug);

            System.Threading.Thread.Sleep(10000);


            /*for (int i = 0; i < 30; i++)
            {
                Monitor.Log($"Starno0d TEST MOD LOADED - {i}...", LogLevel.Debug);
                System.Threading.Thread.Sleep(1000);
            }*/
        }
    }
}
