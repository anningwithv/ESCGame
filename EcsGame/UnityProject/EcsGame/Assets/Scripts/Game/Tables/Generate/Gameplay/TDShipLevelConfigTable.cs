//Auto Generate Don't Edit it
using UnityEngine;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using GameFrame;

namespace Game.Logic
{
    public static partial class TDShipLevelConfigTable
    {
        private static TDTableMetaData m_MetaData = new TDTableMetaData(TDShipLevelConfigTable.Parse, "ShipLevelConfig");
        public static TDTableMetaData metaData
        {
            get { return m_MetaData; }
        }
        
        private static Dictionary<int, TDShipLevelConfig> m_DataCache = new Dictionary<int, TDShipLevelConfig>();
        private static List<TDShipLevelConfig> m_DataList = new List<TDShipLevelConfig >();
        
        public static void Parse(byte[] fileData)
        {
            m_DataCache.Clear();
            m_DataList.Clear();
            DataStreamReader dataR = new DataStreamReader(fileData);
            int rowCount = dataR.GetRowCount();
            int[] fieldIndex = dataR.GetFieldIndex(TDShipLevelConfig.GetFieldHeadIndex());
    #if (UNITY_STANDALONE_WIN) || UNITY_EDITOR || UNITY_STANDALONE_OSX
            dataR.CheckFieldMatch(TDShipLevelConfig.GetFieldHeadIndex(), "ShipLevelConfigTable");
    #endif
            for (int i = 0; i < rowCount; ++i)
            {
                TDShipLevelConfig memberInstance = new TDShipLevelConfig();
                memberInstance.ReadRow(dataR, fieldIndex);
                OnAddRow(memberInstance);
                memberInstance.Reset();
                CompleteRowAdd(memberInstance);
            }
            Log.i(string.Format("Parse Success TDShipLevelConfig"));
        }

        private static void OnAddRow(TDShipLevelConfig memberInstance)
        {
            int key = memberInstance.level;
            if (m_DataCache.ContainsKey(key))
            {
                Log.e(string.Format("Invaild,  TDShipLevelConfigTable Id already exists {0}", key));
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

        public static List<TDShipLevelConfig> dataList
        {
            get 
            {
                return m_DataList;
            }    
        }

        public static TDShipLevelConfig GetData(int key)
        {
            if (m_DataCache.ContainsKey(key))
            {
                return m_DataCache[key];
            }
            else
            {
                Log.w(string.Format("Can't find key {0} in TDShipLevelConfig", key));
                return null;
            }
        }
    }
}//namespace LR