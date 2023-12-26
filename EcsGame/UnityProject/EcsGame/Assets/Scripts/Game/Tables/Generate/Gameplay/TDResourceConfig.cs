//Auto Generate Don't Edit it
using UnityEngine;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using GameFrame;

namespace Game.Logic
{
    public partial class TDResourceConfig
    {
        
       
        private EInt m_Id = 0;   
        private string m_Path;   
        private string m_ResName;   
        private EInt m_CachedMaxCount = 0;   
        private EInt m_InitCount = 0;  
        
        //private Dictionary<string, TDUniversally.FieldData> m_DataCacheNoGenerate = new Dictionary<string, TDUniversally.FieldData>();
      
        /// <summary>
        /// Id
        /// </summary>
        public  int  id {get { return m_Id; } }
       
        /// <summary>
        /// 路径
        /// </summary>
        public  string  path {get { return m_Path; } }
       
        /// <summary>
        /// 资源名称
        /// </summary>
        public  string  resName {get { return m_ResName; } }
       
        /// <summary>
        /// 缓存最大数量
        /// </summary>
        public  int  cachedMaxCount {get { return m_CachedMaxCount; } }
       
        /// <summary>
        /// 初始生成数量
        /// </summary>
        public  int  initCount {get { return m_InitCount; } }
       

        public void ReadRow(DataStreamReader dataR, int[] filedIndex)
        {
          //var schemeNames = dataR.GetSchemeName();
          int col = 0;
          while(true)
          {
            col = dataR.MoreFieldOnRow();
            if (col == -1)
            {
              break;
            }
            switch (filedIndex[col])
            { 
            
                case 0:
                    m_Id = dataR.ReadInt();
                    break;
                case 1:
                    m_Path = dataR.ReadString();
                    break;
                case 2:
                    m_ResName = dataR.ReadString();
                    break;
                case 3:
                    m_CachedMaxCount = dataR.ReadInt();
                    break;
                case 4:
                    m_InitCount = dataR.ReadInt();
                    break;
                default:
                    //TableHelper.CacheNewField(dataR, schemeNames[col], m_DataCacheNoGenerate);
                    break;
            }
          }

        }
        
        public static Dictionary<string, int> GetFieldHeadIndex()
        {
          Dictionary<string, int> ret = new Dictionary<string, int>(5);
          
          ret.Add("Id", 0);
          ret.Add("Path", 1);
          ret.Add("ResName", 2);
          ret.Add("CachedMaxCount", 3);
          ret.Add("InitCount", 4);
          return ret;
        }
    } 
}//namespace LR