//Auto Generate Don't Edit it
using UnityEngine;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using GameFrame;

namespace Game.Logic
{
    public partial class TDEnemySkillConfig
    {
        
       
        private EInt m_ID = 0;   
        private string m_Name;   
        private string m_Desc;   
        private string m_Icon;   
        private string m_TriggerCondition;   
        private EFloat m_CDTime = 0.0f;   
        private EFloat m_CastTime = 0.0f;   
        private EFloat m_RecoverTime = 0.0f;   
        private EFloat m_DamageRatio = 0.0f;  
        
        //private Dictionary<string, TDUniversally.FieldData> m_DataCacheNoGenerate = new Dictionary<string, TDUniversally.FieldData>();
      
        /// <summary>
        /// SkillID
        /// </summary>
        public  int  iD {get { return m_ID; } }
       
        /// <summary>
        /// 名称
        /// </summary>
        public  string  name {get { return m_Name; } }
       
        /// <summary>
        /// 图标
        /// </summary>
        public  string  desc {get { return m_Desc; } }
       
        /// <summary>
        /// 描述
        /// </summary>
        public  string  icon {get { return m_Icon; } }
       
        /// <summary>
        /// 触发条件（Distance:1|SelfHPPercent:50|Target:Captain_Solider）
        /// </summary>
        public  string  triggerCondition {get { return m_TriggerCondition; } }
       
        /// <summary>
        /// cd时间
        /// </summary>
        public  float  cDTime {get { return m_CDTime; } }
       
        /// <summary>
        /// 前摇时间
        /// </summary>
        public  float  castTime {get { return m_CastTime; } }
       
        /// <summary>
        /// 后摇时间
        /// </summary>
        public  float  recoverTime {get { return m_RecoverTime; } }
       
        /// <summary>
        /// 伤害系数（身体碰撞伤害的倍数）
        /// </summary>
        public  float  damageRatio {get { return m_DamageRatio; } }
       

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
                    m_ID = dataR.ReadInt();
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
                    m_TriggerCondition = dataR.ReadString();
                    break;
                case 5:
                    m_CDTime = dataR.ReadFloat();
                    break;
                case 6:
                    m_CastTime = dataR.ReadFloat();
                    break;
                case 7:
                    m_RecoverTime = dataR.ReadFloat();
                    break;
                case 8:
                    m_DamageRatio = dataR.ReadFloat();
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
          
          ret.Add("ID", 0);
          ret.Add("Name", 1);
          ret.Add("Desc", 2);
          ret.Add("Icon", 3);
          ret.Add("TriggerCondition", 4);
          ret.Add("CDTime", 5);
          ret.Add("CastTime", 6);
          ret.Add("RecoverTime", 7);
          ret.Add("DamageRatio", 8);
          return ret;
        }
    } 
}//namespace LR