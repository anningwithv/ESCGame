//Auto Generate Don't Edit it
using UnityEngine;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using GameFrame;

namespace Game.Logic
{
    public static partial class TDEnemySkillConfigTable
    {
        private static TDTableMetaData m_MetaData = new TDTableMetaData(TDEnemySkillConfigTable.Parse, "EnemySkillConfig");
        public static TDTableMetaData metaData
        {
            get { return m_MetaData; }
        }
        
        private static Dictionary<int, TDEnemySkillConfig> m_DataCache = new Dictionary<int, TDEnemySkillConfig>();
        private static List<TDEnemySkillConfig> m_DataList = new List<TDEnemySkillConfig >();
        
        public static void Parse(byte[] fileData)
        {
            m_DataCache.Clear();
            m_DataList.Clear();
            DataStreamReader dataR = new DataStreamReader(fileData);
            int rowCount = dataR.GetRowCount();
            int[] fieldIndex = dataR.GetFieldIndex(TDEnemySkillConfig.GetFieldHeadIndex());
    #if (UNITY_STANDALONE_WIN) || UNITY_EDITOR || UNITY_STANDALONE_OSX
            dataR.CheckFieldMatch(TDEnemySkillConfig.GetFieldHeadIndex(), "EnemySkillConfigTable");
    #endif
            for (int i = 0; i < rowCount; ++i)
            {
                TDEnemySkillConfig memberInstance = new TDEnemySkillConfig();
                memberInstance.ReadRow(dataR, fieldIndex);
                OnAddRow(memberInstance);
                memberInstance.Reset();
                CompleteRowAdd(memberInstance);
            }
            Log.i(string.Format("Parse Success TDEnemySkillConfig"));
        }

        private static void OnAddRow(TDEnemySkillConfig memberInstance)
        {
            int key = memberInstance.iD;
            if (m_DataCache.ContainsKey(key))
            {
                Log.e(string.Format("Invaild,  TDEnemySkillConfigTable Id already exists {0}", key));
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

        public static List<TDEnemySkillConfig> dataList
        {
            get 
            {
                return m_DataList;
            }    
        }

        public static TDEnemySkillConfig GetData(int key)
        {
            if (m_DataCache.ContainsKey(key))
            {
                return m_DataCache[key];
            }
            else
            {
                Log.w(string.Format("Can't find key {0} in TDEnemySkillConfig", key));
                return null;
            }
        }
    }
}//namespace LR