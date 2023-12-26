//Auto Generate Don't Edit it
using UnityEngine;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using GameFrame;

namespace Game.Logic
{
    public partial class TDEnemyConfig
    {
        
       
        private EInt m_Id = 0;   
        private string m_Name;   
        private string m_Icon;   
        private string m_Desc;   
        private string m_Prefab;   
        private string m_ProjectilePrefab;   
        private string m_SpawnedPrefabWhenDead;   
        private EFloat m_Hp = 0.0f;   
        private EFloat m_MoveSpeed = 0.0f;   
        private EFloat m_Attack = 0.0f;   
        private EFloat m_AttackInterval = 0.0f;   
        private EFloat m_AttackRange = 0.0f;   
        private string m_EnemySizeType;   
        private string m_EnemyAIType;   
        private string m_SkillIds;  
        
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
        /// 预制体
        /// </summary>
        public  string  prefab {get { return m_Prefab; } }
       
        /// <summary>
        /// 投射物预制体
        /// </summary>
        public  string  projectilePrefab {get { return m_ProjectilePrefab; } }
       
        /// <summary>
        /// 死亡时凋落物
        /// </summary>
        public  string  spawnedPrefabWhenDead {get { return m_SpawnedPrefabWhenDead; } }
       
        /// <summary>
        /// 生命值
        /// </summary>
        public  float  hp {get { return m_Hp; } }
       
        /// <summary>
        /// 移动速度
        /// </summary>
        public  float  moveSpeed {get { return m_MoveSpeed; } }
       
        /// <summary>
        /// 攻击力
        /// </summary>
        public  float  attack {get { return m_Attack; } }
       
        /// <summary>
        /// 攻击间隔
        /// </summary>
        public  float  attackInterval {get { return m_AttackInterval; } }
       
        /// <summary>
        /// 攻击距离
        /// </summary>
        public  float  attackRange {get { return m_AttackRange; } }
       
        /// <summary>
        /// 敌人类型
        /// </summary>
        public  string  enemySizeType {get { return m_EnemySizeType; } }
       
        /// <summary>
        /// 敌人AI类型
        /// </summary>
        public  string  enemyAIType {get { return m_EnemyAIType; } }
       
        /// <summary>
        /// 技能列表(id_animName|id2_animName2)
        /// </summary>
        public  string  skillIds {get { return m_SkillIds; } }
       

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
                    m_Prefab = dataR.ReadString();
                    break;
                case 5:
                    m_ProjectilePrefab = dataR.ReadString();
                    break;
                case 6:
                    m_SpawnedPrefabWhenDead = dataR.ReadString();
                    break;
                case 7:
                    m_Hp = dataR.ReadFloat();
                    break;
                case 8:
                    m_MoveSpeed = dataR.ReadFloat();
                    break;
                case 9:
                    m_Attack = dataR.ReadFloat();
                    break;
                case 10:
                    m_AttackInterval = dataR.ReadFloat();
                    break;
                case 11:
                    m_AttackRange = dataR.ReadFloat();
                    break;
                case 12:
                    m_EnemySizeType = dataR.ReadString();
                    break;
                case 13:
                    m_EnemyAIType = dataR.ReadString();
                    break;
                case 14:
                    m_SkillIds = dataR.ReadString();
                    break;
                default:
                    //TableHelper.CacheNewField(dataR, schemeNames[col], m_DataCacheNoGenerate);
                    break;
            }
          }

        }
        
        public static Dictionary<string, int> GetFieldHeadIndex()
        {
          Dictionary<string, int> ret = new Dictionary<string, int>(15);
          
          ret.Add("Id", 0);
          ret.Add("Name", 1);
          ret.Add("Icon", 2);
          ret.Add("Desc", 3);
          ret.Add("Prefab", 4);
          ret.Add("ProjectilePrefab", 5);
          ret.Add("SpawnedPrefabWhenDead", 6);
          ret.Add("Hp", 7);
          ret.Add("MoveSpeed", 8);
          ret.Add("Attack", 9);
          ret.Add("AttackInterval", 10);
          ret.Add("AttackRange", 11);
          ret.Add("EnemySizeType", 12);
          ret.Add("EnemyAIType", 13);
          ret.Add("SkillIds", 14);
          return ret;
        }
    } 
}//namespace LR