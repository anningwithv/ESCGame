//Auto Generate Don't Edit it
using UnityEngine;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using GameFrame;

namespace Game.Logic
{
    public partial class TDBuffConfig
    {
        
       
        private EInt m_Id = 0;   
        private string m_Name;   
        private string m_Desc;   
        private string m_Icon;   
        private string m_HeroBuffTipPrefab;   
        private EFloat m_Duration = 0.0f;   
        private EFloat m_Damage = 0.0f;  
        
        //private Dictionary<string, TDUniversally.FieldData> m_DataCacheNoGenerate = new Dictionary<string, TDUniversally.FieldData>();
      
        /// <summary>
        /// 等级
        /// </summary>
        public  int  id {get { return m_Id; } }
       
        /// <summary>
        /// 名字
        /// </summary>
        public  string  name {get { return m_Name; } }
       
        /// <summary>
        /// 描述
        /// </summary>
        public  string  desc {get { return m_Desc; } }
       
        /// <summary>
        /// 图标
        /// </summary>
        public  string  icon {get { return m_Icon; } }
       
        /// <summary>
        /// 英雄头上的提示
        /// </summary>
        public  string  heroBuffTipPrefab {get { return m_HeroBuffTipPrefab; } }
       
        /// <summary>
        /// 持续时间
        /// </summary>
        public  float  duration {get { return m_Duration; } }
       
        /// <summary>
        /// 伤害
        /// </summary>
        public  float  damage {get { return m_Damage; } }
       

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
                    m_Desc = dataR.ReadString();
                    break;
                case 3:
                    m_Icon = dataR.ReadString();
                    break;
                case 4:
                    m_HeroBuffTipPrefab = dataR.ReadString();
                    break;
                case 5:
                    m_Duration = dataR.ReadFloat();
                    break;
                case 6:
                    m_Damage = dataR.ReadFloat();
                    break;
                default:
                    //TableHelper.CacheNewField(dataR, schemeNames[col], m_DataCacheNoGenerate);
                    break;
            }
          }

        }
        
        public static Dictionary<string, int> GetFieldHeadIndex()
        {
          Dictionary<string, int> ret = new Dictionary<string, int>(7);
          
          ret.Add("Id", 0);
          ret.Add("Name", 1);
          ret.Add("Desc", 2);
          ret.Add("Icon", 3);
          ret.Add("HeroBuffTipPrefab", 4);
          ret.Add("Duration", 5);
          ret.Add("Damage", 6);
          return ret;
        }
    } 
}//namespace LR