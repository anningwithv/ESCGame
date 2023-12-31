﻿
using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Game.Logic;

namespace GameFrame
{
    public class AbstractApplicationMgr<T> : TMonoSingleton<T> where T : TMonoSingleton<T>
    {
        public Action onApplicationUpdate = null;
        public Action onApplicationOnGUI = null;

        protected void Start()
        {
            StartApp();
        }

        //初始化第三方插件，初始化环境
        protected void StartApp()
        {
            I18Mgr.S.Init();
            InitThirdLibConfig();
            InitAppEnvironment();
            StartGame();
        }

        #region 子类实现

        protected virtual void InitThirdLibConfig()
        {

        }

        protected virtual void InitAppEnvironment()
        {

        }

        protected virtual void StartGame()
        {

        }

        #endregion

        void OnApplicationQuit()
        {
            MonoSingleton.isApplicationQuit = true;

            EventSystem.S.Send(EngineEventID.OnApplicationQuit);
        }

        void OnApplicationPause(bool pauseStatus)
        {
            EventSystem.S.Send(EngineEventID.OnApplicationPauseChange, pauseStatus);
            EventSystem.S.Send(EngineEventID.OnAfterApplicationPauseChange, pauseStatus);
        }

        void OnApplicationFocus(bool focusStatus)
        {
            EventSystem.S.Send(EngineEventID.OnApplicationFocusChange, focusStatus);
            EventSystem.S.Send(EngineEventID.OnAfterApplicationFocusChange, focusStatus);
        }

        void Update()
        {
            if (onApplicationUpdate != null)
            {
                onApplicationUpdate();
            }
        }

        void OnGUI()
        {
            if (onApplicationOnGUI != null)
            {
                onApplicationOnGUI();
            }
        }
    }
}
