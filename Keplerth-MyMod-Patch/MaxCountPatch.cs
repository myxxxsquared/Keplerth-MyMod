using DataBase;
using Harmony;

namespace MyModPatch
{
    [HarmonyPatch(typeof(ConfigItem))]
    [HarmonyPatch(nameof(ConfigItem.getMaxCount))]
    public class MaxCountPatch
    {
        public static void Postfix(ref int __result)
        {
            if(__result == 999) {
                __result = 99999;
            }
        }
    }
}
