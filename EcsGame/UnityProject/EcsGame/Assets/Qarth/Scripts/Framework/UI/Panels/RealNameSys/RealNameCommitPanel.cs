﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GameFrame
{
    public class RealNameCommitPanel : AbstractPanel
    {
        [SerializeField]
        private Button m_BtnAgree;
        // [SerializeField]
        // private Button m_BtnDetail;

        [SerializeField]
        private Text m_TxtContent;

        [SerializeField]
        private InputField m_InputName;
        [SerializeField]
        private InputField m_InputCard;

        protected override void OnUIInit()
        {
            base.OnUIInit();
            m_BtnAgree.onClick.AddListener(OnClickAgree);
            //m_BtnDetail.onClick.AddListener(OnClickDetail);
        }

        protected override void OnOpen()
        {
            base.OnOpen();
            OpenDependPanel(EngineUI.MaskPanel, -1, null);
            m_TxtContent.text = string.Format(m_TxtContent.text, Application.productName);
        }

        protected override void OnClose()
        {
            base.OnClose();
        }

        void OnClickAgree()
        {
            if (string.IsNullOrEmpty(m_InputName.text) || string.IsNullOrEmpty(m_InputCard.text))
            {
                FloatMessage.S.ShowMsg(RealNameHelper.REALNAME_NEEDS);
                return;
            }

            if (RealNameHelper.ValidIDCard(m_InputCard.text))
            {
                var type = RealNameHelper.ValidAge18(m_InputCard.text);
                PlayerPrefs.SetInt(RealNameHelper.REALNAME_STATE_KEY, (int)type);
                switch (type)
                {
                    case RealNameHelper.RealNameAgeType.Over18:
                        {
                            RealNameMgr.S.PopSuccessWarning();
                        }
                        break;
                    case RealNameHelper.RealNameAgeType.Limited:
                        {
                            RealNameMgr.S.PopLimitWarning(RealNameHelper.REALNAME_TIME_LIMIT_START_WORDS);
                        }
                        break;
                    case RealNameHelper.RealNameAgeType.Invalid:
                    default:
                        {
                            RealNameMgr.S.PopCancelWarning(RealNameHelper.REALNAME_AGE_LIMIT_WORDS);
                        }
                        break;
                }

            }
            else
            {
                UIMgr.S.OpenTopPanel(EngineUI.RealNamePopPanel, null, "实名认证失败",
                    RealNameHelper.REALNAME_ID_ERROR, false);
            }
        }

        // void OnClickDetail()
        // {

        // }
    }
}
