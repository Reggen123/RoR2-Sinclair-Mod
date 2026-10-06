using System.Collections.Generic;
using RoR2;
using UnityEngine;

namespace SinclairMod
{
    public static class SinclairContent
    {
        private static bool registered;

        public static void Register()
        {
            if (registered)
                return;

            registered = true;

            // Replace these with actual content additions once the prefab and art pipeline are configured.
            var survivor = SinclairSurvivor.CreateSurvivorDef();
            if (survivor != null)
            {
                SurvivorCatalog.getAdditionalSurvivors ??= new List<SurvivorDef>();
                SurvivorCatalog.getAdditionalSurvivors.Add(survivor);
            }

            // Add skill state registrations here when you create the actual skill classes.
            // ContentAddition.AddEntityState(typeof(SinclairPrimaryState));
        }
    }
}
