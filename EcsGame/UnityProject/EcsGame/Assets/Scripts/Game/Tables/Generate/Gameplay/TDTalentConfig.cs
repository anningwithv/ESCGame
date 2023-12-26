//Auto Generate Don't Edit it
using UnityEngine;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using GameFrame;

namespace Game.Logic
{
    public partial class TDTalentConfig
    {
        
       
        private EInt m_Id = 0;   
        private string m_Name;   
        private string m_Desc;   
        private string m_Icon;   
        private EInt m_Row = 0;   
        private string m_Costs;   
        private string m_Param;  
        
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
        /// 描述
        /// </summary>
        public  string  desc {get { return m_Desc; } }
       
        /// <summary>
        /// 图标
        /// </summary>
        public  string  icon {get { return m_Icon; } }
       
        /// <summary>
        /// 所在行
        /// </summary>
        public  int  row {get { return m_Row; } }
       
        /// <summary>
        /// 所在行
        /// </summary>
        public  string  costs {get { return m_Costs; } }
       
        /// <summary>
        /// 所在行
        /// </summary>
        public  string  param {get { return m_Param; } }
       

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
                    m_Desc = dataR.ReadString();
                    break;
                case 3:
                    m_Icon = dataR.ReadString();
                    break;
                case 4:
                    m_Row = dataR.ReadInt();
                    break;
                case 5:
                    m_Costs = dataR.ReadString();
                    break;
                case 6:
                    m_Param = dataR.ReadString();
                    break;
                default:
                    //TableHelper.CacheNewField(dataR, schemeNames[col], m_DataCacheNoGenerate);
                    break;
            }
          }

        }
        
        public static Dictionary<string, int> GetFieldHeadIndex()
        {
          Dictionary<string, int> ret = new Dictionary<string, int>(7);
          
          ret.Add("Id", 0);
          ret.Add("Name", 1);
          ret.Add("Desc", 2);
          ret.Add("Icon", 3);
          ret.Add("Row", 4);
          ret.Add("Costs", 5);
          ret.Add("Param", 6);
          return ret;
        }
    } 
}//namespace LR