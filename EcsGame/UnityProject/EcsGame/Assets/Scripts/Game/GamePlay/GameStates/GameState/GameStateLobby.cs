using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using GameFrame;

namespace Game.Logic
{
    public class GameStateLobby : GameState
    {
        public GameStateLobby(GameStateID stateEnum) : base(stateEnum)
        {

        }

        public override void Enter(GameplayMgr handler)
        {
            Time.timeScale = 1;

            UIMgr.S.ClosePanelAsUIID(UIID.LogoPanel);

            //UIMgr.S.OpenPanel(UIID.LobbyPanel);
            //UIMgr.S.OpenPanel(UIID.ShopPanel);
            UIMgr.S.OpenTopPanel(UIID.MainMenuPanel, null);
            UIMgr.S.OpenTopPanel(UIID.TopInfoPanel, null);
        }

        public override void Exit(GameplayMgr handler)
        {
            //UIMgr.S.ClosePanelAsUIID(UIID.LobbyPanel);
            UIMgr.S.ClosePanelAsUIID(UIID.MainMenuPanel);
            UIMgr.S.ClosePanelAsUIID(UIID.TopInfoPanel);

        }

        public override void Execute(GameplayMgr handler, float dt)
        {

        }     
    }
}
