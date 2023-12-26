//Auto Generate Don't Edit it
using UnityEngine;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using GameFrame;

namespace Game.Logic
{
    public partial class TDWeaponConfig
    {
        
       
        private EInt m_Id = 0;   
        private string m_Name;   
        private string m_Icon;   
        private string m_Desc;   
        private string m_Prefab;   
        private string m_ProjectilePrefab;   
        private string m_AttackTriggerType;   
        private EInt m_MagazineSize = 0;   
        private EFloat m_ReloadTime = 0.0f;   
        private EFloat m_Damage = 0.0f;   
        private EFloat m_ProjectileSpeed = 0.0f;   
        private EFloat m_AimRange = 0.0f;   
        private EFloat m_ProjectileDestroyRange = 0.0f;   
        private EFloat m_AttackInterval = 0.0f;   
        private EInt m_ContinueAttackCount = 0;   
        private EFloat m_TimeBetweenContinueAttack = 0.0f;   
        private EInt m_ProjectilesBranchCount = 0;   
        private EFloat m_ProjectileBranchAngle = 0.0f;   
        private EInt m_Pierce = 0;   
        private EInt m_Rebound = 0;   
        private EInt m_Division = 0;   
        private EFloat m_RefillHp = 0.0f;   
        private EFloat m_CriticalHit = 0.0f;   
        private EFloat m_TrackAngle = 0.0f;  
        
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
        /// 攻击值
        /// </summary>
        public  string  attackTriggerType {get { return m_AttackTriggerType; } }
       
        /// <summary>
        /// 攻击值
        /// </summary>
        public  int  magazineSize {get { return m_MagazineSize; } }
       
        /// <summary>
        /// 攻击值
        /// </summary>
        public  float  reloadTime {get { return m_ReloadTime; } }
       
        /// <summary>
        /// 攻击值
        /// </summary>
        public  float  damage {get { return m_Damage; } }
       
        /// <summary>
        /// 投射物速度
        /// </summary>
        public  float  projectileSpeed {get { return m_ProjectileSpeed; } }
       
        /// <summary>
        /// 瞄准范围
        /// </summary>
        public  float  aimRange {get { return m_AimRange; } }
       
        /// <summary>
        /// 投射物消失范围
        /// </summary>
        public  float  projectileDestroyRange {get { return m_ProjectileDestroyRange; } }
       
        /// <summary>
        /// 攻击间隔
        /// </summary>
        public  float  attackInterval {get { return m_AttackInterval; } }
       
        /// <summary>
        /// 连续攻击数
        /// </summary>
        public  int  continueAttackCount {get { return m_ContinueAttackCount; } }
       
        /// <summary>
        /// 连续攻击时间间隔
        /// </summary>
        public  float  timeBetweenContinueAttack {get { return m_TimeBetweenContinueAttack; } }
       
        /// <summary>
        /// 弹道分支数
        /// </summary>
        public  int  projectilesBranchCount {get { return m_ProjectilesBranchCount; } }
       
        /// <summary>
        /// 弹道分支间隔角度
        /// </summary>
        public  float  projectileBranchAngle {get { return m_ProjectileBranchAngle; } }
       
        /// <summary>
        /// 穿透数
        /// </summary>
        public  int  pierce {get { return m_Pierce; } }
       
        /// <summary>
        /// 反弹数
        /// </summary>
        public  int  rebound {get { return m_Rebound; } }
       
        /// <summary>
        /// 分裂数
        /// </summary>
        public  int  division {get { return m_Division; } }
       
        /// <summary>
        /// 吸血比率
        /// </summary>
        public  float  refillHp {get { return m_RefillHp; } }
       
        /// <summary>
        /// 暴击率
        /// </summary>
        public  float  criticalHit {get { return m_CriticalHit; } }
       
        /// <summary>
        /// 跟踪角度
        /// </summary>
        public  float  trackAngle {get { return m_TrackAngle; } }
       

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
                    m_AttackTriggerType = dataR.ReadString();
                    break;
                case 7:
                    m_MagazineSize = dataR.ReadInt();
                    break;
                case 8:
                    m_ReloadTime = dataR.ReadFloat();
                    break;
                case 9:
                    m_Damage = dataR.ReadFloat();
                    break;
                case 10:
                    m_ProjectileSpeed = dataR.ReadFloat();
                    break;
                case 11:
                    m_AimRange = dataR.ReadFloat();
                    break;
                case 12:
                    m_ProjectileDestroyRange = dataR.ReadFloat();
                    break;
                case 13:
                    m_AttackInterval = dataR.ReadFloat();
                    break;
                case 14:
                    m_ContinueAttackCount = dataR.ReadInt();
                    break;
                case 15:
                    m_TimeBetweenContinueAttack = dataR.ReadFloat();
                    break;
                case 16:
                    m_ProjectilesBranchCount = dataR.ReadInt();
                    break;
                case 17:
                    m_ProjectileBranchAngle = dataR.ReadFloat();
                    break;
                case 18:
                    m_Pierce = dataR.ReadInt();
                    break;
                case 19:
                    m_Rebound = dataR.ReadInt();
                    break;
                case 20:
                    m_Division = dataR.ReadInt();
                    break;
                case 21:
                    m_RefillHp = dataR.ReadFloat();
                    break;
                case 22:
                    m_CriticalHit = dataR.ReadFloat();
                    break;
                case 23:
                    m_TrackAngle = dataR.ReadFloat();
                    break;
                default:
                    //TableHelper.CacheNewField(dataR, schemeNames[col], m_DataCacheNoGenerate);
                    break;
            }
          }

        }
        
        public static Dictionary<string, int> GetFieldHeadIndex()
        {
          Dictionary<string, int> ret = new Dictionary<string, int>(24);
          
          ret.Add("Id", 0);
          ret.Add("Name", 1);
          ret.Add("Icon", 2);
          ret.Add("Desc", 3);
          ret.Add("Prefab", 4);
          ret.Add("ProjectilePrefab", 5);
          ret.Add("AttackTriggerType", 6);
          ret.Add("MagazineSize", 7);
          ret.Add("ReloadTime", 8);
          ret.Add("Damage", 9);
          ret.Add("ProjectileSpeed", 10);
          ret.Add("AimRange", 11);
          ret.Add("ProjectileDestroyRange", 12);
          ret.Add("AttackInterval", 13);
          ret.Add("ContinueAttackCount", 14);
          ret.Add("TimeBetweenContinueAttack", 15);
          ret.Add("ProjectilesBranchCount", 16);
          ret.Add("ProjectileBranchAngle", 17);
          ret.Add("Pierce", 18);
          ret.Add("Rebound", 19);
          ret.Add("Division", 20);
          ret.Add("RefillHp", 21);
          ret.Add("CriticalHit", 22);
          ret.Add("TrackAngle", 23);
          return ret;
        }
    } 
}//namespace LR