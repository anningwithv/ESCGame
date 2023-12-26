//Auto Generate Don't Edit it
using UnityEngine;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using GameFrame;

namespace Game.Logic
{
    public partial class TDCaptainSkillConfig
    {
        
       
        private EInt m_ID = 0;   
        private string m_Name;   
        private string m_Desc;   
        private string m_Icon;  
        
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
                default:
                    //TableHelper.CacheNewField(dataR, schemeNames[col], m_DataCacheNoGenerate);
                    break;
            }
          }

        }
        
        public static Dictionary<string, int> GetFieldHeadIndex()
        {
          Dictionary<string, int> ret = new Dictionary<string, int>(4);
          
          ret.Add("ID", 0);
          ret.Add("Name", 1);
          ret.Add("Desc", 2);
          ret.Add("Icon", 3);
          return ret;
        }
    } 
}//namespace LR