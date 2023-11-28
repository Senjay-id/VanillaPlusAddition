using GameNetcodeStuff;
using HarmonyLib;

namespace CompanyBuildingInfiniteStamina
{
    [HarmonyPatch(typeof(PlayerControllerB), "Update")]
    internal class InfiniteStaminaOnCompanyBuildingClass
    {
        [HarmonyPostfix]
        static void InfiniteStaminaOnCompanyBuilding(ref float ___sprintMeter)
        {
            var startOfRound = StartOfRound.Instance;
            if (startOfRound is not null && startOfRound.currentLevel.levelID == 3)
            {
                ___sprintMeter = 1f;
            }
        }
    }
}
