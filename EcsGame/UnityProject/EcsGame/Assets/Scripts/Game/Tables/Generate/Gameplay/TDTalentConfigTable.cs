//Auto Generate Don't Edit it
using UnityEngine;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using GameFrame;

namespace Game.Logic
{
    public static partial class TDTalentConfigTable
    {
        private static TDTableMetaData m_MetaData = new TDTableMetaData(TDTalentConfigTable.Parse, "TalentConfig");
        public static TDTableMetaData metaData
        {
            get { return m_MetaData; }
        }
        
        private static Dictionary<int, TDTalentConfig> m_DataCache = new Dictionary<int, TDTalentConfig>();
        private static List<TDTalentConfig> m_DataList = new List<TDTalentConfig >();
        
        public static void Parse(byte[] fileData)
        {
            m_DataCache.Clear();
            m_DataList.Clear();
            DataStreamReader dataR = new DataStreamReader(fileData);
            int rowCount = dataR.GetRowCount();
            int[] fieldIndex = dataR.GetFieldIndex(TDTalentConfig.GetFieldHeadIndex());
    #if (UNITY_STANDALONE_WIN) || UNITY_EDITOR || UNITY_STANDALONE_OSX
            dataR.CheckFieldMatch(TDTalentConfig.GetFieldHeadIndex(), "TalentConfigTable");
    #endif
            for (int i = 0; i < rowCount; ++i)
            {
                TDTalentConfig memberInstance = new TDTalentConfig();
                memberInstance.ReadRow(dataR, fieldIndex);
                OnAddRow(memberInstance);
                memberInstance.Reset();
                CompleteRowAdd(memberInstance);
            }
            Log.i(string.Format("Parse Success TDTalentConfig"));
        }

        private static void OnAddRow(TDTalentConfig memberInstance)
        {
            int key = memberInstance.id;
            if (m_DataCache.ContainsKey(key))
            {
                Log.e(string.Format("Invaild,  TDTalentConfigTable Id already exists {0}", key));
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

        public static List<TDTalentConfig> dataList
        {
            get 
            {
                return m_DataList;
            }    
        }

        public static TDTalentConfig GetData(int key)
        {
            if (m_DataCache.ContainsKey(key))
            {
                return m_DataCache[key];
            }
            else
            {
                Log.w(string.Format("Can't find key {0} in TDTalentConfig", key));
                return null;
            }
        }
    }
}//namespace LR