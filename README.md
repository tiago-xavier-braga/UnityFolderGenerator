# FolderGenerator


https://github.com/tiago-xavier-braga/UnityFolderGenerator/assets/62892930/c2ef7fbe-a1e0-4b36-9fb3-3ec02bd6a492


This C# script for Unity automates the creation of the standard folder structure for Unity projects. Simply add this script to your project and run it to automatically generate folders according to the following pattern:

```
Assets
+--- Art
|   +--- Materials
|   +--- Meshes
|   +--- Textures
|   +--- Fonts
|   +--- Animations
+--- Audio
|   +--- Musics
|   +--- SoundEffects
|   +--- VoiceOvers
+--- Code
|   +--- Scripts
|   +--- Shaders
+--- Docs
+--- Level
|   +--- Prefabs
|   +--- Scenes
|   +--- Timelines
|   +--- ScriptableObjects
+--- Settings
|   +--- Inputs
|   +--- Lighting
|   +--- Physics
|   +--- RenderPipeline
+--- ThirdParty
```

## Usage

1. Download the `FolderGenerator.cs` script.
2. Add the script to the `Editor` folder within `Assets`.
3. In Unity, go to the `Assets` menu and select `Generate Folders`.

This will automatically create the folder structure in the `Assets` directory of your project.

## Important Note

To prevent empty folders from being pushed to GitHub or Plastic SCM and avoid unnecessary conflicts, make sure to add the following line to your `.gitignore` file:

```
# Ignore empty directories
**/*
```

This ensures that empty folders are not tracked by version control, keeping your repository cleaner and more organized.
