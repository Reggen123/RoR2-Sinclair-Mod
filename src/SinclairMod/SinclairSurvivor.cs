using RoR2;
using UnityEngine;

namespace SinclairMod
{
    public static class SinclairSurvivor
    {
        public static SurvivorDef CreateSurvivorDef()
        {
            var survivor = ScriptableObject.CreateInstance<SurvivorDef>();

            survivor.name = "Sinclair";
            survivor.displayNameToken = "SINCLAIR_NAME";
            survivor.descriptionToken = "SINCLAIR_DESCRIPTION";
            survivor.primaryColor = new Color(0.43f, 0.70f, 1f);
            survivor.unlockableName = "sinclair";

            // Replace these placeholders with actual prefabs and art assets.
            survivor.bodyPrefab = CreateBodyPrefab();
            survivor.displayPrefab = CreateDisplayPrefab();

            return survivor;
        }

        private static GameObject CreateBodyPrefab()
        {
            var body = new GameObject("SinclairBody");
            body.AddComponent<CharacterBody>();
            body.AddComponent<CharacterMotor>();
            body.AddComponent<CharacterDirection>();
            body.AddComponent<HealthComponent>();
            body.AddComponent<Interactor>();
            body.AddComponent<Inventory>();
            body.AddComponent<SkillLocator>();
            return body;
        }

        private static GameObject CreateDisplayPrefab()
        {
            var display = new GameObject("SinclairDisplay");
            return display;
        }
    }
}
