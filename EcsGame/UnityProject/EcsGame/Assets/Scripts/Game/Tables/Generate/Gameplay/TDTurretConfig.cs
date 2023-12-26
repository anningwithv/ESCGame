//Auto Generate Don't Edit it
using UnityEngine;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using GameFrame;

namespace Game.Logic
{
    public partial class TDTurretConfig
    {
        
       
        private EInt m_Id = 0;   
        private string m_Name;   
        private EFloat m_AtkRange = 0.0f;   
        private EFloat m_AtkInterval = 0.0f;   
        private string m_ProjectilePrefab;  
        
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
        /// 攻击范围
        /// </summary>
        public  float  atkRange {get { return m_AtkRange; } }
       
        /// <summary>
        /// 攻击间隔
        /// </summary>
        public  float  atkInterval {get { return m_AtkInterval; } }
       
        /// <summary>
        /// 子弹
        /// </summary>
        public  string  projectilePrefab {get { return m_ProjectilePrefab; } }
       

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
                    m_AtkRange = dataR.ReadFloat();
                    break;
                case 3:
                    m_AtkInterval = dataR.ReadFloat();
                    break;
                case 4:
                    m_ProjectilePrefab = dataR.ReadString();
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
          ret.Add("AtkRange", 2);
          ret.Add("AtkInterval", 3);
          ret.Add("ProjectilePrefab", 4);
          return ret;
        }
    } 
}//namespace LR