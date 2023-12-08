using GameNetcodeStuff;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastMovement.Patches.Player
{
    [HarmonyPatch(typeof(PlayerControllerB), "Start")]
    internal class SpeedPatches
    {
        public static void Prefix(PlayerControllerB __instance)
        {
            __instance.movementSpeed = 20;
        }
    }
}
