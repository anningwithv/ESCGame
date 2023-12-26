//Auto Generate Don't Edit it
using UnityEngine;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using GameFrame;

namespace Game.Logic
{
    public partial class TDLevelWaveConfig
    {
        
       
        private EInt m_Id = 0;   
        private EInt m_LevelId = 0;   
        private EInt m_WaveTime = 0;   
        private EInt m_MonsterId = 0;   
        private EInt m_MonsterNum = 0;   
        private EInt m_SpawnCount = 0;   
        private EFloat m_SpawnInterval = 0.0f;   
        private EFloat m_SpawnAngle = 0.0f;   
        private EFloat m_SpawnAngleDeletaRange = 0.0f;   
        private EFloat m_SpawnOffset = 0.0f;   
        private EFloat m_SpawnOffsetDeltaRange = 0.0f;   
        private string m_SpawnToast;   
        private bool m_IsBoss = false;   
        private bool m_ClearAll = false;  
        
        //private Dictionary<string, TDUniversally.FieldData> m_DataCacheNoGenerate = new Dictionary<string, TDUniversally.FieldData>();
      
        /// <summary>
        /// Id
        /// </summary>
        public  int  id {get { return m_Id; } }
       
        /// <summary>
        /// 关卡id
        /// </summary>
        public  int  levelId {get { return m_LevelId; } }
       
        /// <summary>
        /// 时间
        /// </summary>
        public  int  waveTime {get { return m_WaveTime; } }
       
        /// <summary>
        /// 怪物Id
        /// </summary>
        public  int  monsterId {get { return m_MonsterId; } }
       
        /// <summary>
        /// 怪物个数
        /// </summary>
        public  int  monsterNum {get { return m_MonsterNum; } }
       
        /// <summary>
        /// 怪物刷出次数（只对MonsterId有效，0表示立即全刷出）
        /// </summary>
        public  int  spawnCount {get { return m_SpawnCount; } }
       
        /// <summary>
        /// 怪物刷出间隔
        /// </summary>
        public  float  spawnInterval {get { return m_SpawnInterval; } }
       
        /// <summary>
        /// 刷出的角度
        /// </summary>
        public  float  spawnAngle {get { return m_SpawnAngle; } }
       
        /// <summary>
        /// 刷出的角度随机值范围
        /// </summary>
        public  float  spawnAngleDeletaRange {get { return m_SpawnAngleDeletaRange; } }
       
        /// <summary>
        /// 刷出的位置偏移
        /// </summary>
        public  float  spawnOffset {get { return m_SpawnOffset; } }
       
        /// <summary>
        /// 刷出的位置偏移随机值范围
        /// </summary>
        public  float  spawnOffsetDeltaRange {get { return m_SpawnOffsetDeltaRange; } }
       
        /// <summary>
        /// 刷出的提示文本
        /// </summary>
        public  string  spawnToast {get { return m_SpawnToast; } }
       
        /// <summary>
        /// 是否是Boss
        /// </summary>
        public  bool  isBoss {get { return m_IsBoss; } }
       
        /// <summary>
        /// 是否清除所有怪
        /// </summary>
        public  bool  clearAll {get { return m_ClearAll; } }
       

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
                    m_LevelId = dataR.ReadInt();
                    break;
                case 2:
                    m_WaveTime = dataR.ReadInt();
                    break;
                case 3:
                    m_MonsterId = dataR.ReadInt();
                    break;
                case 4:
                    m_MonsterNum = dataR.ReadInt();
                    break;
                case 5:
                    m_SpawnCount = dataR.ReadInt();
                    break;
                case 6:
                    m_SpawnInterval = dataR.ReadFloat();
                    break;
                case 7:
                    m_SpawnAngle = dataR.ReadFloat();
                    break;
                case 8:
                    m_SpawnAngleDeletaRange = dataR.ReadFloat();
                    break;
                case 9:
                    m_SpawnOffset = dataR.ReadFloat();
                    break;
                case 10:
                    m_SpawnOffsetDeltaRange = dataR.ReadFloat();
                    break;
                case 11:
                    m_SpawnToast = dataR.ReadString();
                    break;
                case 12:
                    m_IsBoss = dataR.ReadBool();
                    break;
                case 13:
                    m_ClearAll = dataR.ReadBool();
                    break;
                default:
                    //TableHelper.CacheNewField(dataR, schemeNames[col], m_DataCacheNoGenerate);
                    break;
            }
          }

        }
        
        public static Dictionary<string, int> GetFieldHeadIndex()
        {
          Dictionary<string, int> ret = new Dictionary<string, int>(14);
          
          ret.Add("Id", 0);
          ret.Add("LevelId", 1);
          ret.Add("WaveTime", 2);
          ret.Add("MonsterId", 3);
          ret.Add("MonsterNum", 4);
          ret.Add("SpawnCount", 5);
          ret.Add("SpawnInterval", 6);
          ret.Add("SpawnAngle", 7);
          ret.Add("SpawnAngleDeletaRange", 8);
          ret.Add("SpawnOffset", 9);
          ret.Add("SpawnOffsetDeltaRange", 10);
          ret.Add("SpawnToast", 11);
          ret.Add("IsBoss", 12);
          ret.Add("ClearAll", 13);
          return ret;
        }
    } 
}//namespace LR