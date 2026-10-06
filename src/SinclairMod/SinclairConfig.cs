using BepInEx.Configuration;

namespace SinclairMod
{
    public static class SinclairConfig
    {
        private static ConfigFile? config;

        public static void Init(ConfigFile cfg)
        {
            config = cfg;

            AttackDamageMultiplier = config.Bind(
                "Sinclair",
                "AttackDamageMultiplier",
                1.0f,
                "Damage multiplier for Sinclair's attacks.");

            UtilityCooldownReduction = config.Bind(
                "Sinclair",
                "UtilityCooldownReduction",
                0.2f,
                "Utility cooldown reduction value used during balancing.");
        }

        public static ConfigEntry<float> AttackDamageMultiplier { get; private set; }
        public static ConfigEntry<float> UtilityCooldownReduction { get; private set; }
    }
}
