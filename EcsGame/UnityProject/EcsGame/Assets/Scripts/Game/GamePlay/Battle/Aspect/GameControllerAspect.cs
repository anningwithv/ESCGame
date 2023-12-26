using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

public readonly partial struct GameControllerAspect : IAspect
{
    public readonly Entity Entity;

    public readonly RefRO<GameConfig> GameConfig;

    public LocalTransform GetPlayerSpawnTransform()
    {
        return new LocalTransform
        {
            Position = float3.zero,
            Rotation = Quaternion.identity,
            Scale = 1
        };
    }
}
