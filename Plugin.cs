using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastMovement
{
    [BepInPlugin(MyGuid, PluginName, VersionString)]
    public class Plugin : BaseUnityPlugin
    {
        private const string MyGuid = "Ccode.FastMovement";
        private const string PluginName = "FastMovement";
        private const string VersionString = "0.0.1";

        private static readonly Harmony Harmony = new Harmony(MyGuid);

        public static ManualLogSource Log;

        private void Awake()
        {
            Harmony.PatchAll();
            Logger.LogInfo(PluginName + " " + VersionString + " " + "loaded.");
            Log = Logger;
        }
    }
}
