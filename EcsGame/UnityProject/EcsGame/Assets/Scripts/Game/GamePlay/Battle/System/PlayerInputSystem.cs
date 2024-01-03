using System.Collections;
using System.Collections.Generic;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

[BurstCompile]
public partial struct PlayerInputSystem : ISystem
{
    [BurstCompile]
    public void OnCreate(ref SystemState state) 
    {
        state.EntityManager.CreateSingleton<PlayerInput>();
        state.RequireForUpdate<GameStartTag>();
    }

    [BurstCompile]
    public void OnUpdate(ref SystemState state) 
    {
        ref var inputState = ref SystemAPI.GetSingletonRW<PlayerInput>().ValueRW;
        inputState.Horizontal = Input.GetAxisRaw("Horizontal");
        inputState.Vertical = Input.GetAxisRaw("Vertical");
    }
}
