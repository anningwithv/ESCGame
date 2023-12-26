using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using GameFrame;

namespace Game.Logic
{
    public enum GameStateID
    {
        None,
        Lobby,
        Battle
    }

    public class GameState : FSMState<GameplayMgr>
    {
        public GameStateID stateID
        {
            get;
            set;
        }

        public GameState(GameStateID stateEnum)
        {
            stateID = stateEnum;
        }

        public override void Enter(GameplayMgr handler)
        {
        }

        public override void Exit(GameplayMgr handler)
        {
        }

        public override void Execute(GameplayMgr handler, float dt)
        {
        }
    }
}
