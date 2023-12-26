//Auto Generate Don't Edit it
using UnityEngine;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using GameFrame;

namespace Game.Logic
{
    public partial class TDShipConfig
    {
        
       
        private EInt m_Id = 0;   
        private string m_Name;   
        private string m_Boards;   
        private bool m_InitLocked = false;   
        private EFloat m_Defense = 0.0f;   
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
        /// 内容
        /// </summary>
        public  string  boards {get { return m_Boards; } }
       
        /// <summary>
        /// 初始是否解锁
        /// </summary>
        public  bool  initLocked {get { return m_InitLocked; } }
       
        /// <summary>
        /// 防御力
        /// </summary>
        public  float  defense {get { return m_Defense; } }
       
        /// <summary>
        /// 碰撞伤害
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
                    m_Boards = dataR.ReadString();
                    break;
                case 3:
                    m_InitLocked = dataR.ReadBool();
                    break;
                case 4:
                    m_Defense = dataR.ReadFloat();
                    break;
                case 5:
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
          Dictionary<string, int> ret = new Dictionary<string, int>(6);
          
          ret.Add("Id", 0);
          ret.Add("Name", 1);
          ret.Add("Boards", 2);
          ret.Add("InitLocked", 3);
          ret.Add("Defense", 4);
          ret.Add("Damage", 5);
          return ret;
        }
    } 
}//namespace LR