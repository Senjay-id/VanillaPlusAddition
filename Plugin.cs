using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using SkipInitSelection;

namespace SenjayVPA
{
    [BepInPlugin(GUID, Name, Version)]
    public class SenjayVanillaPlusAddition : BaseUnityPlugin
    {
        private const string Author = "Senjay";
        private const string Name = "Senjay's Vanilla Plus Addition";
        private const string Version = "1.0.0.0";
        private const string GUID = Author + ".VanillaPlusAddition";

        private readonly Harmony harmony = new Harmony(GUID);

        private static SenjayVanillaPlusAddition Instance;

        internal ManualLogSource mls;

        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }

            harmony.PatchAll(typeof(SenjayVanillaPlusAddition));
            harmony.PatchAll(typeof(SkipInitSelectionClass));

            mls = BepInEx.Logging.Logger.CreateLogSource(GUID);

            mls.LogInfo(Name + " has been loaded into the game");

            //Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
        }
    }
}
