using Keplerth;
using Harmony;

namespace MyModPatch
{
    [StaticConstructorOnStartup]
    public class MyModPatch
    {
        static MyModPatch()
        {
            var harmony = HarmonyInstance.Create("MyModPatch");
            harmony.PatchAll();
        }
    }
}
