using HarmonyLib;
using UnityEngine.SceneManagement;

namespace SkipInitSelection
{
    [HarmonyPatch(typeof(PreInitSceneScript), "Awake")]
    internal class SkipInitSelectionClass
    {
        [HarmonyPrefix]
        static void SkipInitSelection(ref bool ___choseLaunchOption)
        {
            ___choseLaunchOption = true;
            SceneManager.LoadScene("InitScene");
        }
    }
}
