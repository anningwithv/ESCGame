using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameFrame;
using Unity.Entities;

public class BattleMgr : TSingleton<BattleMgr>
{
    public bool BattleInited { get; private set; }

    private EntityManager m_EntityManager;
    private World m_DefaultWorld;

    public void Init()
    {
        m_DefaultWorld = World.DefaultGameObjectInjectionWorld;
        m_EntityManager = m_DefaultWorld.EntityManager;

        var gameCtrlEntity = GetGameCtrlEntity();
        m_EntityManager.AddComponent<GameStartTag>(gameCtrlEntity);

        BattleInited = true;
    }

    public void OnUpdate(float dt)
    { 
    }

    private Entity GetGameCtrlEntity()
    {
        var gameControllerQuery = m_EntityManager.CreateEntityQuery(ComponentType.ReadOnly<GameControllerTag>());
        return gameControllerQuery.GetSingletonEntity();
    }
}
