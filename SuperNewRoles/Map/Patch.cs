using System;
using System.Collections.Generic;
using System.Text;
using HarmonyLib;
using UnityEngine;

namespace SuperNewRoles.Map
{
    public static class Patch
    {
        [HarmonyPatch(typeof(MapBehaviour), nameof(MapBehaviour.Awake))]
        class ChangeMapPatch
        {
            public static void Postfix(MapBehaviour __instance)
            {
                if (Data.IsMap(CustomMapNames.Agartha))
                {
                    Agartha.Patch.MiniMapPatch.MinimapChange(__instance);
                }
            }
        }
    }
}
