//Auto Generate Don't Edit it
using UnityEngine;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using GameFrame;

namespace Game.Logic
{
    public partial class TDChapterConfig
    {
        
       
        private EInt m_Id = 0;   
        private string m_Name;   
        private string m_Title;   
        private string m_Desc;   
        private string m_Image;   
        private string m_MapPrefab;   
        private EInt m_StartLevel = 0;   
        private EInt m_EndLevel = 0;  
        
        //private Dictionary<string, TDUniversally.FieldData> m_DataCacheNoGenerate = new Dictionary<string, TDUniversally.FieldData>();
      
        /// <summary>
        /// Id
        /// </summary>
        public  int  id {get { return m_Id; } }
       
        /// <summary>
        /// 章节名称
        /// </summary>
        public  string  name {get { return m_Name; } }
       
        /// <summary>
        /// 标题
        /// </summary>
        public  string  title {get { return m_Title; } }
       
        /// <summary>
        /// 描述
        /// </summary>
        public  string  desc {get { return m_Desc; } }
       
        /// <summary>
        /// 章节图
        /// </summary>
        public  string  image {get { return m_Image; } }
       
        /// <summary>
        /// 地图预制件
        /// </summary>
        public  string  mapPrefab {get { return m_MapPrefab; } }
       
        /// <summary>
        /// 起始关卡
        /// </summary>
        public  int  startLevel {get { return m_StartLevel; } }
       
        /// <summary>
        /// 结束关卡
        /// </summary>
        public  int  endLevel {get { return m_EndLevel; } }
       

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
                    m_Name = dataR.ReadString();
                    break;
                case 2:
                    m_Title = dataR.ReadString();
                    break;
                case 3:
                    m_Desc = dataR.ReadString();
                    break;
                case 4:
                    m_Image = dataR.ReadString();
                    break;
                case 5:
                    m_MapPrefab = dataR.ReadString();
                    break;
                case 6:
                    m_StartLevel = dataR.ReadInt();
                    break;
                case 7:
                    m_EndLevel = dataR.ReadInt();
                    break;
                default:
                    //TableHelper.CacheNewField(dataR, schemeNames[col], m_DataCacheNoGenerate);
                    break;
            }
          }

        }
        
        public static Dictionary<string, int> GetFieldHeadIndex()
        {
          Dictionary<string, int> ret = new Dictionary<string, int>(8);
          
          ret.Add("Id", 0);
          ret.Add("Name", 1);
          ret.Add("Title", 2);
          ret.Add("Desc", 3);
          ret.Add("Image", 4);
          ret.Add("MapPrefab", 5);
          ret.Add("StartLevel", 6);
          ret.Add("EndLevel", 7);
          return ret;
        }
    } 
}//namespace LR