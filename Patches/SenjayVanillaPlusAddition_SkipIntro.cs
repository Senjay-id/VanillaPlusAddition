using HarmonyLib;
using UnityEngine.SceneManagement;

namespace SkipGameInitialization
{
    internal class SkipGameInitializationClass
    {
        [HarmonyPatch(typeof(PreInitSceneScript), "Awake")]
        [HarmonyPrefix]
        static void SkipInitSelection(ref bool ___choseLaunchOption)
        {
            ___choseLaunchOption = true;
            SceneManager.LoadScene("InitScene");
        }

        [HarmonyPatch(typeof(InitializeGame), "Awake")]
        [HarmonyPostfix]
        static void SkipIntroAnimation(ref bool ___runBootUpScreen) 
        {
            ___runBootUpScreen = false;
        }     
    }
}
