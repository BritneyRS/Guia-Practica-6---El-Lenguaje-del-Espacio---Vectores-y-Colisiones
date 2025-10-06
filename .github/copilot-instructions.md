# Copilot Instructions for RunnerDeluxe-v2

## Project Overview
This is a Unity-based game project. The main structure follows standard Unity conventions, with source code in `Assets/Scripts/`, scenes in `Assets/Scenes/`, and configuration in `ProjectSettings/`.

## Architecture & Key Components
- **Scripts**: All gameplay logic is in `Assets/Scripts/`. Subfolders (e.g., `Vectors/`, `Player/`, `UI/`) group related scripts by feature or system.
- **Scenes**: Game levels and main menus are in `Assets/Scenes/`. Scene files define the arrangement of GameObjects and their components.
- **Prefabs**: Reusable GameObject templates are in `Assets/Prefabs/`. Prefabs are instantiated via scripts for dynamic gameplay elements.
- **Materials & Physics**: Custom materials and physics settings are in `Assets/Material/` and `Assets/Physics Materials/`.
- **TextMesh Pro**: Advanced text rendering uses TextMesh Pro, with assets in `Assets/TextMesh Pro/`.

## Developer Workflows
- **Build**: Use Unity Editor's build menu. No custom build scripts detected.
- **Play/Debug**: Run and debug via Unity Editor. Attach debugger to Editor for C# script debugging.
- **Dependencies**: Managed via Unity's Package Manager (`Packages/manifest.json`).
- **Version Control**: Project uses Git. Unity-specific files are tracked; large auto-generated folders (e.g., `Library/`, `Temp/`) are ignored.

## Project-Specific Patterns
- **Script Organization**: Scripts are grouped by system. Example: `Assets/Scripts/Vectors/VectorVisualizer.cs` visualizes vector math in-game.
- **Component-Based Design**: Game logic is split into MonoBehaviour components attached to GameObjects. Prefer composition over inheritance.
- **Meta Files**: Unity uses `.meta` files for asset tracking. Always commit `.meta` files with their assets.
- **Scene Management**: Scene transitions and loading are handled via Unity's SceneManager API.

## Integration Points
- **External Assets**: Imported assets are in `Assets/Imported Assets/`.
- **TextMesh Pro**: Ensure TextMesh Pro package is installed for text rendering.
- **Physics**: Custom physics materials are used for gameplay feel.

## Conventions & Best Practices
- **Naming**: Use PascalCase for scripts/classes, camelCase for variables/methods.
- **Folder Structure**: Maintain Unity's folder conventions for assets and scripts.
- **Prefabs**: Instantiate prefabs via script for dynamic objects.
- **Testing**: No explicit test framework detected; manual playtesting via Editor is standard.

## Example: Adding a New Feature
1. Create a new script in the relevant subfolder under `Assets/Scripts/`.
2. Attach the script to a GameObject in a scene or prefab.
3. Commit both the script and its `.meta` file.
4. Test in Unity Editor.

---
If any section is unclear or missing, please provide feedback to improve these instructions.