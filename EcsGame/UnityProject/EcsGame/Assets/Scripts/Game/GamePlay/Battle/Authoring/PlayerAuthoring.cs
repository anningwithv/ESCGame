using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;
using static PlayerComponents;

public class PlayerAuthoring : MonoBehaviour
{
    public float MoveSpeed;

    public float GetMoveSpeed()
    {
        return MoveSpeed;
    }
}

public class PlayerBaker : Baker<PlayerAuthoring>
{
    public override void Bake(PlayerAuthoring authoring)
    {
        var entity = GetEntity(TransformUsageFlags.Dynamic);
        AddComponent(entity, new PlayerTag());
        AddComponent(entity, new PlayerConfig()
        {
            MoveSpeed = authoring.GetMoveSpeed()
        });
    }
}
