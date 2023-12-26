using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameFrame;
using Game.Logic;

public class GameplayMgr : TMonoSingleton<GameplayMgr>
{
    private GameStateMachine m_GameStateMachine;
    private GameStateID m_CurrentState = GameStateID.None;

    public void Init()
    {
        UIMgr.S.ClosePanelAsUIID(UIID.LogoPanel);

        GameDataMgr.S.Init();

        AudioMgr.S.OnSingletonInit();

        EventSystem.S.Register(EngineEventID.OnApplicationQuit, ApplicationQuit);
        EventSystem.S.Register(EngineEventID.OnApplicationPauseChange, OnGamePauseChange);
        EventSystem.S.Register(EngineEventID.OnApplicationFocusChange, OnGameFocusChange);

        //Set language
        //I18Mgr.S.SwitchLanguage(SystemLanguage.German);

        GameMgr.S.StartGuide();

        m_GameStateMachine = new GameStateMachine(this);
        ChangeState(GameStateID.Lobby);

        Timer.S.Post2Really((count) =>
        {
            GameDataMgr.S.Save();
        }, 1, -1);
    }

    private void OnGamePauseChange(int key, params object[] args)
    {
        bool pause = (bool)args[0];
        if (!pause)
        {
            //TimeUpdateMgr.S.Resume();

            //if (GameWorldMgr.S.CurrentMode == GamePlayMode.ClassicMode &&
            //    ClassicModeMgr.S.IsLevelComplete)
            //{
            //    ClassicModeMgr.S.StartNextLevel();
            //}
        }
        else
        {
            //TimeUpdateMgr.S.Pause();
        }
    }

    private void OnGameFocusChange(int key, params object[] args)
    {
        bool focusState = (bool)args[0];
        if (focusState)
        {
            return;
        }

        GameDataMgr.S.Save();
    }

    private void ApplicationQuit(int key, params object[] args)
    {
        //GameDataMgr.S.GetPlayerInfoData().SetLoginTime();
        GameDataMgr.S.Save();
    }

    private void Update()
    {
        if (m_GameStateMachine != null)
        {
            m_GameStateMachine.UpdateState(Time.deltaTime);
        }
    }

    #region Public Methods

    public void ChangeState(GameStateID gameState)
    {
        if (m_CurrentState != gameState)
        {
            m_CurrentState = gameState;
            m_GameStateMachine.SetCurrentStateByID(gameState);
        }
    }
    #endregion
}
