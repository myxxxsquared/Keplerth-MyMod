using Keplerth;
using Harmony;

namespace MyModPatch
{
    [HarmonyPatch(typeof(TilePlacement))]
    [HarmonyPatch(nameof(TilePlacement.IsMineLight))]
    public class ShowMinePatch
    {
        public static bool Prefix(TilePlacement __instance, ref bool __result)
        {
            var placementId = __instance.TiledObject.Tile.PlacementId;
            switch (placementId)
            {
                case 1005:
                case 1006:
                case 1007:
                case 1008:
                case 1012:
                case 1014:
                    __result = true;
                    break;
                default:
                    __result = false;
                    break;
            }
            return false;
        }
    }
}
