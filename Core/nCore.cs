using System;
using StardewModdingAPI;

namespace Starno0d.Core
{
    public class nCore : Mod
    {
        public override void Entry(IModHelper helper)
        {
            Monitor.Log("(TMP) Loading I18n...", LogLevel.Debug);

            I18n.Init(helper.Translation);
            
            Monitor.Log("(TMP) I18n loaded!!!\r\n      Starting mod in 3 seconds...", LogLevel.Debug);

            System.Threading.Thread.Sleep(3000);




            Monitor.Log(helper.Translation.Get("common.starting"), LogLevel.Debug);

            System.Threading.Thread.Sleep(3000);

            Monitor.Log(helper.Translation.Get("common.started"), LogLevel.Debug);

            System.Threading.Thread.Sleep(10000);
        }
    }
}
