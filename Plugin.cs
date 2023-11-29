using BepInEx;
using BepInEx.Logging;
using CompanyBuildingInfiniteStamina;
using HarmonyLib;
using SkipGameInitialization;

namespace SenjayVPA
{
    [BepInPlugin(GUID, Name, Version)]
    public class SenjayVanillaPlusAdditionClass : BaseUnityPlugin
    {
        private const string Author = "Senjay";
        private const string Name = "Senjay's Vanilla Plus Addition";
        private const string Version = "1.0.3";
        private const string GUID = Author + ".VanillaPlusAddition";

        private readonly Harmony harmony = new Harmony(GUID);

        private static SenjayVanillaPlusAdditionClass Instance;

        internal ManualLogSource mls;

        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }

            harmony.PatchAll(typeof(SenjayVanillaPlusAdditionClass));
            harmony.PatchAll(typeof(SkipGameInitializationClass));
            harmony.PatchAll(typeof(InfiniteStaminaOnCompanyBuildingClass)); 

            mls = BepInEx.Logging.Logger.CreateLogSource(GUID);

            mls.LogInfo(Name + " has been loaded into the game");

            //Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
        }
    }
}
