//Auto Generate Don't Edit it
using UnityEngine;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using GameFrame;

namespace Game.Logic
{
    public partial class TDReformConfig
    {
        
       
        private EInt m_Id = 0;   
        private string m_ReformType;   
        private string m_Icon;   
        private string m_AttrModifiers;   
        private EInt m_Level = 0;  
        
        //private Dictionary<string, TDUniversally.FieldData> m_DataCacheNoGenerate = new Dictionary<string, TDUniversally.FieldData>();
      
        /// <summary>
        /// Id
        /// </summary>
        public  int  id {get { return m_Id; } }
       
        /// <summary>
        /// 神器类型
        /// </summary>
        public  string  reformType {get { return m_ReformType; } }
       
        /// <summary>
        /// 神器类型
        /// </summary>
        public  string  icon {get { return m_Icon; } }
       
        /// <summary>
        /// 修改的属性(类型|是否是百分比|数值)
        /// </summary>
        public  string  attrModifiers {get { return m_AttrModifiers; } }
       
        /// <summary>
        /// 等级
        /// </summary>
        public  int  level {get { return m_Level; } }
       

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
                    m_ReformType = dataR.ReadString();
                    break;
                case 2:
                    m_Icon = dataR.ReadString();
                    break;
                case 3:
                    m_AttrModifiers = dataR.ReadString();
                    break;
                case 4:
                    m_Level = dataR.ReadInt();
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
          ret.Add("ReformType", 1);
          ret.Add("Icon", 2);
          ret.Add("AttrModifiers", 3);
          ret.Add("Level", 4);
          return ret;
        }
    } 
}//namespace LR