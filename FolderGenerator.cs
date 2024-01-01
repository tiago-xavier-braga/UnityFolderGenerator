using UnityEditor;
using UnityEngine;
using System.Collections.Generic;
using System.IO;

namespace PHS.Editor
{
    public class FolderGenerator : EditorWindow
    {
        [MenuItem("Assets/Create Default Folders")]
        private static void SetUpFolders()
        {
            FolderGenerator window = ScriptableObject.CreateInstance<FolderGenerator>();
            window.position = new Rect(Screen.width / 2, Screen.height / 2, 400, 150);
            window.ShowPopup();
        }

        private static void CreateAllFolders()
        {
            Dictionary<string, List<string>> foldersWithSubfolders = new Dictionary<string, List<string>>
            {
                { "Art", new List<string> { "Materials", "Meshes", "Textures", "Fonts", "Animations" } },
                { "Audio", new List<string> { "Musics", "SoundEffects", "VoiceOvers" } },
                { "Code", new List<string> { "Scripts", "Shaders" } },
                { "Editor", new List<string>() },
                { "Level", new List<string> { "Prefabs", "Scenes", "Timelines", "ScriptableObjects" } },
                { "Settings", new List<string> { "Inputs", "Lighting", "Physics", "RenderPipeline" } },
                { "Tests", new List<string>() },
                { "ThirdParty", new List<string>() }
            };

            foreach (var folderEntry in foldersWithSubfolders)
            {
                string mainFolder = folderEntry.Key;

                if (!Directory.Exists("Assets/" + mainFolder))
                {
                    Directory.CreateDirectory("Assets/" + mainFolder);
                }

                foreach (string subfolder in folderEntry.Value)
                {
                    string subfolderPath = Path.Combine("Assets", mainFolder, subfolder);
                    if (!Directory.Exists(subfolderPath))
                    {
                        Directory.CreateDirectory(subfolderPath);
                    }
                }
            }

            AssetDatabase.Refresh();
        }

        void OnGUI()
        {
            EditorGUILayout.LabelField("Click to create the folders");
            this.Repaint();
            GUILayout.Space(70);
            if (GUILayout.Button("Generate!"))
            {
                CreateAllFolders();
                this.Close();
            }
        }
    }
}
