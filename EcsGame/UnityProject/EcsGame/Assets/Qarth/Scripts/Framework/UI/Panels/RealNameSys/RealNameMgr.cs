using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace GameFrame
{
    public class RealNameMgr : TSingleton<RealNameMgr>
    {
        private Action m_PopConfirmCallback;
        private int m_LimitTimer = -1;
        private int m_LimitCheckCount = 240;
        private int m_LimitCheckDurtion = 30;

        public void Init()
        {
            var state = PlayerPrefs.GetInt(RealNameHelper.REALNAME_STATE_KEY, -1);
            switch (state)
            {
                case -1:
                    UIMgr.S.OpenTopPanel(EngineUI.RealNamePanel, null);
                    break;
                case (int)RealNameHelper.RealNameAgeType.Limited:
                    PopLimitWarning(RealNameHelper.REALNAME_TIME_LIMIT_START_WORDS);
                    break;
                case (int)RealNameHelper.RealNameAgeType.Invalid:
                    PopCancelWarning(RealNameHelper.REALNAME_AGE_LIMIT_WORDS);
                    break;
                default:
                    EventSystem.S.Send(EngineEventID.OnRealNameValidOver18, true);
                    break;
            }
        }

        public void RegisterPanels()
        {
            UIDataTable.SetABMode(false);
            UIDataTable.AddPanelData(EngineUI.RealNamePanel, null, "RealNamePanel/RealNamePanel", true);
            UIDataTable.AddPanelData(EngineUI.RealNameCommitPanel, null, "RealNamePanel/RealNameCommitPanel", true);
            UIDataTable.AddPanelData(EngineUI.RealNamePopPanel, null, "RealNamePanel/RealNamePopPanel", true);
        }

        void SetPopConfirmCallback(Action callback)
        {
            m_PopConfirmCallback = callback;
        }

        public bool InvokePopConfirmCallback()
        {
            if (m_PopConfirmCallback != null)
            {
                m_PopConfirmCallback.Invoke();
                m_PopConfirmCallback = null;
                return true;
            }
            return false;
        }

        public void PopSuccessWarning()
        {
            SetPopConfirmCallback(() =>
            {
                EventSystem.S.Send(EngineEventID.OnRealNameValidOver18, true);
                UIMgr.S.ClosePanelAsUIID(EngineUI.RealNameCommitPanel);
            });
            UIMgr.S.OpenTopPanel(EngineUI.RealNamePopPanel, null, "实名认证成功",
                string.Format("客服邮箱:\n{0}", AppConfig.S.SupportMail), true);
        }

        public void PopLimitWarning(string desc)
        {
            bool isOver = false;
            if (CustomExtensions.CheckIsNewDay(RealNameHelper.REALNAME_DAILY_KEY) > 0)
            {
                PlayerPrefs.SetInt(RealNameHelper.REALNAME_LIMIT_PLAY_TIME, 0);
            }
            else
            {
                isOver = CheckLimitTime();
            }

            if (!isOver)
            {
                SetPopConfirmCallback(() =>
                {
                    EventSystem.S.Send(EngineEventID.OnRealNameValidOver18, false);
                    m_LimitTimer = Timer.S.Post2Really(OnLimitTimerTick, m_LimitCheckDurtion, -1);
                    UIMgr.S.ClosePanelAsUIID(EngineUI.RealNameCommitPanel);
                });
                UIMgr.S.OpenTopPanel(EngineUI.RealNamePopPanel, null, "提示", desc, true);
            }
            else
                PopCancelWarning(RealNameHelper.REALNAME_TIME_LIMIT_OVER_WORDS);
        }

        public void PopCancelWarning(string desc)
        {
            SetPopConfirmCallback(() =>
            {
                Quit();
            });
            UIMgr.S.OpenTopPanel(EngineUI.RealNamePopPanel, null, "提示", desc, true);
        }

        void OnLimitTimerTick(int count)
        {
            var min = PlayerPrefs.GetInt(RealNameHelper.REALNAME_LIMIT_PLAY_TIME, 0);
            PlayerPrefs.SetInt(RealNameHelper.REALNAME_LIMIT_PLAY_TIME, min + 1);
            CheckLimitTime();
        }

        bool CheckLimitTime()
        {
            ////Log.e(PlayerPrefs.GetInt(RealNameHelper.REALNAME_LIMIT_PLAY_TIME, 0));
            if (PlayerPrefs.GetInt(RealNameHelper.REALNAME_LIMIT_PLAY_TIME, 0) >= m_LimitCheckCount)
            {
                if (m_LimitTimer > 0)
                {
                    Timer.S.Cancel(m_LimitTimer);
                    m_LimitTimer = -1;
                }
                PopCancelWarning(RealNameHelper.REALNAME_TIME_LIMIT_OVER_WORDS);
                return true;
            }
            return false;
        }

        public void Quit()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            //Application.Quit();
            System.Diagnostics.Process.GetCurrentProcess().Kill();
#endif
        }
    }
}