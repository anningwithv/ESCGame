using System.Collections;
using System.Collections.Generic;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

[BurstCompile]
public partial struct PlayerMoveSystem : ISystem
{
    [BurstCompile]
    public void OnCreate(ref SystemState state) 
    {
        state.RequireForUpdate<GameStartTag>();
        state.RequireForUpdate<PlayerTag>();
    }

    [BurstCompile]
    public void OnUpdate(ref SystemState state) 
    {
        var inputState = SystemAPI.GetSingletonRW<PlayerInput>().ValueRO;
        var playerConfig = SystemAPI.GetSingleton<PlayerConfig>();
        float3 moveDir = new float3(inputState.Horizontal, 0, inputState.Vertical);
        if (moveDir.Equals(float3.zero))
            return;
        moveDir = math.normalize(moveDir);
        float3 deltaPos = moveDir * SystemAPI.Time.DeltaTime * playerConfig.MoveSpeed;
        if (deltaPos.Equals(float3.zero))
            return;
        var playerEntity = SystemAPI.GetSingletonEntity<PlayerTag>();
        var transform = SystemAPI.GetComponentRW<LocalTransform>(playerEntity);
        transform.ValueRW.Position += deltaPos;
        //state.EntityManager.SetComponentData(playerEntity, new M)
    }
}
