//Auto Generate Don't Edit it
using UnityEngine;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using GameFrame;

namespace Game.Logic
{
    public partial class TDLevelConfig
    {
        
       
        private EInt m_Id = 0;   
        private string m_Name;   
        private string m_Icon;   
        private string m_Desc;   
        private EInt m_PreLevel = 0;   
        private string m_LevelPrefab;   
        private string m_LevelMode;   
        private string m_TargetDesc;   
        private string m_RandomArtifactIds;   
        private string m_ArtifactIdsByLevel;  
        
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
        /// 前置关卡
        /// </summary>
        public  int  preLevel {get { return m_PreLevel; } }
       
        /// <summary>
        /// 关卡预制体
        /// </summary>
        public  string  levelPrefab {get { return m_LevelPrefab; } }
       
        /// <summary>
        /// 关卡模式
        /// </summary>
        public  string  levelMode {get { return m_LevelMode; } }
       
        /// <summary>
        /// 目标描述
        /// </summary>
        public  string  targetDesc {get { return m_TargetDesc; } }
       
        /// <summary>
        /// 关卡随机神器列表（id_权重|id_权重）
        /// </summary>
        public  string  randomArtifactIds {get { return m_RandomArtifactIds; } }
       
        /// <summary>
        /// 关卡等级指定神器列表（level:id_权重|id_权重;）
        /// </summary>
        public  string  artifactIdsByLevel {get { return m_ArtifactIdsByLevel; } }
       

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
                    m_PreLevel = dataR.ReadInt();
                    break;
                case 5:
                    m_LevelPrefab = dataR.ReadString();
                    break;
                case 6:
                    m_LevelMode = dataR.ReadString();
                    break;
                case 7:
                    m_TargetDesc = dataR.ReadString();
                    break;
                case 8:
                    m_RandomArtifactIds = dataR.ReadString();
                    break;
                case 9:
                    m_ArtifactIdsByLevel = dataR.ReadString();
                    break;
                default:
                    //TableHelper.CacheNewField(dataR, schemeNames[col], m_DataCacheNoGenerate);
                    break;
            }
          }

        }
        
        public static Dictionary<string, int> GetFieldHeadIndex()
        {
          Dictionary<string, int> ret = new Dictionary<string, int>(10);
          
          ret.Add("Id", 0);
          ret.Add("Name", 1);
          ret.Add("Icon", 2);
          ret.Add("Desc", 3);
          ret.Add("PreLevel", 4);
          ret.Add("LevelPrefab", 5);
          ret.Add("LevelMode", 6);
          ret.Add("TargetDesc", 7);
          ret.Add("RandomArtifactIds", 8);
          ret.Add("ArtifactIdsByLevel", 9);
          return ret;
        }
    } 
}//namespace LR