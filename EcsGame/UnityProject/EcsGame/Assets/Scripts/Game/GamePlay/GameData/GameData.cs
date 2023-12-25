using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameFrame;

namespace Game.Logic
{
    public class GameData : IDataClass
    {
        //public PlayerData playerData = null;
        //public BagData bagData = null;
        //public ShipData shipData = null;
        //public ShopData shopData = null;
        //public SettingData settingData = null;
        //public BattleData battleData = null;
        //public TalentData talentData = null;

        public GameData()
        {
            SetDirtyRecorder(GameDataHandler.s_DataDirtyRecorder);
        }

        public override void InitWithEmptyData()
        {
            //playerData = new PlayerData();
            //playerData.SetDefaultValue();

            //bagData = new BagData();
            //bagData.SetDefaultValue();

            //shipData = new ShipData();
            //shipData.SetDefaultValue();

            //shopData = new ShopData();
            //shopData.SetDefaultValue();

            //settingData = new SettingData();
            //settingData.SetDefaultValue();

            //battleData = new BattleData();
            //battleData.SetDefaultValue();

            //talentData = new TalentData();
            //talentData.SetDefaultValue();
        }

        public override void OnDataLoadFinish()
        {
            //playerData.SetDirtyRecorder(m_Recorder);
            //bagData.SetDirtyRecorder(m_Recorder);
            //shipData.SetDirtyRecorder(m_Recorder);
            //shopData.SetDirtyRecorder(m_Recorder);
            //settingData.SetDirtyRecorder(m_Recorder);
            //battleData.SetDirtyRecorder(m_Recorder);
            //talentData.SetDirtyRecorder(m_Recorder);
        }
    }
}
