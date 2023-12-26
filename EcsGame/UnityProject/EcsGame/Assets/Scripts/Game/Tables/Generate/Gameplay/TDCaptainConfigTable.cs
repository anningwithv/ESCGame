//Auto Generate Don't Edit it
using UnityEngine;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using GameFrame;

namespace Game.Logic
{
    public static partial class TDCaptainConfigTable
    {
        private static TDTableMetaData m_MetaData = new TDTableMetaData(TDCaptainConfigTable.Parse, "CaptainConfig");
        public static TDTableMetaData metaData
        {
            get { return m_MetaData; }
        }
        
        private static Dictionary<int, TDCaptainConfig> m_DataCache = new Dictionary<int, TDCaptainConfig>();
        private static List<TDCaptainConfig> m_DataList = new List<TDCaptainConfig >();
        
        public static void Parse(byte[] fileData)
        {
            m_DataCache.Clear();
            m_DataList.Clear();
            DataStreamReader dataR = new DataStreamReader(fileData);
            int rowCount = dataR.GetRowCount();
            int[] fieldIndex = dataR.GetFieldIndex(TDCaptainConfig.GetFieldHeadIndex());
    #if (UNITY_STANDALONE_WIN) || UNITY_EDITOR || UNITY_STANDALONE_OSX
            dataR.CheckFieldMatch(TDCaptainConfig.GetFieldHeadIndex(), "CaptainConfigTable");
    #endif
            for (int i = 0; i < rowCount; ++i)
            {
                TDCaptainConfig memberInstance = new TDCaptainConfig();
                memberInstance.ReadRow(dataR, fieldIndex);
                OnAddRow(memberInstance);
                memberInstance.Reset();
                CompleteRowAdd(memberInstance);
            }
            Log.i(string.Format("Parse Success TDCaptainConfig"));
        }

        private static void OnAddRow(TDCaptainConfig memberInstance)
        {
            int key = memberInstance.id;
            if (m_DataCache.ContainsKey(key))
            {
                Log.e(string.Format("Invaild,  TDCaptainConfigTable Id already exists {0}", key));
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

        public static List<TDCaptainConfig> dataList
        {
            get 
            {
                return m_DataList;
            }    
        }

        public static TDCaptainConfig GetData(int key)
        {
            if (m_DataCache.ContainsKey(key))
            {
                return m_DataCache[key];
            }
            else
            {
                Log.w(string.Format("Can't find key {0} in TDCaptainConfig", key));
                return null;
            }
        }
    }
}//namespace LR