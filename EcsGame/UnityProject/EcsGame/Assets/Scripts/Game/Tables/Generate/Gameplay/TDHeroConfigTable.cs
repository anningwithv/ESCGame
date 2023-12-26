//Auto Generate Don't Edit it
using UnityEngine;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using GameFrame;

namespace Game.Logic
{
    public static partial class TDHeroConfigTable
    {
        private static TDTableMetaData m_MetaData = new TDTableMetaData(TDHeroConfigTable.Parse, "HeroConfig");
        public static TDTableMetaData metaData
        {
            get { return m_MetaData; }
        }
        
        private static Dictionary<int, TDHeroConfig> m_DataCache = new Dictionary<int, TDHeroConfig>();
        private static List<TDHeroConfig> m_DataList = new List<TDHeroConfig >();
        
        public static void Parse(byte[] fileData)
        {
            m_DataCache.Clear();
            m_DataList.Clear();
            DataStreamReader dataR = new DataStreamReader(fileData);
            int rowCount = dataR.GetRowCount();
            int[] fieldIndex = dataR.GetFieldIndex(TDHeroConfig.GetFieldHeadIndex());
    #if (UNITY_STANDALONE_WIN) || UNITY_EDITOR || UNITY_STANDALONE_OSX
            dataR.CheckFieldMatch(TDHeroConfig.GetFieldHeadIndex(), "HeroConfigTable");
    #endif
            for (int i = 0; i < rowCount; ++i)
            {
                TDHeroConfig memberInstance = new TDHeroConfig();
                memberInstance.ReadRow(dataR, fieldIndex);
                OnAddRow(memberInstance);
                memberInstance.Reset();
                CompleteRowAdd(memberInstance);
            }
            Log.i(string.Format("Parse Success TDHeroConfig"));
        }

        private static void OnAddRow(TDHeroConfig memberInstance)
        {
            int key = memberInstance.id;
            if (m_DataCache.ContainsKey(key))
            {
                Log.e(string.Format("Invaild,  TDHeroConfigTable Id already exists {0}", key));
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

        public static List<TDHeroConfig> dataList
        {
            get 
            {
                return m_DataList;
            }    
        }

        public static TDHeroConfig GetData(int key)
        {
            if (m_DataCache.ContainsKey(key))
            {
                return m_DataCache[key];
            }
            else
            {
                Log.w(string.Format("Can't find key {0} in TDHeroConfig", key));
                return null;
            }
        }
    }
}//namespace LR