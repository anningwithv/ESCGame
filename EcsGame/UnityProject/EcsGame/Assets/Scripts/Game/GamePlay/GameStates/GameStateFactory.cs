using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using GameFrame;

namespace Game.Logic
{
    public class GameStateFactory : FSMStateFactory<GameplayMgr>
    {
        public GameStateFactory(bool alwaysCreate) : base(alwaysCreate)
        {
            InitStateCreator();
        }

        private void InitStateCreator()
        {
            RegisterPlayerState(GameStateID.Lobby, new GameStateLobby(GameStateID.Lobby));
            RegisterPlayerState(GameStateID.Battle, new GameStateBattle(GameStateID.Battle));
        }

        private void RegisterPlayerState(GameStateID id, GameState state)
        {
            state.stateID = id;
            RegisterState(id, state);
        }

        //public CharacterState GetState(CharacterStateID id)
        //{
        //    CharacterState state = (CharacterState)GetState<CharacterStateID>(id);
        //    return state;
        //}
    }
}
