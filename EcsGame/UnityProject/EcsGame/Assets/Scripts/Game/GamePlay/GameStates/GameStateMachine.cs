using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using GameFrame;

namespace Game.Logic
{
    public class GameStateMachine : FSMStateMachine<GameplayMgr>
    {
        public GameStateMachine(GameplayMgr mgr) : base(mgr)
        {
            InitStateFactory();
        }

        public GameState currentGameplayState
        {
            get
            {
                return base.currentState as GameState;
            }
        }

        public GameStateID currentStateID
        {
            get
            {
                var state = currentGameplayState;
                if (state == null)
                {
                    return GameStateID.None;
                }
                return state.stateID;
            }
        }

        public GameState GetState(GameStateID id)
        {
            GameState state = (GameState)stateFactory.GetState<GameStateID>(id);
            return state;
        }

        private void InitStateFactory()
        {
            stateFactory = new GameStateFactory(false);
        }
    }
}
