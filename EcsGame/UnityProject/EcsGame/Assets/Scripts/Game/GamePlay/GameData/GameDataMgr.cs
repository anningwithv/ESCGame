using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameFrame;
using System;

namespace Game.Logic
{
    /// <summary>
    /// GameData对外交互类
    /// </summary>
    public class GameDataMgr : TSingleton<GameDataMgr>
    {
        private GameDataHandler m_GameDataHandler = null;

        public GameDataHandler GameDataHandler
        {
            get
            {
                return m_GameDataHandler;
            }
        }

        public void Init()
        {
            m_GameDataHandler = new GameDataHandler();

            RegisterEvents();

            //m_GameDataHandler.GetBagData().Init();
        }

        private void RegisterEvents()
        {
            //EventSystem.S.Register(EventID.OnLevelCompleted, HandleEvent);
            EventSystem.S.Register(EventID.OnAddCoinNum, HandleEvent);
        }

        private void HandleEvent(int eventId, params object[] param)
        {
            //if (eventId == (int)EventID.OnLevelCompleted)
            //{
            //    int levelIndex = (int)param[0];
            //    int starNum = (int)param[1];

            //    m_GameDataHandler.GetPlayerInfodata().OnLevelCompleted(levelIndex, starNum);
            //}
            //if (eventId == (int)EventID.OnAddCoinNum)
            //{
            //    int delta = (int)param[0];
            //    m_GameDataHandler.GetPlayerInfodata().AddCoinNum(delta);
            //}
        }

        public void Save()
        {
            m_GameDataHandler.Save();
        }

        /// <summary>
        /// 获取所有游戏数据
        /// </summary>
        /// <returns></returns>
        public GameData GetGameData()
        {
            return m_GameDataHandler.GetGameData();
        }

        //public BagData GetBagData()
        //{
        //    return m_GameDataHandler.GetBagData();
        //}

        //public PlayerData GetPlayerData()
        //{
        //    return m_GameDataHandler.GetPlayerData();
        //}

        //public ShipData GetShipData()
        //{
        //    return m_GameDataHandler.GetShipData();
        //}

        //public ShopData GetShopData()
        //{
        //    return m_GameDataHandler.GetShopData();
        //}

        //public SettingData GetSettingData()
        //{
        //    return m_GameDataHandler.GetSettingData();
        //}

        //public BattleData GetBattleData()
        //{
        //    return m_GameDataHandler.GetBattleData();
        //}

        //public TalentData GetTalentData()
        //{
        //    return m_GameDataHandler.GetTalentData();
        //}

        public void OnReset()
        {
     
        }
    }
}