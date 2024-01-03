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
            Position = new float3(0, 0f, 0),
            Rotation = Quaternion.identity,
            Scale = 1
        };
    }
}
