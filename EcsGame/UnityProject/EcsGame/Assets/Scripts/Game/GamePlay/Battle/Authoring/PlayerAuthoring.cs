using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class PlayerAuthoring : MonoBehaviour
{
    public float MoveSpeed;
    //public GameObject PlayerGameObjectPrefab;

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
        //AddComponentObject(entity, new PlayerGameObjectPrefab { Value = authoring.PlayerGameObjectPrefab });
    }
}