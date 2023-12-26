//Auto Generate Don't Edit it
using UnityEngine;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using GameFrame;

namespace Game.Logic
{
    public static partial class TDCaptainSkillConfigTable
    {
        private static TDTableMetaData m_MetaData = new TDTableMetaData(TDCaptainSkillConfigTable.Parse, "CaptainSkillConfig");
        public static TDTableMetaData metaData
        {
            get { return m_MetaData; }
        }
        
        private static Dictionary<int, TDCaptainSkillConfig> m_DataCache = new Dictionary<int, TDCaptainSkillConfig>();
        private static List<TDCaptainSkillConfig> m_DataList = new List<TDCaptainSkillConfig >();
        
        public static void Parse(byte[] fileData)
        {
            m_DataCache.Clear();
            m_DataList.Clear();
            DataStreamReader dataR = new DataStreamReader(fileData);
            int rowCount = dataR.GetRowCount();
            int[] fieldIndex = dataR.GetFieldIndex(TDCaptainSkillConfig.GetFieldHeadIndex());
    #if (UNITY_STANDALONE_WIN) || UNITY_EDITOR || UNITY_STANDALONE_OSX
            dataR.CheckFieldMatch(TDCaptainSkillConfig.GetFieldHeadIndex(), "CaptainSkillConfigTable");
    #endif
            for (int i = 0; i < rowCount; ++i)
            {
                TDCaptainSkillConfig memberInstance = new TDCaptainSkillConfig();
                memberInstance.ReadRow(dataR, fieldIndex);
                OnAddRow(memberInstance);
                memberInstance.Reset();
                CompleteRowAdd(memberInstance);
            }
            Log.i(string.Format("Parse Success TDCaptainSkillConfig"));
        }

        private static void OnAddRow(TDCaptainSkillConfig memberInstance)
        {
            int key = memberInstance.iD;
            if (m_DataCache.ContainsKey(key))
            {
                Log.e(string.Format("Invaild,  TDCaptainSkillConfigTable Id already exists {0}", key));
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

        public static List<TDCaptainSkillConfig> dataList
        {
            get 
            {
                return m_DataList;
            }    
        }

        public static TDCaptainSkillConfig GetData(int key)
        {
            if (m_DataCache.ContainsKey(key))
            {
                return m_DataCache[key];
            }
            else
            {
                Log.w(string.Format("Can't find key {0} in TDCaptainSkillConfig", key));
                return null;
            }
        }
    }
}//namespace LR