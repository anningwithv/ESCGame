//Auto Generate Don't Edit it
using UnityEngine;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using GameFrame;

namespace Game.Logic
{
    public partial class TDCaptainConfig
    {
        
       
        private EInt m_Id = 0;   
        private string m_Name;   
        private EInt m_HeroId = 0;   
        private EInt m_SkillId = 0;   
        private bool m_InitLocked = false;  
        
        //private Dictionary<string, TDUniversally.FieldData> m_DataCacheNoGenerate = new Dictionary<string, TDUniversally.FieldData>();
      
        /// <summary>
        /// Id
        /// </summary>
        public  int  id {get { return m_Id; } }
       
        /// <summary>
        /// 名字
        /// </summary>
        public  string  name {get { return m_Name; } }
       
        /// <summary>
        /// 标题
        /// </summary>
        public  int  heroId {get { return m_HeroId; } }
       
        /// <summary>
        /// 描述
        /// </summary>
        public  int  skillId {get { return m_SkillId; } }
       
        /// <summary>
        /// 初始锁定
        /// </summary>
        public  bool  initLocked {get { return m_InitLocked; } }
       

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
                    m_HeroId = dataR.ReadInt();
                    break;
                case 3:
                    m_SkillId = dataR.ReadInt();
                    break;
                case 4:
                    m_InitLocked = dataR.ReadBool();
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
          ret.Add("Name", 1);
          ret.Add("HeroId", 2);
          ret.Add("SkillId", 3);
          ret.Add("InitLocked", 4);
          return ret;
        }
    } 
}//namespace LR