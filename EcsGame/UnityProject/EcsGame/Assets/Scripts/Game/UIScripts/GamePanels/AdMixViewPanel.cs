using System;
using System.Collections;
using System.Collections.Generic;
using GameFrame;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Logic
{
    public class AdMixViewPanel : AbstractAnimPanel
    {
        [SerializeField]
        protected string m_AdViewName = "MainMixView";
        [SerializeField]
        protected string m_AdFakeViewName = "FakeMixView";
        [SerializeField]
        //protected AdMixViewView m_AdView;
        //[SerializeField]
        //protected AdMixViewView m_AdViewFake;

        public static int count = 0;

        //protected AdMixViewView m_CuurrentView;

        protected override void OnUIInit()
        {
            base.OnUIInit();

        }

        protected override void OnPanelOpen(params object[] args)
        {
            base.OnPanelOpen(args);

           
            count++;
            
        }

        protected void OnClick(int key, params object[] param)
        {

        }
      
        protected override void OnClose()
        {
            base.OnClose();

            UnRegisterAllEvent();
        }

        protected override void OnPanelHideBegin()
        {
            base.OnPanelHideBegin();
            //HideMixAds();
        }

        protected override void OnPanelHideComplete()
        {
            base.OnPanelHideComplete();

            CloseSelfPanel();
        }

        private void OnOfflineBack(int key, params object[] args)
        {
            //HideMixAds();
        }

        //private void HideMixAds()
        //{

        //}
    }
}

