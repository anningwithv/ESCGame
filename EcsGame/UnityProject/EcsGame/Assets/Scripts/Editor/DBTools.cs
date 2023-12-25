using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

namespace Game.Logic
{
    public class PlayerPrefTools
    {
        [MenuItem("DB Tools/Clear Saved Data")]
        static public void ClearSavedData()
        {
            PlayerPrefs.DeleteAll();

            string path = GameDataHandler.s_path;
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            bool isHaveData = Directory.Exists(Application.persistentDataPath + "/cache");
            if (isHaveData)
            {
                Directory.Delete(Application.persistentDataPath + "/cache", true);
            }
        }
    }
}
