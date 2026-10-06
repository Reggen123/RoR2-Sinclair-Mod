# Sinclair for Risk of Rain 2

A mod project scaffold for adding Sinclair from Deadlock as a playable survivor in Risk of Rain 2.

This repository is intentionally structured as a starter kit rather than a finished commercial-quality character mod, because RoR2 modding requires game-specific assets, prefabs, animations, and a configured dev environment for the actual game files.

## Included

- BepInEx plugin bootstrap for a custom survivor
- Survivor registration scaffold
- Skill family placeholders for the core Sinclairs gameplay loop
- Config scaffolding for tuning values
- Setup instructions for building against a local RoR2 install

## Recommended use

Use this as a starting point for a custom mod in a local RoR2 development environment and replace the placeholders with your own:

- character portrait / icon art
- body prefab / renderer setup
- sound effects and VFX
- actual state machine logic for primary, secondary, utility, and special skills
- custom language tokens and unlock conditions

## Local setup

1. Install Risk of Rain 2 and ensure you have a valid modding setup.
2. Install BepInEx and the required modding dependencies.
3. Point the project references to your local game assemblies.
4. Build the project.
5. Copy the compiled DLL into your `BepInEx/plugins` folder.
6. Launch the game and confirm the character appears in the survivor selection screen.

## Suggested gameplay direction

Sinclair is designed as a high-tempo, burst-control survivor with a mix of:

- quick melee or ranged pressure
- short-range burst damage windows
- utility that supports mobility or positioning
- a signature "Deadlock-inspired" style expressed through custom state names and effects

## Important note

This repository intentionally does not include copyrighted game art or assets from Deadlock or Risk of Rain 2. You must provide your own original or legally authorized art assets before publishing a mod.

## License

MIT
