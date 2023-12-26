using System.Collections;
using System.Collections.Generic;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

[BurstCompile]
public partial struct PlayerSpawnSystem : ISystem
{
    [BurstCompile]
    public void OnCreate(ref SystemState state) 
    {
        state.RequireForUpdate<GameStartTag>();
    }

    [BurstCompile]
    public void OnUpdate(ref SystemState state) 
    {
        state.Enabled = false;

        var gameCtrlEntity = SystemAPI.GetSingletonEntity<GameConfig>();
        var gameCtrlApsect = SystemAPI.GetAspect<GameControllerAspect>(gameCtrlEntity);

        var ecb = new EntityCommandBuffer(Allocator.Temp);
        var player = ecb.Instantiate(gameCtrlApsect.GameConfig.ValueRO.PlayerPrefab);
        ecb.SetComponent(player, gameCtrlApsect.GetPlayerSpawnTransform());
        ecb.Playback(state.EntityManager);
    }
}
