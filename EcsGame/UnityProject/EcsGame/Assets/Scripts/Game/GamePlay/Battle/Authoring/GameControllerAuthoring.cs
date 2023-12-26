using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class GameControllerAuthoring : MonoBehaviour
{
    public GameObject PlayerPrefab;
    public GameObject EnemyPrefab;
}

public class GameControllerBaker : Baker<GameControllerAuthoring>
{
    public override void Bake(GameControllerAuthoring authoring)
    {
        var entity = GetEntity(TransformUsageFlags.None);
        AddComponent(entity, new GameControllerTag());
        AddComponent(entity, new GameConfig()
        {
            PlayerPrefab = GetEntity(authoring.PlayerPrefab, TransformUsageFlags.Dynamic),
            EnemyPrefab = GetEntity(authoring.EnemyPrefab, TransformUsageFlags.Dynamic)
        });
    }
}
