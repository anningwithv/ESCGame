using GameFrame;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Logic
{
    public class GameDataHandler : DataClassHandler<GameData>
    {
        public static DataDirtyRecorder s_DataDirtyRecorder = new DataDirtyRecorder();

        public static string s_path { get { return dataFilePath; } }

        public GameDataHandler()
        {
            Load();
            //EnableAutoSave();
        }

        public GameData GetGameData()
        {
            return m_Data;
        }

        public void Save()
        {
            Save(true);
        }

        //public BagData GetBagData()
        //{
        //    return m_Data.bagData;
        //}

        //public PlayerData GetPlayerData()
        //{
        //    return m_Data.playerData;
        //}

        //public ShipData GetShipData()
        //{
        //    return m_Data.shipData;
        //}

        //public ShopData GetShopData()
        //{
        //    return m_Data.shopData;
        //}

        //public SettingData GetSettingData()
        //{
        //    return m_Data.settingData;
        //}

        //public BattleData GetBattleData()
        //{
        //    return m_Data.battleData;
        //}

        //public TalentData GetTalentData()
        //{
        //    return m_Data.talentData;
        //}
    }
}