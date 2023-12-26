//Auto Generate Don't Edit it
using UnityEngine;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using GameFrame;

namespace Game.Logic
{
    public static partial class TDLevelWaveConfigTable
    {
        private static TDTableMetaData m_MetaData = new TDTableMetaData(TDLevelWaveConfigTable.Parse, "LevelWaveConfig");
        public static TDTableMetaData metaData
        {
            get { return m_MetaData; }
        }
        
        private static Dictionary<int, TDLevelWaveConfig> m_DataCache = new Dictionary<int, TDLevelWaveConfig>();
        private static List<TDLevelWaveConfig> m_DataList = new List<TDLevelWaveConfig >();
        
        public static void Parse(byte[] fileData)
        {
            m_DataCache.Clear();
            m_DataList.Clear();
            DataStreamReader dataR = new DataStreamReader(fileData);
            int rowCount = dataR.GetRowCount();
            int[] fieldIndex = dataR.GetFieldIndex(TDLevelWaveConfig.GetFieldHeadIndex());
    #if (UNITY_STANDALONE_WIN) || UNITY_EDITOR || UNITY_STANDALONE_OSX
            dataR.CheckFieldMatch(TDLevelWaveConfig.GetFieldHeadIndex(), "LevelWaveConfigTable");
    #endif
            for (int i = 0; i < rowCount; ++i)
            {
                TDLevelWaveConfig memberInstance = new TDLevelWaveConfig();
                memberInstance.ReadRow(dataR, fieldIndex);
                OnAddRow(memberInstance);
                memberInstance.Reset();
                CompleteRowAdd(memberInstance);
            }
            Log.i(string.Format("Parse Success TDLevelWaveConfig"));
        }

        private static void OnAddRow(TDLevelWaveConfig memberInstance)
        {
            int key = memberInstance.id;
            if (m_DataCache.ContainsKey(key))
            {
                Log.e(string.Format("Invaild,  TDLevelWaveConfigTable Id already exists {0}", key));
            }
            else
            {
                m_DataCache.Add(key, memberInstance);
                m_DataList.Add(memberInstance);
            }
        }    
        
        public static void Reload(byte[] fileData)
        {
            Parse(fileData);
        }

        public static int count
        {
            get 
            {
                return m_DataCache.Count;
            }
        }

        public static List<TDLevelWaveConfig> dataList
        {
            get 
            {
                return m_DataList;
            }    
        }

        public static TDLevelWaveConfig GetData(int key)
        {
            if (m_DataCache.ContainsKey(key))
            {
                return m_DataCache[key];
            }
            else
            {
                Log.w(string.Format("Can't find key {0} in TDLevelWaveConfig", key));
                return null;
            }
        }
    }
}//namespace LR