using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using GameFrame;

namespace Game.Logic
{
    public class GameStateBattle : GameState
    {
        public GameStateBattle(GameStateID stateEnum) : base(stateEnum)
        {

        }

        public override void Enter(GameplayMgr handler)
        {
            UIMgr.S.ClosePanelAsUIID(UIID.MainMenuPanel);

            UIMgr.S.OpenPanel(UIID.BattlePanel);
            UIMgr.S.OpenPanel(UIID.JoystickPanel);
            //UIMgr.S.OpenPanel(UIID.SceneTransitionPanel);

            BattleMgr.S.Init();
        }

        public override void Exit(GameplayMgr handler)
        {
            UIMgr.S.ClosePanelAsUIID(UIID.BattlePanel);
            UIMgr.S.ClosePanelAsUIID(UIID.JoystickPanel);
        }

        public override void Execute(GameplayMgr handler, float dt)
        {
            BattleMgr.S.OnUpdate(dt);
        }
    }
}
