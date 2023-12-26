//Auto Generate Don't Edit it
using UnityEngine;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using GameFrame;

namespace Game.Logic
{
    public partial class TDHeroConfig
    {
        
       
        private EInt m_Id = 0;   
        private string m_Name;   
        private string m_Icon;   
        private string m_Desc;   
        private EInt m_WeaponId = 0;   
        private string m_Prefab;   
        private string m_HeroType;   
        private EFloat m_InitHp = 0.0f;   
        private string m_Buff;  
        
        //private Dictionary<string, TDUniversally.FieldData> m_DataCacheNoGenerate = new Dictionary<string, TDUniversally.FieldData>();
      
        /// <summary>
        /// Id
        /// </summary>
        public  int  id {get { return m_Id; } }
       
        /// <summary>
        /// 名称
        /// </summary>
        public  string  name {get { return m_Name; } }
       
        /// <summary>
        /// 图标
        /// </summary>
        public  string  icon {get { return m_Icon; } }
       
        /// <summary>
        /// 描述
        /// </summary>
        public  string  desc {get { return m_Desc; } }
       
        /// <summary>
        /// 武器id
        /// </summary>
        public  int  weaponId {get { return m_WeaponId; } }
       
        /// <summary>
        /// 预制体
        /// </summary>
        public  string  prefab {get { return m_Prefab; } }
       
        /// <summary>
        /// 类型
        /// </summary>
        public  string  heroType {get { return m_HeroType; } }
       
        /// <summary>
        /// 初始血量
        /// </summary>
        public  float  initHp {get { return m_InitHp; } }
       
        /// <summary>
        /// Buff
        /// </summary>
        public  string  buff {get { return m_Buff; } }
       

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
                    m_Icon = dataR.ReadString();
                    break;
                case 3:
                    m_Desc = dataR.ReadString();
                    break;
                case 4:
                    m_WeaponId = dataR.ReadInt();
                    break;
                case 5:
                    m_Prefab = dataR.ReadString();
                    break;
                case 6:
                    m_HeroType = dataR.ReadString();
                    break;
                case 7:
                    m_InitHp = dataR.ReadFloat();
                    break;
                case 8:
                    m_Buff = dataR.ReadString();
                    break;
                default:
                    //TableHelper.CacheNewField(dataR, schemeNames[col], m_DataCacheNoGenerate);
                    break;
            }
          }

        }
        
        public static Dictionary<string, int> GetFieldHeadIndex()
        {
          Dictionary<string, int> ret = new Dictionary<string, int>(9);
          
          ret.Add("Id", 0);
          ret.Add("Name", 1);
          ret.Add("Icon", 2);
          ret.Add("Desc", 3);
          ret.Add("WeaponId", 4);
          ret.Add("Prefab", 5);
          ret.Add("HeroType", 6);
          ret.Add("InitHp", 7);
          ret.Add("Buff", 8);
          return ret;
        }
    } 
}//namespace LR