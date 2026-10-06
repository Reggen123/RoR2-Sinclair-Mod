using System;
using BepInEx;
using R2API;
using RoR2;
using UnityEngine;

namespace SinclairMod
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    [BepInDependency(R2API.R2API.PluginGUID, BepInDependency.DependencyFlags.SoftDependency)]
    public class SinclairPlugin : BaseUnityPlugin
    {
        public const string PluginGUID = "com.reggen.sinclair";
        public const string PluginName = "Sinclair";
        public const string PluginVersion = "0.1.0";

        private void Awake()
        {
            SinclairContent.Register();
            Logger.LogInfo("Sinclair loaded.");
        }
    }
}
