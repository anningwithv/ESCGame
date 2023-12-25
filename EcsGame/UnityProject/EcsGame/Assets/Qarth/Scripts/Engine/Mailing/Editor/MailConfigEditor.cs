





using System;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;

namespace GameFrame.Editor
{
    public class MailConfigEditor
    {
        [MenuItem("Assets/GameFramework/Config/Build MailConfig")]
        public static void BuildMailConfig()
        {
            MailConfig data = null;
            string folderPath = EditorUtils.GetSelectedDirAssetsPath();
            string dataPath = folderPath + "/MailConfig.asset";

            data = AssetDatabase.LoadAssetAtPath<MailConfig>(dataPath);
            if (data == null)
            {
                data = ScriptableObject.CreateInstance<MailConfig>();
                AssetDatabase.CreateAsset(data, dataPath);
            }
            //Log.i("Create Mail Config In Folder:" + dataPath);
            EditorUtility.SetDirty(data);
            AssetDatabase.SaveAssets();
        }
    }
}
